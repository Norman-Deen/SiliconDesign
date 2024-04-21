namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController(Infrastructure.Contexts.ApplicationContext context) : ControllerBase
{
    private readonly Infrastructure.Contexts.ApplicationContext _context =  context;




    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        var courses = await _context.Courses.ToListAsync();
        return Ok(courses);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(string id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var courseEntity = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        if (courseEntity != null)
        {
            return Ok(courseEntity);
        }
        return NotFound();
    }



}
