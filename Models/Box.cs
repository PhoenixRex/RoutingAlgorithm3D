namespace RoutingAlgorithm3D.Models.Box
{
    public enum Rotation : short
    {
        Deg0   = 0,
        Deg90  = 90,
        Deg180 = 180,
        Deg270 = 270
    }

    public class Box
    {
        public bool top { get; set; }
        public bool bottom { get; set; }
        public bool forward { get; set; }
        public bool backward { get; set; }
        public bool left { get; set; }
        public bool right { get; set; }
        public bool point_A { get; set; }
        public bool point_B { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Z { get; set; }
        public Rotation rotation { get; set; }
    }

    public class Boxes
    {
        public Box[] boxes { get; set; }
    }
}