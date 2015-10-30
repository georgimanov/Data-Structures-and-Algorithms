namespace _14.Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Labyrinth
    {
        public Labyrinth(char[,] maze)
        {
            this.TotalRows = maze.GetLength(0);
            this.TotalCols = maze.GetLength(1);
            this.Squares = Initialize(maze);
        }

        public Square[,] Squares { get; set; }

        private Square StartingSquare { get; set; }

        private int TotalCols { get; set; }

        private int TotalRows { get; set; }

        private Square[,] Initialize(char[,] maze)
        {
            var points = new Square[this.TotalRows, this.TotalCols];

            for (var row = 0; row < this.TotalRows; row++)
            {
                for (var col = 0; col < this.TotalCols; col++)
                {
                    var point = new Point(row, col);
                    var value = maze[row, col];
                    points[row, col] = new Square(point, FromChar(value), value);

                    if (FromChar(value) == SquareContent.StartingPoint)
                    {
                        this.StartingSquare = new Square(point, SquareContent.StartingPoint, value);
                    }
                }
            }

            return points;
        }

        private SquareContent FromChar(char charIn)
        {
            // Use a switch statement to parse characters.
            switch (charIn)
            {
                case 'x':
                    return SquareContent.NotAvailable;
                case '0':
                    return SquareContent.Available;
                case '*':
                    return SquareContent.StartingPoint;
                case 'u':
                    return SquareContent.Unreachable;
                default:
                    return SquareContent.NotCategorized;
                    break;
            }
        }

        public void PrintResult()
        {
            for (var row = 0; row < this.TotalRows; row++)
            {
                for (var col = 0; col < this.TotalCols; col++)
                {
                    var result = GetPrintSymbol(this.Squares[row, col]);
                    Console.Write("{0}", result);
                }

                Console.WriteLine();
            }
        }

        private string GetPrintSymbol(Square square)
        {
            if (square.SquareContent == SquareContent.Available)
            {
                if (square.Distance == 0)
                {
                    return "u";
                }

                return square.Distance.ToString();
            }

            return square.Value.ToString();
        }

        private bool ValidCoordinates(Point square)
        {
            if (square.Row < 0)
            {
                return false;
            }
            if (square.Col < 0)
            {
                return false;
            }
            if (square.Row >= this.TotalRows)
            {
                return false;
            }
            if (square.Col >= this.TotalCols)
            {
                return false;
            }

            return true;
        }

        public void CalculateDistance()
        {
            this.StartingSquare.DistanceUpToHere = -1;
            var squaresQueue = new Queue<Square>();
            squaresQueue.Enqueue(this.StartingSquare);
            while (squaresQueue.Count > 0)
            {
                var currentSquare = squaresQueue.Dequeue();
                currentSquare.Visited = true;
                currentSquare.Distance = currentSquare.DistanceUpToHere + 1;

                var validSquares = GetAvailableSquares(currentSquare.Point.Row, currentSquare.Point.Col);
                foreach (var validSquare in validSquares)
                {
                    validSquare.DistanceUpToHere = currentSquare.Distance;
                    squaresQueue.Enqueue(validSquare);
                }
            }
        }

        private List<Square> GetAvailableSquares(int row, int col)
        {
            var points = new[]
            {
                new Point(row, col - 1),
                new Point(row - 1, col),
                new Point(row, col + 1),
                new Point(row + 1, col)
            };

            var list = new List<Square>();

            foreach (var point in points)
            {
                if (ValidCoordinates(point))
                {
                    list.Add(this.Squares[point.Row, point.Col]);
                }
            }

            return list.Where(x => x.SquareContent == SquareContent.Available && !x.Visited).ToList();
        }
    }
}