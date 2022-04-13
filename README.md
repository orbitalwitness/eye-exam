# Eye-Exam
Because we're testing your ability to C# :wink:.

# Problem Description 
We've provided the `EYEEXAMAPI` project.  This project is a lightweight data provider you should treat as another microservice in our stack. For the sake of speed and ease, just focus on consuming this api hosted locally.

This API has two routes:
1. Schedule GET
     Returns a collection of raw Schedule of Notice of Lease Data.  This is data provided in a lossy format.
1. Results GET
     The Expected Output of *your* API we expect to see. 

Your job is to write a new C# .NET API to consume this API that can take the raw Schedule data and parse it into the same format as the data provided on the /results/ route (don't worry about the order of the results, only the accuracy of the parsing). Your solution should implement some sort of storage or caching so that repeat calls don't incur repeat processing. 

We will test your submitted API against our internal `EYEEXAMAPI` so no modification to the provided code is necessary.

# Run Instructions
The API was built with .NET 6 Minimal API.  
To run with VSStudio,
1. Open the EyeExamApi.csproj
1. Hit Debug. 
1. You may want to wrap this project and your project in a .sln file.

To run with VSCode 
1. Open your terminal.
1. Navigate to `/eye-exam/EYEEXAMAPI` 
1. Run `dotnet run`
1. You may need to run `dotnet dev-certs https --trust` to accept the dotnet dev ssl cert. 

# What we're looking for

## Core Competencies
* Show off how you like to code _well_ 
     * Consistent standards
     * SOLID Principles
     * SoC
     * Code readability
* Simple to run or well documented startup.
* Accurate Result Set.
* Test Coverage.

## Additional points
Extra points are available for
* Algorithm extensibility for future cases
* External visiblity and live diagnostics (think: logging, telemetry etc)
* Consideration of hosting + deployment (Docker, Serverless etc) 
* Architecture documentation
* Write up of next steps to get the solution to production.

## Time
We expect this to take no more than two hours to cover the core competencies above, if you decide to spend more time to show off or hit some bonus points you're more welcome to!

If you find yourself running out of time prior to completing the entire problem, we will also review partial submissions paired with a write up of what your next steps would have been.

# Submission
Submit your result via your medium of choice (zip archive / git repo) to the recruiter or contact at Orbital Witness, and we'll be in touch with the results! 
