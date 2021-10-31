using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using PlutoRover.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace PlutoRover.Test
{
    public class PlutoRoverTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public PlutoRoverTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        #region F movements test
        [Fact]
        public async Task GIVEN_forwardCommandOn_00N_WHEN_apiCalled_THEN_incrementYby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 0;
            var roverDirection = "N";
            var commands = "F";
            var expected = new RoverLocation(0, 1, "N");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_forwardCommandOn_01S_WHEN_apiCalled_THEN_decreaseYby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 1;
            var roverDirection = "S";
            var commands = "F";
            var expected = new RoverLocation(0, 0, "S");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_forwardCommandOn_00E_WHEN_apiCalled_THEN_incrementXby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 0;
            var roverDirection = "E";
            var commands = "F";
            var expected = new RoverLocation(1, 0, "E");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_forwardCommandOn_10W_WHEN_apiCalled_THEN_decreaseXby1()
        {
            //Arrange
            int roverPositionX = 1;
            int roverPositionY = 0;
            var roverDirection = "W";
            var commands = "F";
            var expected = new RoverLocation(0, 0, "W");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }
        #endregion

        #region B movements test
        [Fact]
        public async Task GIVEN_backwardCommandOn_01N_WHEN_apiCalled_THEN_decreaseYby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 1;
            var roverDirection = "N";
            var commands = "B";
            var expected = new RoverLocation(0, 0, "N");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_backwardCommandOn_00S_WHEN_apiCalled_THEN_increaseYby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 0;
            var roverDirection = "S";
            var commands = "B";
            var expected = new RoverLocation(0, 1, "S");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_backwardCommandOn_10E_WHEN_apiCalled_THEN_decreaseXby1()
        {
            //Arrange
            int roverPositionX = 1;
            int roverPositionY = 0;
            var roverDirection = "E";
            var commands = "B";
            var expected = new RoverLocation(0, 0, "E");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }

        [Fact]
        public async Task GIVEN_backwardCommandOn_00W_WHEN_apiCalled_THEN_increaseXby1()
        {
            //Arrange
            int roverPositionX = 0;
            int roverPositionY = 0;
            var roverDirection = "W";
            var commands = "B";
            var expected = new RoverLocation(1, 0, "W");

            var requestUrl = GenerateRequestUrl(roverPositionX, roverPositionY, roverDirection, commands);

            //Act
            var response = await _client.GetAsync(requestUrl);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var currentLocationJson = await response.Content.ReadAsStringAsync();
            var currentLocation = JsonConvert.DeserializeObject<RoverLocation>(currentLocationJson);

            Assert.Equal(expected.Direction, currentLocation.Direction);
            Assert.Equal(expected.PositionX, currentLocation.PositionX);
            Assert.Equal(expected.PositionY, currentLocation.PositionY);
        }
        #endregion


        private string GenerateRequestUrl(int roverPositionX, int roverPositionY, string roverDirection, string commands)
        {
            return $"/PlutoRover/move?x={roverPositionX}&y={roverPositionY}&direction={roverDirection}&commands={commands}";
        }
    }
}