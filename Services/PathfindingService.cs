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

            Box? a = _request.boxes.FirstOrDefault(x => x.point_A == true);
            Box? b = _request.boxes.FirstOrDefault(x => x.point_B == true);


            if (a == null || b == null )
                return "Fehler: Start/Ende nicht gefunden";
            if (a.point_A == true && a.point_B == true || b.point_A == true && b.point_B == true)
                return "Fehler: Positzion von Start/Ende sind Identisch";

            Boxes Neighbors_A = FindNeighbors(a);
            
            return System.Text.Json.JsonSerializer.Serialize(Neighbors_A);
        }

        private Boxes FindNeighbors(Box box)
        {
            Boxes result = new();

            Box? right = _request.boxes.FirstOrDefault(b =>
                b.X == box.X + 1 &&
                b.Y == box.Y &&
                b.Z == box.Z);

            Box? left = _request.boxes.FirstOrDefault(b =>
                b.X == box.X - 1 &&
                b.Y == box.Y &&
                b.Z == box.Z);

            Box? forward = _request.boxes.FirstOrDefault(b =>
                b.X == box.X &&
                b.Y == box.Y + 1 &&
                b.Z == box.Z);

            Box? backward = _request.boxes.FirstOrDefault(b =>
                b.X == box.X &&
                b.Y == box.Y - 1 &&
                b.Z == box.Z);

            Box? top = _request.boxes.FirstOrDefault(b =>
                b.X == box.X &&
                b.Y == box.Y &&
                b.Z == box.Z + 1);

            Box? bottom = _request.boxes.FirstOrDefault(b =>
                b.X == box.X &&
                b.Y == box.Y &&
                b.Z == box.Z - 1);

            if (right != null) result.AddBox(right);
            if (left != null) result.AddBox(left);
            if (forward != null) result.AddBox(forward);
            if (backward != null) result.AddBox(backward);
            if (top != null) result.AddBox(top);
            if (bottom != null) result.AddBox(bottom);

            return result;
        }
    }
}