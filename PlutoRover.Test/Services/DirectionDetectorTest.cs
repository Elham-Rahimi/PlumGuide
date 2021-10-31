using PlutoRover.Common;
using PlutoRover.Services.DirectionDetector;
using Xunit;

namespace PlutoRover.Test.Services
{
    public class DirectionDetectorTest
    {
        private DirectionDetector _directionHandler;

        public DirectionDetectorTest()
        {
            _directionHandler = new DirectionDetector();
        }

        [Fact]
        public void GIVEN_forwardCommandanddirectionN_WHEN_called_THEN_moveUp()
        {
            //Arrange
            var direction = "N";
            var command = "F";
            var expected = Direction.Up;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_forwardCommandanddirectionS_WHEN_called_THEN_moveDown()
        {
            //Arrange
            var direction = "S";
            var command = "F";
            var expected = Direction.Down;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_forwardCommandanddirectionE_WHEN_called_THEN_moveRight()
        {
            //Arrange
            var direction = "E";
            var command = "F";
            var expected = Direction.Right;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_forwardCommandanddirectionW_WHEN_called_THEN_moveLeft()
        {
            //Arrange
            var direction = "W";
            var command = "F";
            var expected = Direction.Left;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void GIVEN_backwardCommandanddirectionN_WHEN_called_THEN_moveDown()
        {
            //Arrange
            var direction = "N";
            var command = "B";
            var expected = Direction.Down;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_backwardCommandanddirectionS_WHEN_called_THEN_moveup()
        {
            //Arrange
            var direction = "S";
            var command = "B";
            var expected = Direction.Up;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_backwardCommandanddirectionE_WHEN_called_THEN_moveLeft()
        {
            //Arrange
            var direction = "E";
            var command = "B";
            var expected = Direction.Left;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GIVEN_backwardCommandanddirectionW_WHEN_called_THEN_moveRight()
        {
            //Arrange
            var direction = "W";
            var command = "B";
            var expected = Direction.Right;

            //Act
            var result = _directionHandler.Get(direction, command);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
