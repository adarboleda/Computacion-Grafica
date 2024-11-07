using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmCuadrado : Form
    {   
        Cuadrado objCuadrado;
        public FrmCuadrado()
        {
            InitializeComponent();
        }
        
        public void InitializeData()
        {
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtSide.Focus();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCuadrado = new Cuadrado();

            objCuadrado.ReadData(txtSide);
            objCuadrado.PerimeterCuadrado();
            objCuadrado.AreaCuadrado();

            objCuadrado.PrintData(txtPerimeter, txtArea);
            objCuadrado.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
