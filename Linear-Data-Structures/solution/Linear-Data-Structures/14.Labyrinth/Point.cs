namespace _14.Labyrinth
{
    public struct Point
    {
        public Point(int row, int col) : this()
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
