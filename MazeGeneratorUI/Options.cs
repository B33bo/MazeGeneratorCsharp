using System.Drawing;

namespace MazeGeneratorUI
{
    internal class Options
    {
        public static Options? Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new Options();
                return _instance;
            }
        }

        private static Options? _instance;

        public Color lineColor = Color.Black;
        public Color pathColor = Color.White;

        public bool UseSeed = false;
        public int Seed = 0;
    }
}
