using PlutoRover.Common;
using PlutoRover.Models;
using PlutoRover.Services.CommandHandlers;
using Xunit;

namespace PlutoRover.Test.CommandHandlers
{
    public class RightCommandHandlerTest
    {
        private RightCommandHandler _rightCommandHandler;
        public RightCommandHandlerTest()
        {
            _rightCommandHandler = new RightCommandHandler();
        }

        [Fact]
        public void GIVEN_00N_WHEN_execute_THEN_headtoE()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.North);
            var expected = new RoverLocation(0, 0, CardinalDirection.East);

            //Act
            _rightCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00E_WHEN_execute_THEN_headtoS()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.East);
            var expected = new RoverLocation(0, 0, CardinalDirection.South);

            //Act
            _rightCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00S_WHEN_execute_THEN_headtoW()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.South);
            var expected = new RoverLocation(0, 0, CardinalDirection.West);

            //Act
            _rightCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public void GIVEN_00W_WHEN_execute_THEN_headtoN()
        {
            //Arrange
            var currentLocation = new RoverLocation(0, 0, CardinalDirection.West);
            var expected = new RoverLocation(0, 0, CardinalDirection.North);

            //Act
            _rightCommandHandler.execute(currentLocation);

            //Assert
            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }
    }
}
