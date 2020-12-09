using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MLCreateImageNative;

namespace ShowMATLABImage
{
    public partial class ShowMLPlot : Form
    {
        private CCreateImage _createImage = null;
        public CCreateImage createImage
        {
            get {
                if (_createImage == null)
                    _createImage = new CCreateImage();
                return _createImage;
            }
        }

        public ShowMLPlot()
        {
            InitializeComponent();
        }

        public void UpdateGraphic(double gridSize)
        {
            object[] ans = createImage.GimmePeaks(3, gridSize);
            int width = (int)((double[,])ans[1])[0, 0];
            int height = (int)((double[,])ans[2])[0, 0];
            byte[,] mlImg = (byte[,])ans[0];
            DirectBitmap _dbmGraphic = new DirectBitmap(width, height);
            byte[] img = mlImg.Cast<byte>().ToArray();
            _dbmGraphic.SetBytes(img);
            pbGraph.Image = _dbmGraphic.Bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGraphic((double)nudGridSize.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateGraphic((double)nudGridSize.Value);
        }
    }
}
