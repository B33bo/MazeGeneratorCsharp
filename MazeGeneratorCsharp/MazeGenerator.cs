using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Maze
{
    public class MazeGenerator
    {
        public const int MaxDimensions = 1073741823;

        private Random rnd;
        private int width, height;
        public (List<Point> links, bool visited)[,] grid;
        private int ticks = 0;
        private Point startPoint;

        private (bool, bool) flip;

        public bool this[Point p]
        {
            get => grid[p.x, p.y].visited;
            private set => grid[p.x, p.y].visited = value;
        }

        public bool this[int x, int y]
        {
            get => grid[x, y].visited;
            private set => grid[x, y].visited = value;
        }

        public MazeGenerator(int width, int height)
        {
            if (width < 0)
            {
                flip.Item1 = true;
                width *= -1;
            }

            if (height < 0)
            {
                flip.Item2 = true;
                height *= -1;
            }
            
            this.width = width;
            this.height = height;
            rnd = new Random();
            grid = new (List<Point>, bool)[width, height];
            startPoint = new Point(0, 0);
        }

        public MazeGenerator(int width, int height, int seed)
        {
            if (width < 0)
            {
                flip.Item1 = true;
                width *= -1;
            }

            if (height < 0)
            {
                flip.Item2 = true;
                height *= -1;
            }

            this.width = width;
            this.height = height;
            rnd = new Random(seed);
            grid = new (List<Point>, bool)[width, height];
            startPoint = new Point(0, 0);
        }

        private void AddLink(Point targetPoint, Point linkedPoint)
        {
            if (grid[targetPoint.x, targetPoint.y].links is null)
                grid[targetPoint.x, targetPoint.y].links = new List<Point>();

            if (grid[linkedPoint.x, linkedPoint.y].links is null)
                grid[linkedPoint.x, linkedPoint.y].links = new List<Point>();

            grid[targetPoint.x, targetPoint.y].links.Add(linkedPoint);
            grid[linkedPoint.x, linkedPoint.y].links.Add(targetPoint);
        }

        public void Generate()
        {
            if (width == 1 || height == 1)
                return;

            if (width == 0 || height == 0)
                return;

            Stack<Point> positionsMet = new();
            positionsMet.Push(startPoint);
            Point currentPoint = startPoint;
            ticks = 0;

            while (ticks < width * height)
            {
                Point[] uncheckedNeighbors = UncheckedNeighbors(currentPoint);
                if (uncheckedNeighbors.Length == 0)
                {
                    currentPoint = positionsMet.Pop();
                    continue;
                }

                int choice = rnd.Next(0, uncheckedNeighbors.Length);


                AddLink(currentPoint, uncheckedNeighbors[choice]);
                currentPoint = uncheckedNeighbors[choice];

                if (!grid[currentPoint.x, currentPoint.y].visited)
                    ticks++;

                grid[currentPoint.x, currentPoint.y].visited = true;
                positionsMet.Push(currentPoint);
            }
        }

        private Point[] UncheckedNeighbors(Point p)
        {
            List<Point> points = new();

            CheckPoint(p.x - 1, p.y, ref points);
            CheckPoint(p.x + 1, p.y, ref points);
            CheckPoint(p.x, p.y - 1, ref points);
            CheckPoint(p.x, p.y + 1, ref points);

            return points.ToArray();

            void CheckPoint(int x, int y, ref List<Point> p)
            {
                bool pointExists = PointExists(new Point(x, y));

                if (!pointExists)
                    return;

                bool pointIsVisited = grid[x, y].visited;//this[x, y] != Direction.None;
                if (!pointIsVisited)
                    p.Add((new Point(x, y)));
            }
        }

        private Point[] Neighbors(Point p)
        {
            List<Point> points = new();

            CheckPoint(p.x - 1, p.y, ref points);
            CheckPoint(p.x + 1, p.y, ref points);
            CheckPoint(p.x, p.y - 1, ref points);
            CheckPoint(p.x, p.y + 1, ref points);

            return points.ToArray();

            void CheckPoint(int x, int y, ref List<Point> p)
            {
                bool pointExists = PointExists(new Point(x, y));

                if (!pointExists)
                    return;

                p.Add(new Point(x, y));
            }
        }

        private bool PointExists(Point p) =>
            (p.x < width && p.x >= 0) && (p.y < height && p.y >= 0);

        private bool LinkExists(Point a, Point b)
        {
            var links = grid[a.x, a.y].links;

            if (links is null)
                return false;
            for (int i = 0; i < links.Count; i++)
            {
                if (links[i] == b)
                    return true;
            }
            return false;
        }

        public string ToString(Point currentPoint)
        {
            string border = "-";

            for (int i = 0; i < width; i++)
                border += "-";

            string s = border + "\n";
            for (int i = 0; i < width; i++)
            {
                s += "|";
                for (int j = 0; j < height; j++)
                {
                    if (j == currentPoint.x && i == currentPoint.y)
                        s += "!";
                    else if (grid[j, i].links is null)
                        s += "0";
                    else
                        s += grid[j, i].links.Count;
                }
                s += "|\n";
            }
            s += border;

            return s;
        }

        private void DrawOneScaleDimensions(Image<Rgba32> image, int bmpWidth, int bmpHeight, Rgba32 line, Rgba32 path)
        {
            if (width == 1)
            {
                for (int i = 0; i < bmpHeight; i++)
                {
                    image[0, i] = line;
                    image[2, i] = line;
                    image[1, i] = path;
                }
                return;
            }

            for (int i = 0; i < bmpWidth; i++)
            {
                image[i, 0] = line;
                image[i, 2] = line;
                image[i, 1] = path;
            }
        }

        private static void DrawZeroScaleDimensions(Image<Rgba32> image, int bmpWidth, int bmpHeight, Rgba32 line, Rgba32 path)
        {
            for (int i = 0; i < bmpWidth; i++)
            {
                for (int j = 0; j < bmpHeight; j++)
                {
                    image[i, j] = line;
                }
            }
        }

        private void DrawImage(Image<Rgba32> image, int bmpWidth, int bmpHeight, Rgba32 line, Rgba32 path)
        {
            if (bmpWidth > MaxDimensions || bmpHeight > MaxDimensions)
                throw new MazeUnrenderableException("Dimensions provided were above MazeGenerator.MaxDimensions");
            //draw border
            for (int i = 0; i < bmpWidth; i++)
            {
                for (int j = 0; j < bmpHeight; j++)
                    image[i, j] = line;
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Point currentPoint = new(x, y);
                    Point[] neigbors = Neighbors(currentPoint);

                    Point currentPointImage = GridPointToImagePoint(currentPoint);

                    if (neigbors.Length > 0)
                        image[currentPointImage.x, currentPointImage.y] = path;
                    for (int i = 0; i < neigbors.Length; i++)
                    {
                        if (!LinkExists(currentPoint, neigbors[i]))
                            continue;

                        Point nextPointImage = GridPointToImagePoint(neigbors[i]);

                        Point imagePointOfDivider = Inbetween(currentPointImage, nextPointImage);
                        image[imagePointOfDivider.x, imagePointOfDivider.y] = path;
                    }
                }
            }

            Point GridPointToImagePoint(Point gridPoint)
            {
                if (flip.Item1)
                    gridPoint.x = width - gridPoint.x - 1;

                if (flip.Item2)
                    gridPoint.y = height - gridPoint.y - 1;

                Point p = new(gridPoint.x * 2 + 1, gridPoint.y * 2 + 1);

                return p;
            }

            Point Inbetween(Point a, Point b)
            {
                return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
            }
        }

        public void Save(string pos, SaveType saveType, Rgba32 line, Rgba32 path)
        {
            int bitmapWidth = width * 2 + 1;
            int bitmapHeight = height * 2 + 1;

            using var image = new Image<Rgba32>(bitmapWidth, bitmapHeight);

            if (width == 0 || height == 0)
                DrawZeroScaleDimensions(image, bitmapWidth, bitmapHeight, line, path);
            else if (width == 1 || height == 1)
                DrawOneScaleDimensions(image, bitmapWidth, bitmapHeight, line, path);
            else
            {
                DrawImage(image, bitmapWidth, bitmapHeight, line, path);
                image[1, 0] = path;
                image[bitmapWidth - 1, bitmapHeight - 2] = path;
            }

            Save(image, pos, saveType, line);

            image.Dispose();
        }

        public Image<Rgba32> SaveToImage(Rgba32 line, Rgba32 path)
        {
            int bitmapWidth = width * 2 + 1;
            int bitmapHeight = height * 2 + 1;

            var image = new Image<Rgba32>(bitmapWidth, bitmapHeight);

            if (width == 0 || height == 0)
                DrawZeroScaleDimensions(image, bitmapWidth, bitmapHeight, line, path);
            else if (width == 1 || height == 1)
                DrawOneScaleDimensions(image, bitmapWidth, bitmapHeight, line, path);
            else
            {
                DrawImage(image, bitmapWidth, bitmapHeight, line, path);
                image[1, 0] = path;
                image[bitmapWidth - 1, bitmapHeight - 2] = path;
            }

            return image;
        }

        private void Save<T>(Image<T> image, string path, SaveType saveType, T lineColor) where T : unmanaged, IPixel<T>
        {
            switch (saveType)
            {
                case SaveType.Bmp:
                    image.SaveAsBmp(path);
                    break;
                case SaveType.Jpeg:
                    image.SaveAsJpeg(path);
                    break;
                case SaveType.Gif:
                    image.SaveAsGif(path);
                    break;
                case SaveType.Pbm:
                    image.SaveAsPbm(path);
                    break;
                case SaveType.Png:
                    image.SaveAsPng(path);
                    break;
                case SaveType.Tga:
                    image.SaveAsTga(path);
                    break;
                case SaveType.Tiff:
                    image.SaveAsTiff(path);
                    break;
                case SaveType.Webp:
                    image.SaveAsWebp(path);
                    break;
                case SaveType.Txt:
                    System.IO.File.WriteAllText(path, GetAsString(image, lineColor));
                    break;
                default:
                    break;
            }
        }

        private string GetAsString<T>(Image<T> img, T line) where T : unmanaged, IPixel<T>
        {
            char[,] characters = new char[img.Width, img.Height];
            for (int y = 0; y < img.Width; y++)
            {
                for (int x = 0; x < img.Height; x++)
                {
                    characters[x, y] = Compare(img[x, y], line) ? '#' : ' ';
                }
            }

            string s = "";
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                    s += characters[i, j];

                s += "\n";
            }

            return s;
        }

        private bool Compare<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }
    }
}
