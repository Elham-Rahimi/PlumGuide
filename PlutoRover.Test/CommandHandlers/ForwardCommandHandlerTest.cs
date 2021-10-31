using Microsoft.Extensions.Configuration;
using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.CommandHandlers;
using PlutoRover.Services.EdgeAdapterService;
using PlutoRover.Services.RoverTranslateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PlutoRover.Test.CommandHandlers
{
    public class ForwardCommandHandlerTest
    {
        private ForwardCommandHandler _forwardCommandHandler;
        private readonly IEdgeAdapterService _edgeAdapterService;
        private readonly IRoverTranslateService _roverTranslateService;
        private IConfiguration _configuration;
        public ForwardCommandHandlerTest()
        {
            _configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            _edgeAdapterService = new EdgeAdapterService(_configuration);
            _roverTranslateService = new RoverTranslateService(_edgeAdapterService);
            _forwardCommandHandler = new ForwardCommandHandler(_roverTranslateService);
        }

        [Fact]
        public void GIVEN_00N_WHEN_execute_THEN_incrementYby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.North);
            var expected = new RoverLocation(0, 1, CardinalDirection.North);

            //Act
            _forwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_01S_WHEN_execute_THEN_decreaseYby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 1, CardinalDirection.South);
            var expected = new RoverLocation(0, 0, CardinalDirection.South);

            //Act
            _forwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00E_WHEN_execute_THEN_incrementXby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.East);
            var expected = new RoverLocation(1, 0, CardinalDirection.East);

            //Act
            _forwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_10W_WHEN_execute_THEN_decreaseXby1()
        {
            //Arrange
            var currentLocation = new RoverLocation(1, 0, CardinalDirection.West);
            var expected = new RoverLocation(0, 0, CardinalDirection.West);

            //Act
            _forwardCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }
    }
}
