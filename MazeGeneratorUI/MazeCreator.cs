using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maze;
using System.IO;
using System.Drawing.Drawing2D;

namespace MazeGeneratorUI
{
    public partial class MazeCreator : Form
    {
        private static MazeGenerator? mazeGenerator;
        public MazeCreator()
        {
            InitializeComponent();
        }

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;

            if (Options.Instance.UseSeed)
                mazeGenerator = new((int)WidthValue.Value, (int)HeightValue.Value, Options.Instance.Seed);
            else
                mazeGenerator = new((int)WidthValue.Value, (int)HeightValue.Value);

            mazeGenerator.Generate();

            SixLabors.ImageSharp.PixelFormats.Rgba32 lineColor = ConvertColor(Options.Instance.lineColor);
            SixLabors.ImageSharp.PixelFormats.Rgba32 pathColor = ConvertColor(Options.Instance.pathColor);

            var img = mazeGenerator.SaveToImage(lineColor, pathColor);

            Bitmap SystemDrawingImage = new(img.Width, img.Height);
            
            for (int x = 0; x < SystemDrawingImage.Width; x++)
            {
                for (int y = 0; y < SystemDrawingImage.Height; y++)
                    SystemDrawingImage.SetPixel(x, y, Color.FromArgb(img[x, y].A, img[x, y].R, img[x, y].G, img[x, y].B));
            }

            img.Dispose();

            preview.Image = SystemDrawingImage;
        }

        private SixLabors.ImageSharp.PixelFormats.Rgba32 ConvertColor(Color c) => new(c.R, c.G, c.B, c.A);

        private void MazePaint(object sender, PaintEventArgs e)
        {
            if (preview.Image is null)
                return;
            var imgOriginal = preview.Image;
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            int trueHeight = imgOriginal.Width / imgOriginal.Height;

            if (trueHeight == 0)
                trueHeight = 1;

            e.Graphics.DrawImage(
               imgOriginal,
                new Rectangle(0, 0, 300, 300 / trueHeight),
                // destination rectangle 
                0,
                0,           // upper-left corner of source rectangle
                imgOriginal.Width,       // width of source rectangle
                imgOriginal.Height,      // height of source rectangle
                GraphicsUnit.Pixel);
        }

        private void SaveImage(object sender, EventArgs e)
        {
            if (mazeGenerator is null)
                return;
            if (Options.Instance is null)
                return;

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Bitmap Image|*.bmp|Jpeg Image|*.jpg|GIF Image|*.gif|Portable Bitmap Image|*.pbm|" +
                "Portable Network Graphic|*.png|TGA Image|*.tga|TIFF Image|*.tiff|WebP Image|*.webp|Text Format|*.txt",
                Title = "Save a maze file"
            };
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                var saveType = (SaveType)(saveFileDialog.FilterIndex - 1);
                mazeGenerator.Save(saveFileDialog.FileName, saveType, ConvertColor(Options.Instance.lineColor), ConvertColor(Options.Instance.pathColor));
            }
        }

        private void AdvancedOpen(object sender, EventArgs e)
        {
            new Advanced().ShowDialog();
        }
    }
}
