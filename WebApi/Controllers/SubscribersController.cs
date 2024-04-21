namespace WebApi.Controllers;




[Route("api/[controller]")]
[ApiController]
public class SubscribersController(ApplicationContext context) : ControllerBase
{
    private readonly ApplicationContext _context = context;



    #region CREATE endpoint

    [HttpPost]
    public async Task<IActionResult> Subscribe([FromBody] SubscriberEntity dto)
    {

        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }

        try
        {
            if (await _context.Subscribers.AnyAsync(x => x.Email == dto.Email))
            {
                return StatusCode(StatusCodes.Status409Conflict, $"Email: \"{dto.Email}\" already subscribed!");
            }

            var subscriber = new SubscriberEntity {
                Email = dto.Email,
                DailyNewsletter = dto.DailyNewsletter,
                AdvertisingUpdates = dto.AdvertisingUpdates,
                WeekinReview = dto.WeekinReview,
                EventUpdates = dto.EventUpdates,
                StartupsWeekly = dto.StartupsWeekly,
                Podcasts = dto.Podcasts
            };

            _context.Subscribers.Add(subscriber);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created, $"Subscriber \"{dto.Email}\" created successfully");
        }
        catch { return Problem("Faild to create Subscribtion");}
    }

    #endregion




    #region READ endpoint

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }
        try
        {
            var Sub = await _context.Subscribers.ToListAsync();
            if (Sub.Count != 0) { return Ok(Sub); }
            return NotFound("No subscribers found.");
        }
        catch (Exception ) { return Problem("An error occurred while fetching subscribers. Please try again later.", statusCode: 500); }
    }



    [HttpGet("{email}")]
    public async Task<IActionResult> GetOne(string email)
    {

        if (!ModelState.IsValid)
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }
        try
        {
            var sub = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
            if (sub == null) { return BadRequest($"Subscriber with email: \"{email}\" not found!"); }
            return Ok(sub);
        }
        catch (Exception ) { return Problem("An error occurred while fetching subscribers. Please try again later.", statusCode: 500); }
    }

    #endregion




    #region DELETE

    [HttpDelete("{email}")]
    public async Task<IActionResult> Delete(string email)
    {
        if(!ModelState.IsValid) 
        {
            return StatusCode(StatusCodes.Status400BadRequest, ModelState);
        }
        
        var sub = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
        if (sub == null)
        {
            return NotFound($"Subscriber with email: \"{email}\" not found");
        }

        try
        {
            _context.Subscribers.Remove(sub);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, $"Subscriber with email: \"{email}\" deleted successfully");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"Unable to delete subscriber with email: \"{email}\" !");
        }
        
      
    }


    #endregion


}

