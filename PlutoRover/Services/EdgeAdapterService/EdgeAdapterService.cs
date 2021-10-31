using Microsoft.Extensions.Configuration;

namespace PlutoRover.Services.EdgeAdapterService
{
    public class EdgeAdapterService: IEdgeAdapterService
    {
        private IConfiguration _configuration;
        private int gridSize;

        public EdgeAdapterService(IConfiguration configuration)
        {
            _configuration = configuration;
            gridSize = int.Parse( _configuration["PlutoRover:GridSize"]);
        }

        public void AdjustPosition(Position position)
        {
            position.X = Wrap(position.X);
            position.Y = Wrap(position.Y);
     
        }

        private int Wrap(int cordinate)
        {
            if (cordinate >= gridSize)
            {
                return 0;
            }

            if (cordinate < 0)
            {
                return gridSize - 1;
            }
            return cordinate;
        }


    }
}
