using Moq;
using PlutoRover.Models;
using PlutoRover.Services.DirectionDetector;
using PlutoRover.Services.TransportCommandHandler;
using Xunit;

namespace PlutoRover.Test.Services
{
    public class TransportCommandHandlerTest
    {
        private Mock<IDirectionDetector> _directionDetector;
        private TransportCommandHandler _transportCommandHandler;
        public TransportCommandHandlerTest()
        {
            _directionDetector = new Mock<IDirectionDetector>();
            _transportCommandHandler = new TransportCommandHandler(_directionDetector.Object);
        }

        #region ForwardCommand
        [Fact]
        public void GIVEN_forwardCommandOn_00N_WHEN_execute_THEN_incrementYby1()
        {
            //Arrange
            var current = new RoverLocation(0, 0, "N");
            var command = "F";
            var expected = new RoverLocation(0, 1, "N");

            _directionDetector
                .Setup(x => x.Get(current.Direction, command))
                .Returns(Common.Direction.Up);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_forwardCommandOn_01S_WHEN_execute_THEN_decreaseYby1()
        {
           //Arrange
            var current = new RoverLocation(0, 1, "S");
            var command = "F";
            var expected = new RoverLocation(0, 0, "S");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Down);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_forwardCommandOn_00E_WHEN_execute_THEN_incrementXby1()
        {
            //Arrange
            var current = new RoverLocation(0, 0, "E");
            var command = "F";
            var expected = new RoverLocation(1, 0, "E");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Right);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_forwardCommandOn_10W_WHEN_execute_THEN_decreaseXby1()
        {
            //Arrange
            var current = new RoverLocation(1, 0, "W");
            var command = "F";
            var expected = new RoverLocation(0, 0, "W");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Left);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        #endregion

        #region BackwardCommand
        [Fact]
        public void GIVEN_backwardCommandOn_01N_WHEN_execute_THEN_decreaseYby1()
        {
            //Arrange
            var current = new RoverLocation(0, 1, "N");
            var command = "B";
            var expected = new RoverLocation(0, 0, "N");

            _directionDetector
                .Setup(x => x.Get(current.Direction, command))
                .Returns(Common.Direction.Down);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_backwardCommandOn_00S_WHEN_execute_THEN_increaseYby1()
        {
            //Arrange
            var current = new RoverLocation(0, 0, "S");
            var command = "B";
            var expected = new RoverLocation(0, 1, "S");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Up);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_backwardCommandOn_10E_WHEN_execute_THEN_decreaseXby1()
        {
            //Arrange
            var current = new RoverLocation(1, 0, "E");
            var command = "B";
            var expected = new RoverLocation(0, 0, "E");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Left);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        [Fact]
        public void GIVEN_backwardCommandOn_000W_WHEN_execute_THEN_increaseXby1()
        {
            //Arrange
            var current = new RoverLocation(0, 0, "W");
            var command = "B";
            var expected = new RoverLocation(1, 0, "W");

            _directionDetector
               .Setup(x => x.Get(current.Direction, command))
               .Returns(Common.Direction.Right);

            //Act
            _transportCommandHandler.Execute(current, command);

            //Assert
            Assert.Equal(expected.Direction, current.Direction);
            Assert.Equal(expected.PositionX, current.PositionX);
            Assert.Equal(expected.PositionY, current.PositionY);
        }

        #endregion
    }
}
