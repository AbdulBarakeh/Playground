namespace RemoteControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoteControl.NumberOfStrokes("agh"));
        }
    }

    public static class RemoteControl
    {
        public static char[,] RemoteKeypad { get; set; } = {
             { 'a', 'b', 'c', 'd', 'e', '1', '2', '3' }
            ,{ 'f', 'g', 'h', 'i', 'j', '4', '5', '6' }
            ,{ 'k', 'l', 'm', 'n', 'o', '7', '8', '9' }
            ,{ 'p', 'q', 'r', 's', 't', '.', '@', '0' }
            ,{ 'u', 'v', 'w', 'x', 'y', 'z', '_', '/' }
        };
        public static int NumberOfStrokes(string input)
        {
            List<Tuple<int, int>> coordinates = new() { new Tuple<int, int>(0, 0) };

            int strokes = 0;
            var splitInput = input.ToList();
            for (int i = 0; i < RemoteKeypad.GetLength(0); i++)
            {
                for (int j = 0; j < RemoteKeypad.GetLength(1); j++)
                {

                    Console.WriteLine(RemoteKeypad[i, j]);
                    if (splitInput.Contains(RemoteKeypad[i, j]))
                    {
                        coordinates.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            for (int i = 0; i < coordinates.Count; i++)
            {
                if (i+1 < coordinates.Count)
                {
                    var x = Math.Abs(coordinates[i].Item1 - coordinates[i + 1].Item1);
                    var y = Math.Abs(coordinates[i].Item2 - coordinates[i + 1].Item2);
                    strokes += x + y;
                }
            }
            strokes += coordinates.Count()-1;

            return strokes;
        }
    }
}