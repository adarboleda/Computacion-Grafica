using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Cuadrado
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Cuadrado()
        {
            mSide = 0.0f;;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Error...", "Datos no validos!");
            }
        }

        public void PerimeterCuadrado()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaCuadrado()
        {
            mArea = mSide*mSide;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un Rectangulo.
            mGraph.DrawRectangle(mPen,0,0,mSide*SF,mSide*SF);
        }
    }
}
