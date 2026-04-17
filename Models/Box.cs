namespace RoutingAlgorithm3D.Models.Box
{

    public enum Rotation : short
    {
        Deg0   = 0,
        Deg90  = 90,
        Deg180 = 180,
        Deg270 = 270
    }

    public struct Box
    {
        public bool top;
        public bool bottom;
        public bool forward;
        public bool backward;
        public bool left;
        public bool right;
        public bool point_A;
        public bool point_B;

        public short X;
        public short Y;
        public short Z;
        public Rotation rotation;

    }
}