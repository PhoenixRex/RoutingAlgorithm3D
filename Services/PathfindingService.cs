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
            
            return Neighbors_A.ToString();
        }

        private Boxes FindNeighbors(Box box)
        {
            Boxes result = new();
            //isValid()
            //X
            for (int u = 0; u < 2; u++)
            {
                int modifier = (u == 0) ? 1 : -1;  // 1. Mal: +1, 2. Mal: -1
                
                Box? test = _request.boxes.FirstOrDefault(x => x.X == box.X + u);

                if (test != null)
                {
                    result.AddBox(box);
                }
            }

            //Y
            for (int u = 0; u < 2; u++)
            {
                int modifier = (u == 0) ? 1 : -1;  // 1. Mal: +1, 2. Mal: -1
                
                Box? test = _request.boxes.FirstOrDefault(x => x.Y == box.X + u);

                if (test != null)
                {
                    result.AddBox(box);
                }
            }

            //Z
            for (int u = 0; u < 2; u++)
            {
                int modifier = (u == 0) ? 1 : -1;  // 1. Mal: +1, 2. Mal: -1

                Box? test = _request.boxes.FirstOrDefault(x => x.Z == box.X + u);

                if (test != null)
                {
                    result.AddBox(box);
                }
            }

            return result;   
        }
    }
}