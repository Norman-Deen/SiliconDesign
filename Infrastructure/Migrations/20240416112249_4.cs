using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "19b557d0-bdab-456f-9595-2565a82fb7af");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "4f7a0a9e-3d31-4dfc-b3f8-77f736187896");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "5fe860ae-42e1-48b5-813f-90263f8fe9d4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "6d58c745-089d-4b25-ad1e-741e2979f275");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "759375a6-fdd9-4f01-ad9a-9348c783fb98");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "8af1b321-8eda-4d4d-acf5-af1e79a4086f");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "cc7144c2-f3e4-44bf-89be-4f47b63fa35e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d3cf5240-ff63-43c8-b118-f67ecde6ff22");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "ed744a1e-82ae-463d-9bde-7149360362f3");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Courses",
                newName: "TitleDescription");

            migrationBuilder.AddColumn<string>(
                name: "AuthorDescription",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorImagePath",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseDescription",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseGoal1",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseGoal2",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseGoal3",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseGoal4",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseGoal5",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseImagePath",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseIncludes1",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseIncludes2",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseIncludes3",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseIncludes4",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseIncludes5",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription1",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription2",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription3",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription4",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription5",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailDescription6",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle1",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle2",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle3",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle4",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle5",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramDetailTitle6",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "AuthorDescription", "AuthorImagePath", "CourseDescription", "CourseGoal1", "CourseGoal2", "CourseGoal3", "CourseGoal4", "CourseGoal5", "CourseImagePath", "CourseIncludes1", "CourseIncludes2", "CourseIncludes3", "CourseIncludes4", "CourseIncludes5", "DiscountPrice", "Hours", "IsBestseller", "LikesInNumbers", "LikesInProcent", "OriginalPrice", "ProgramDetailDescription1", "ProgramDetailDescription2", "ProgramDetailDescription3", "ProgramDetailDescription4", "ProgramDetailDescription5", "ProgramDetailDescription6", "ProgramDetailTitle1", "ProgramDetailTitle2", "ProgramDetailTitle3", "ProgramDetailTitle4", "ProgramDetailTitle5", "ProgramDetailTitle6", "Title", "TitleDescription" },
                values: new object[,]
                {
                    { "16fd8af4-3c38-402c-9a5f-ae70d09fae47", "Esther Howard", "Esther Howard is a data scientist with a strong background in mathematics and computer science. She has extensive experience in machine learning, data analysis, and statistical modeling. Esther is passionate about teaching and sharing her knowledge with others. She believes in making complex concepts accessible to everyone and enjoys helping students build practical skills in data science and machine learning. In her free time, Esther enjoys hiking, reading, and experimenting with new data science techniques.", null, "Dive into the fascinating world of data science and machine learning with Python. In this comprehensive course, you'll learn how to analyze large datasets, build predictive models, and extract valuable insights from data. Whether you're a beginner or an experienced programmer, this course will equip you with the skills and knowledge needed to succeed in the field of data science. From data preprocessing to model evaluation, you'll explore every step of the data science pipeline and gain hands-on experience with real-world datasets.", "Master the fundamentals of Python programming language for data science and machine learning.", "Learn how to manipulate and visualize data using popular Python libraries such as NumPy, Pandas, and Matplotlib.", "Understand essential concepts in machine learning, including supervised and unsupervised learning algorithms.", "Explore advanced machine learning techniques such as ensemble learning, dimensionality reduction, and deep learning.", "Gain practical experience by working on real-world data science projects and case studies.", "data_science.svg", "Over 120 video lectures covering essential data science and machine learning topics", "Hands-on projects and exercises to reinforce learning and build practical skills", "Quizzes and assessments to test your understanding of key concepts", "Access to downloadable datasets and code resources", "Certificate of completion upon finishing the course", 0m, 160, true, 3100m, 0.92m, 11.20m, "Overview of data science and machine learning, setting up Python environment, and understanding basic data science concepts.", "Learn the basics of Python programming language and explore its applications in data science and machine learning.", "Explore data manipulation and visualization techniques using popular Python libraries such as NumPy, Pandas, and Matplotlib.", "Understand essential machine learning concepts and algorithms, including linear regression, classification, and clustering.", "Explore advanced machine learning techniques such as ensemble methods, dimensionality reduction, and neural networks.", "Apply your skills to real-world data science projects and case studies, and gain practical experience in solving complex problems.", "Introduction to Data Science", "Python for Data Science", "Data Manipulation and Visualization", "Machine Learning Fundamentals", "Advanced Machine Learning Techniques", "Real-world Projects", "Data Science & Machine Learning with Python", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "421a59de-432c-4149-90d8-c55e30f6ccf0", "Robert Fox", "Robert Fox is a seasoned full-stack web developer with over 10 years of experience in the industry. He has a passion for teaching and has helped thousands of students worldwide master web development concepts. With expertise in HTML, CSS, JavaScript, and various backend technologies, Robert brings a wealth of knowledge to his courses. He believes in hands-on learning and practical examples, ensuring that his students gain real-world skills that they can apply immediately. Outside of coding, Robert enjoys hiking, playing the guitar, and experimenting with new tech gadgets.\r\n", null, "Welcome to the Fullstack Web Developer Course from Scratch! In this comprehensive 220-hour course, you'll master HTML, CSS, JavaScript, and backend technologies. Learn to build responsive websites, dynamic web apps, and deploy them to production. Gain essential soft skills for a successful career. Enroll now and kickstart your journey to becoming a professional full-stack developer!", "Master core full-stack web development principles.", "Design responsive web interfaces with CSS.", "Implement dynamic web applications using JavaScript.", "Learn server-side programming and database management.", "Develop user-friendly and interactive web apps.", "fullstack_web_dev.svg", "148 hours on-demand video", "18 articles", "25 downloadable resources", "Full lifetime access", "Certificate of completion", 0m, 220, true, 4200m, 0.94m, 12.50m, "Begin your journey into web development with this introductory section. Explore the basic concepts and tools needed to start building web applications. Understand the structure of web pages, the role of HTML, and the basics of setting up your development environment. By the end of this section, you'll have a solid foundation to build upon as you progress through the course.", "Take your HTML skills to the next level with this advanced HTML course. Learn advanced techniques for structuring content, creating semantic markup, and optimizing code for performance. Dive deep into topics like responsive design, multimedia integration, and accessibility to create modern and interactive web experiences.", "Master the fundamentals of CSS and CSS3 to style and design your web pages. Learn about selectors, properties, and the box model to control layout and appearance. Explore basic CSS techniques for styling text, backgrounds, and borders, and understand how to use CSS frameworks for rapid development. By the end of this section, you'll have a solid understanding of CSS basics and be ready to enhance your web pages with style.", "Get started with JavaScript and unlock the power of dynamic web development. Learn the basics of JavaScript syntax, variables, and data types, and understand how to use control structures and functions to create interactive web applications. Dive into DOM manipulation to dynamically update web content and handle user interactions. By the end of this section, you'll have a strong foundation in JavaScript programming and be ready to tackle more advanced concepts.", "Discover the world of APIs and their role in modern web development. Learn how to consume APIs to access external data and services and integrate them into your web applications. Understand common API architectures, such as RESTful APIs, and learn best practices for making API requests and handling responses. By the end of this section, you'll have a solid understanding of APIs and be able to leverage them to enhance your web projects.", "Take your web development skills to the next level with C# and .NET. Learn the fundamentals of C# programming, including data types, control structures, and object-oriented programming concepts. Explore the .NET framework and understand how to use it to build scalable and secure web applications. Dive into advanced topics like asynchronous programming, LINQ, and MVC architecture to develop robust and maintainable web solutions. By the end of this section, you'll have the skills and knowledge to build professional-grade web applications with C# and .NET.", "Introduction. Getting started", "The ultimate HTML developer: advanced HTML", "CSS & CSS3: basic", "JavaScript basics for beginners", "Understanding APIs", "C# and .NET from beginner to advanced", "Fullstack Web Developer Course from Scratch", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "49be8ed9-be17-43b1-bddf-ad61ce15f3f3", "Albert Flores", "Albert Flores is a seasoned game developer and Unity expert with a passion for creating engaging and immersive experiences. With years of experience in the industry, he has worked on numerous successful game projects across various platforms. Albert is known for his practical approach to game development and his ability to explain complex concepts in a clear and accessible manner. Through his courses and tutorials, Albert aims to empower aspiring game developers to bring their ideas to life and succeed in the competitive world of game development.", null, "Unlock the secrets of 2D mobile game development with Unity, the world's leading game development platform. In this comprehensive course, you'll learn how to create your own 2D mobile games from scratch using Unity's powerful tools and features. Whether you're a beginner or an experienced developer, this course will take you step-by-step through the process of building fun and addictive games for iOS and Android devices. With hands-on projects and real-world examples, you'll gain the skills and confidence to turn your game ideas into reality.", "Learn the fundamentals of Unity's interface and workflow for 2D game development.", "Understand the principles of game design and learn how to create engaging gameplay experiences.", "Master Unity's 2D physics system and learn how to create realistic interactions between game objects.", "Explore advanced topics such as UI design, mobile optimization, and monetization strategies for mobile games.", "Build a portfolio of 2D mobile games to showcase your skills to potential employers or clients.", "ui_ux_design.svg", "Over 80 video lectures covering essential Unity techniques and workflows for 2D game development", "Hands-on projects and exercises to reinforce learning and build practical skills", "Quizzes and assessments to test your understanding of key concepts", "Access to downloadable resources and project files", "Certificate of completion upon finishing the course", 12.99m, 100, false, 2700m, 0.98m, 44.99m, "Overview of Unity's interface and tools, setting up the workspace, and understanding basic game development concepts.", "Learn the principles of game design and discover how to create engaging gameplay experiences for players.", "Master Unity's 2D physics system and learn how to create realistic interactions between game objects.", "Explore UI design principles and learn how to optimize your game for mobile devices.", "Discover monetization strategies for mobile games, including ads, in-app purchases, and premium pricing models.", "Build a portfolio of 2D mobile games to showcase your skills to potential employers or clients.", "Introduction to Unity", "Game Design Principles", "2D Physics and Interactions", "UI Design and Optimization", "Monetization Strategies", "Portfolio Development", "The Ultimate Guide to 2D Mobile Game Development with Unity", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "7f4c432f-868e-4b9b-b5ac-b38846a673d8", "Jenny Wilson", "Jenny Wilson is a skilled software engineer with expertise in performance testing and quality assurance. With years of experience in the industry, she has worked on numerous projects involving performance testing of web applications, APIs, and microservices. Jenny is passionate about teaching and sharing her knowledge with others. She believes that performance testing is a crucial aspect of software development and aims to help developers and testers improve the performance and reliability of their applications.", null, "Master the art of performance testing with JMeter in this comprehensive course. Whether you're a beginner or an experienced tester, this course will teach you everything you need to know to conduct effective performance tests on live applications. From setting up test plans to analyzing test results, you'll learn how to use JMeter's powerful features and capabilities to identify performance bottlenecks and optimize the performance of your applications. With hands-on exercises and real-world examples, you'll gain the skills and confidence to tackle performance testing challenges in your projects.", "Learn how to install and configure JMeter for performance testing.", "Understand the fundamentals of performance testing and its importance in software development.", "Master JMeter's features and functionalities for conducting performance tests on web applications and APIs.", "Explore advanced topics such as load distribution, parameterization, and scripting in JMeter.", "Gain insights into performance test analysis and reporting, and learn how to interpret test results effectively.", "jmeter_performance_testing.svg", "Over 100 video lectures covering essential JMeter techniques and workflows for performance testing", "Hands-on exercises and real-world examples to reinforce learning and build practical skills", "Quizzes and assessments to test your understanding of key concepts", "Access to downloadable resources and sample test plans", "Certificate of completion upon finishing the course", 0m, 160, false, 3100m, 0.92m, 14.50m, "Overview of performance testing concepts, setting up JMeter environment, and understanding basic JMeter features.", "Learn how to install and configure JMeter for performance testing, and explore its user interface and components.", "Understand the process of creating test plans in JMeter, including configuring thread groups, samplers, and listeners.", "Learn how to execute performance tests using JMeter, and explore advanced features such as assertions, timers, and controllers.", "Gain insights into performance test analysis and reporting, and learn how to interpret test results effectively.", "Apply your skills to real-world applications and conduct performance tests on live applications to identify performance bottlenecks and optimize application performance.", "Introduction to Performance Testing", "Getting Started with JMeter", "Creating Test Plans", "Executing Tests", "Test Analysis and Reporting", "Real-world Applications", "Learn JMeter from Scratch on Live Apps: Performance Testing", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "951e6e5f-87e7-4c4a-bac0-e0c60dc9f7a7", "Albert Flores", "Albert Flores is a dedicated front-end developer with a passion for creating beautiful and interactive user interfaces. With years of experience in the industry, he has worked on a variety of projects ranging from small business websites to large-scale web applications. Albert is committed to staying updated with the latest front-end technologies and best practices, ensuring that his courses provide students with valuable and relevant skills. Outside of coding, he enjoys hiking, playing the piano, and exploring new coffee shops.", null, "Dive into the world of front-end web development with this comprehensive course. Whether you're a beginner or an experienced developer looking to enhance your skills, this course has something for everyone. From HTML and CSS basics to advanced JavaScript concepts, you'll learn everything you need to know to build modern and responsive websites. With hands-on projects and real-world examples, you'll gain practical experience that you can apply to your own projects.", "Master HTML5 markup language and understand its semantic elements.", "Learn advanced CSS techniques including flexbox, grid layout, and CSS animations.", "Gain proficiency in JavaScript programming, including ES6 syntax and DOM manipulation.", "Understand responsive web design principles and techniques using media queries and viewport units.", "Explore popular front-end frameworks and libraries such as Bootstrap and React.", "front_end_dev.svg", "Over 80 lectures covering essential front-end topics", "Hands-on projects to reinforce learning and build real-world skills", "Quizzes and coding exercises to test your understanding", "Access to downloadable resources and code samples", "Certificate of completion upon finishing the course", 9.99m, 100, false, 2700m, 0.98m, 44.99m, "Overview of front-end technologies, setting up development environment, and understanding the role of a front-end developer.", "Learn the latest features of HTML5 and understand how to use semantic elements to structure web pages.", "Explore advanced CSS techniques for layout, styling, and animation, including flexbox, grid layout, and CSS preprocessors.", "Get a deep understanding of JavaScript fundamentals such as variables, data types, functions, and control flow.", "Learn how to manipulate the Document Object Model (DOM) and handle events to create dynamic and interactive web pages.", "Understand the principles of responsive web design and learn how to create layouts that adapt to different screen sizes and devices.", "Introduction to Front-End Development", "HTML5 and Semantic Markup", "Mastering CSS", "JavaScript Fundamentals", "DOM Manipulation and Event Handling", "Responsive Web Design", "The Complete Front-End Web Development Course", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "ac1e3705-9274-466e-a73d-ddeb189694b0", "Marvin McKinney", "Marvin McKinney is a seasoned iOS developer with a passion for teaching and sharing his knowledge with others. With extensive experience in Swift and iOS app development, he has created numerous successful apps that are widely used by millions of users worldwide. Marvin is known for his clear and concise teaching style, making complex concepts easy to understand for students of all levels. He is dedicated to helping aspiring developers build their own iOS apps and achieve their goals in the app development industry.", null, "Become a proficient iOS app developer with this comprehensive course on Swift programming and iOS app development. Whether you're a beginner or an experienced developer looking to enhance your skills, this course will guide you through the entire process of building iOS apps from scratch. From basic Swift syntax to advanced iOS frameworks, you'll learn everything you need to know to create your own apps and publish them on the App Store.", "Master the fundamentals of Swift programming language, including variables, data types, and control flow.", "Learn how to build user interfaces for iOS apps using Interface Builder and UIKit framework.", "Understand iOS app lifecycle and navigation patterns, including view controllers and segues.", "Explore advanced iOS features such as networking, data persistence, and push notifications.", "Get insights into app design principles and best practices for creating user-friendly and visually appealing apps.", "ios_swift_dev.svg", "Over 100 video lectures covering essential iOS development topics", "Hands-on projects to reinforce learning and build real-world apps", "Code exercises and quizzes to test your understanding", "Access to downloadable resources and starter projects", "Certificate of completion upon finishing the course", 0m, 160, false, 3100m, 0.92m, 15.99m, "Overview of iOS development ecosystem, setting up Xcode environment, and understanding basic iOS concepts.", "Learn the basics of Swift programming language, including variables, constants, and control flow.", "Explore Interface Builder and UIKit framework to design and layout user interfaces for iOS apps.", "Understand how to work with data in iOS apps, including networking, data persistence, and Core Data framework.", "Learn advanced iOS features such as push notifications, background tasks, and integrating with external services.", "Explore testing strategies for iOS apps and learn how to deploy your apps to the App Store.", "Introduction to iOS App Development", "Getting Started with Swift", "Building User Interfaces", "Working with Data", "Advanced iOS Features", "Testing and Deployment", "iOS 8: Swift - The Complete iOS App Development Course", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "c943a5af-2a94-40b4-8f6b-644328d843ee", "Jenny Wilson", "Jenny Wilson is a proficient web developer specializing in front-end technologies. With years of experience in HTML, CSS, and JavaScript, she has crafted numerous interactive and visually appealing web applications. Jenny has a knack for simplifying complex concepts and enjoys sharing her knowledge with aspiring developers. In her spare time, she contributes to open-source projects and enjoys photography.", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et urna et dui lobortis vestibulum. Nam nec orci at ex mattis bibendum in a velit. Duis id ante quis nisl blandit gravida ac nec lorem. Proin vitae lacus vitae lorem tincidunt viverra. Integer commodo elit in enim interdum tempor. Sed vitae ligula vitae orci ullamcorper suscipit in sit amet nunc. In hac habitasse platea dictumst.", "Master the fundamentals of HTML including tags, attributes, and semantic markup.", "Gain proficiency in styling web pages using CSS and understand advanced concepts like flexbox and grid layout.", "Learn JavaScript from scratch, including variables, functions, control structures, and DOM manipulation.", "Understand how to create responsive and interactive web applications.", "Get insights into best practices and industry-standard workflows for web development.", "html_css_js.svg", "100+ hours of on-demand video lectures", "20 hands-on projects to reinforce learning", "Access to downloadable code resources and exercises", "Quizzes and assessments to track progress", "Certificate of completion upon finishing the course", 0m, 160, false, 3100m, 0.92m, 15.99m, "Overview of web development, setting up development environment, and understanding basic web technologies.", "Learn the building blocks of web pages, including HTML tags, elements, attributes, and document structure.", "Explore the world of CSS, including selectors, properties, and advanced layout techniques.", "Master the fundamentals of JavaScript programming, including variables, data types, functions, and control flow.", "Understand how to interact with the Document Object Model (DOM) to dynamically update web pages.", "Learn techniques for creating responsive web designs that adapt to different screen sizes and devices.", "Introduction to Web Development", "HTML Fundamentals", "Styling with CSS", "JavaScript Essentials", "DOM Manipulation", "Building Responsive Websites", "HTML, CSS, JavaScript Web Developer", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "e36436e5-28aa-433c-8891-3079fab5a985", "Ralph Edwards", "Ralph Edwards is a skilled 3D artist and game developer with years of experience in the industry. He specializes in character modeling and animation using Blender, a popular open-source 3D modeling software. Ralph is passionate about teaching and has helped many aspiring game developers bring their ideas to life through his tutorials and courses. With a focus on practical techniques and industry best practices, Ralph's courses are designed to equip students with the skills they need to succeed in the world of game development.", null, "Master the art of character creation for video game design using Blender. In this comprehensive course, you'll learn how to create and animate 3D characters from scratch using Blender's powerful tools and features. Whether you're a beginner or an experienced artist, this course will take you step-by-step through the process of modeling, texturing, rigging, and animating characters for use in video games. With hands-on projects and real-world examples, you'll gain the skills and confidence to bring your own game characters to life.", "Learn the fundamentals of 3D modeling and sculpting in Blender.", "Understand the process of character design and development for video games.", "Master the techniques of character rigging and animation using Blender's rigging tools.", "Explore advanced topics such as facial animation, cloth simulation, and character optimization for game engines.", "Build a portfolio of 3D characters and animations to showcase your skills to potential employers or clients.", "blender_character_creator.svg", "Over 150 video lectures covering essential Blender techniques and workflows", "Hands-on projects and exercises to reinforce learning and build practical skills", "Quizzes and assessments to test your understanding of key concepts", "Access to downloadable resources and project files", "Certificate of completion upon finishing the course", 0m, 160, false, 3100m, 0.92m, 18.99m, "Overview of Blender's interface and tools, setting up the workspace, and understanding basic 3D concepts.", "Learn how to create 3D characters from scratch using Blender's modeling and sculpting tools.", "Understand the process of character rigging and learn how to create custom rigs for animating characters.", "Explore the principles of character animation and learn how to animate characters using Blender's animation tools.", "Discover advanced techniques such as facial animation, cloth simulation, and character optimization for real-time rendering.", "Build a portfolio of 3D characters and animations to showcase your skills to potential employers or clients.", "Introduction to Blender", "Character Modeling", "Character Rigging", "Character Animation", "Advanced Techniques", "Portfolio Development", "Blender Character Creator v2.0 for Video Games Design", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." },
                    { "e67c7199-081b-4496-b6a7-eb906e7c0091", "Robert Fox", "Robert Fox is a seasoned web developer and creative designer with over a decade of experience in the industry. He specializes in pushing the boundaries of CSS to create stunning visual effects and artworks directly in the browser. Robert is passionate about sharing his knowledge and inspiring others to explore the artistic possibilities of CSS. In addition to his technical expertise, he has a keen eye for design and aesthetics, which he incorporates into his courses to help students create visually appealing and interactive web content.", null, "Unleash your creativity with CSS in this unique course that combines coding with art. Whether you're a web developer looking to expand your skills or an artist interested in digital mediums, this course will teach you how to create beautiful and interactive drawings using CSS. From basic shapes to complex animations, you'll learn how to use CSS properties and techniques to bring your ideas to life in the browser. With step-by-step tutorials and hands-on projects, you'll gain the confidence and skills to create your own CSS masterpieces.", "Learn how to create basic shapes and patterns using CSS properties such as border-radius, gradients, and transformations.", "Explore advanced CSS techniques for creating complex illustrations, animations, and interactive effects.", "Understand the principles of CSS artistry, including composition, color theory, and visual hierarchy.", "Discover creative coding tools and resources for experimenting with CSS and pushing the boundaries of web design.", "Gain inspiration and ideas for incorporating CSS art into your web projects and personal portfolio.", "creative_css_design.svg", "Over 200 video lectures covering essential CSS drawing topics", "Hands-on projects and challenges to reinforce learning and build practical skills", "Quizzes and assessments to test your understanding of key concepts", "Access to downloadable resources and starter code", "Certificate of completion upon finishing the course", 0m, 220, false, 4200m, 0.94m, 1050m, "Overview of CSS drawing techniques, setting up development environment, and understanding basic CSS concepts.", "Learn how to create basic geometric shapes and patterns using CSS properties such as border-radius, gradients, and transformations.", "Explore advanced CSS techniques for creating complex illustrations, animations, and interactive effects.", "Understand the principles of CSS artistry, including composition, color theory, and visual hierarchy, and how they apply to web design.", "Discover creative coding tools and resources for experimenting with CSS and pushing the boundaries of web design.", "Apply your skills to hands-on projects and challenges, and create your own CSS artworks and interactive designs.", "Introduction to CSS Drawing", "Creating Basic Shapes", "Advanced CSS Techniques", "Principles of CSS Artistry", "Creative Coding Tools", "Hands-on Projects", "Creative CSS Drawing Course: Make Art With CSS", "Master full-stack web development. Learn HTML, CSS, JavaScript, Node.js, and build real projects." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "16fd8af4-3c38-402c-9a5f-ae70d09fae47");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "421a59de-432c-4149-90d8-c55e30f6ccf0");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "49be8ed9-be17-43b1-bddf-ad61ce15f3f3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "7f4c432f-868e-4b9b-b5ac-b38846a673d8");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "951e6e5f-87e7-4c4a-bac0-e0c60dc9f7a7");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "ac1e3705-9274-466e-a73d-ddeb189694b0");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c943a5af-2a94-40b4-8f6b-644328d843ee");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "e36436e5-28aa-433c-8891-3079fab5a985");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "e67c7199-081b-4496-b6a7-eb906e7c0091");

            migrationBuilder.DropColumn(
                name: "AuthorDescription",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AuthorImagePath",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseDescription",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseGoal1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseGoal2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseGoal3",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseGoal4",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseGoal5",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseImagePath",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseIncludes1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseIncludes2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseIncludes3",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseIncludes4",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseIncludes5",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription3",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription4",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription5",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailDescription6",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle2",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle3",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle4",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle5",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ProgramDetailTitle6",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "TitleDescription",
                table: "Courses",
                newName: "ImageName");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "DiscountPrice", "Hours", "ImageName", "IsBestseller", "LikesInNumbers", "LikesInProcent", "OriginalPrice", "Title" },
                values: new object[,]
                {
                    { "19b557d0-bdab-456f-9595-2565a82fb7af", "Jenny Wilson", 0m, 160, "html_css_js.svg", false, 3100m, 0.92m, 15.99m, "HTML, CSS, JavaScript" },
                    { "4f7a0a9e-3d31-4dfc-b3f8-77f736187896", "Ralph Edwards", 0m, 160, "blender_character_creator.svg", false, 3100m, 0.92m, 18.99m, "Blender Character Creator: Rigging Humanoid 3D Characters" },
                    { "5fe860ae-42e1-48b5-813f-90263f8fe9d4", "Albert Flores", 12.99m, 100, "ui_ux_design.svg", false, 2700m, 0.98m, 44.99m, "The Ultimate 6-Day Intensive For UX/UI Design" },
                    { "6d58c745-089d-4b25-ad1e-741e2979f275", "Esther Howard", 0m, 160, "data_science.svg", true, 3100m, 0.92m, 11.20m, "Data Science" },
                    { "759375a6-fdd9-4f01-ad9a-9348c783fb98", "Robert Fox", 0m, 220, "fullstack_web_dev.svg", true, 4200m, 0.94m, 12.50m, "Fullstack Web Development" },
                    { "8af1b321-8eda-4d4d-acf5-af1e79a4086f", "Albert Flores", 9.99m, 100, "front_end_dev.svg", false, 2700m, 0.98m, 44.99m, "The Complete Front-End Web Development Course" },
                    { "cc7144c2-f3e4-44bf-89be-4f47b63fa35e", "Robert Fox", 0m, 220, "creative_css_design.svg", false, 4200m, 0.94m, 1050m, "Creative CSS Design" },
                    { "d3cf5240-ff63-43c8-b118-f67ecde6ff22", "Jenny Wilson", 0m, 160, "jmeter_performance_testing.svg", false, 3100m, 0.92m, 14.50m, "Learn JMETER from Scratch on Live Apps - Performance Testing" },
                    { "ed744a1e-82ae-463d-9bde-7149360362f3", "Marvin McKinney", 0m, 160, "ios_swift_dev.svg", false, 3100m, 0.92m, 15.99m, "iOS & Swift - The Complete iOS App Development Bootcamp" }
                });
        }
    }
}
