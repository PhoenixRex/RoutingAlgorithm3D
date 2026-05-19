namespace RoutingAlgorithm3D.Models.Box
{
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
    }

    public class Boxes
    {
        public Box[] boxes { get; set; } = Array.Empty<Box>();

        public void AddBox(Box box)
        {
            boxes = boxes.Append(box).ToArray();
        }
    }
}