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
    public partial class FrmRectangulo : Form
    {   
        Rectangle objRectangle;
        public FrmRectangulo()
        {
            InitializeComponent();
        }
        
        public void InitializeData()
        {
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtWidth.Focus();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRectangle = new Rectangle();

            objRectangle.ReadData(txtWidth, txtHeight);
            objRectangle.PerimeterRectangle();
            objRectangle.AreaRectangle();

            objRectangle.PrintData(txtPerimeter, txtArea);
            objRectangle.PlotShape(picCanvas);
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
