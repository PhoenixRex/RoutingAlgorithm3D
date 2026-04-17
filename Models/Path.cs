namespace RoutingAlgorithm3D.Models
{
    public struct PathRequest
    {
        public short X;
        public short Y;
        public short Z;

        public PathRequest(short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"Block({X},{Y},{Z})";
    }
}
