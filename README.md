# Eye-Exam
Because we're testing your ability to C# :wink:.

# Problem Description 
We've provided the EyeExamAPI project.  This project is a lightweight data provider you should treat as another microservice in our stack. For the sake of speed and ease, just focus on consuming this api hosted locally.

This API has two routes:
1. Schedule GET
     Returns a collection of raw Schedule of Notice of Lease Data.  This is data provided in a lossy format.
1. Results GET
     The Expected Output of *your* API we expect to see. 

Your job is to write a new API to consume this API that can take the raw Schedule data and parse it into the same format as the data provided on the /results/ route. Your solution should implement some sort of storage or caching so that repeat calls don't incur repeat processing. 

Use whatever tech you see fit to consume this api (preferably .NET!).  We will test your submitted API against our internal `EYEEXAMAPI` so no modification to the provided code is necessary.

# What we're looking for

## Core Competencies
* Show off how you like to code _well_ 
     * Consistent standards
     * SOLID Principles
     * SoC
* Simple to run or well documented startup.
* Accurate Result Set.
* Test Coverage.

## Additional points
Extra points are available for
* Ease of code maintenance / readability
* External Visiblity and live diagnostics
* Architecture documentation 
* Consideration of hosting
* Write up of next steps.

## Time
We expect this to take no more than two hours to cover the core competencies above, if you decide to spend more time to show off or hit some bonus points you're more welcome to!

# Submission
Submit your result via your medium of choice (zip archive / git repo) to the recruiter or contact at Orbital Witness, and we'll be in touch with the results! 
