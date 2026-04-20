using RoutingAlgorithm3D.Models.Box;

namespace RoutingAlgorithm3D.Services
{
    public class PathfindingService
    {
        private readonly Boxes _request;

        public PathfindingService(Boxes request)
        {
            _request = request;
        }

        public string Calculate()
        {
            return "Not implemented yet";
        }
    }
}