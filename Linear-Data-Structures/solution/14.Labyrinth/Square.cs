namespace _14.Labyrinth
{
    public class Square
    {
        public Square(Point point, SquareContent content, char value)
        {
            this.Point = point;
            this.SquareContent = content;
            this.Value = value;
            this.Distance = 0;
            this.DistanceUpToHere = 0;
            this.Visited = false;
        }

        public int Distance { get; set; }

        public Point Point { get; set; }

        public SquareContent SquareContent { get; set; }

        public char Value { get; set; }

        public bool Visited { get; set; }

        public int DistanceUpToHere { get; set; }
    }
}
