using Microsoft.Extensions.Configuration;
using Moq;
using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.CommandHandlers;
using PlutoRover.Services.EdgeAdapterService;
using PlutoRover.Services.ObstacleDetecterService;
using PlutoRover.Services.RoverTranslateService;
using Xunit;

namespace PlutoRover.Test.CommandHandlers
{
    public class BackwardCommandHandlerTest
    {
        private BackwardCommandHandler _backwardCommandHandler;
        private readonly IRoverTranslateService _roverTranslateService;
        public BackwardCommandHandlerTest() 
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            var edgeAdapterService = new EdgeAdapterService(configuration);
            var obstacleDetecterService = new ObstacleDetecterService(configuration);

            _roverTranslateService = new RoverTranslateService(edgeAdapterService, obstacleDetecterService);
            _backwardCommandHandler = new BackwardCommandHandler(_roverTranslateService);
        }

        [Fact]
        public void GIVEN_10N_WHEN_execute_THEN_decreaseYby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 1, CardinalDirection.North);
            var expected = new RoverLocation(0, 0, CardinalDirection.North);

            //Act
            _backwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00S_WHEN_execute_THEN_increaseYby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.South);
            var expected = new RoverLocation(0, 1, CardinalDirection.South);

            //Act
            _backwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_10E_WHEN_execute_THEN_decreaseXby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(1, 0, CardinalDirection.East);
            var expected = new RoverLocation(0, 0, CardinalDirection.East);

            //Act
            _backwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00W_WHEN_execute_THEN_increaseXby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.West);
            var expected = new RoverLocation(1, 0, CardinalDirection.West);

            //Act
            _backwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }
    }
}
