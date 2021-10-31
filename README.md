# PlumGuide
 
# Description
 This application is Pluto Rover Exercise which get current position of rover and heading (N,S,W,E) and sequence of commands (F,B,R,L) then move or rotate rover base on the commands and return the final position and heading.
 This is an .NET Core 5 API using xUnit.
# How to setup 
  Please install .Net 5.0 from this link https://dotnet.microsoft.com/download/dotnet/5.0
  Then clone this repository `git clone https://github.com/Elham-Rahimi/PlumGuide `.
  After that go to the Project by `cd PlutoRover`
## Run application
   To run the application from the project repository go to the `cd PlutoRover`
   Enter command `dotnet run` now the project should be visible at localhost:5000. 
   You can test the project by `swagger` in `http://localhost:5000/index.html`
## Run test
   To run the test for application from the project repository go to the 
	`cd PlutoRover.Test`
   Enter command `dotnet test`
# Pre-assumptions
- User only enters the direction heading in the correct format, based on (N,S,W,E)
- User can execute the endpoint via Swagger.
- GridSize ans obstacles position must be some Data which Rover send from Pluto. here I provid them with configuration

# Improvments if I have more time
- [] Add validation and exception for input direction 
- [] add test for services 
- [] Add test for the middleware.
- [] Add more details for middleware exceptions messages. 

 
