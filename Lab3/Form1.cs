using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Sun.Draw(Brushes.Yellow, e);
            //Sea.Draw(Brushes.Blue, e);
            //Iceberg.Draw(Brushes.White, e);
            //Paluba.Draw(Brushes.Gray, e);
            //Corma.Draw(Brushes.Black, e);
            pictureBox1.BackColor = Color.AliceBlue;
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxRectangle1.Checked || checkBoxTriangle1.Checked || checkBoxTrapeze1.Checked || checkBoxCircle1.Checked)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        //if (checkBoxRectangle1.Checked) Paluba.Move(Constants.UP);
                        //if (checkBoxTriangle1.Checked) Iceberg.Move(Constants.UP);
                        //if (checkBoxTrapeze1.Checked) Corma.Move(Constants.UP);
                        //if (checkBoxCircle1.Checked) Sun.Move(Constants.UP);
                        pictureBox1.Refresh();
                        break;
                    case Keys.S:
                        //if (checkBoxRectangle1.Checked) Paluba.Move(Constants.DOWN);
                        //if (checkBoxTriangle1.Checked) Iceberg.Move(Constants.DOWN);
                        //if (checkBoxTrapeze1.Checked) Corma.Move(Constants.DOWN);
                        //if (checkBoxCircle1.Checked) Sun.Move(Constants.DOWN);
                        pictureBox1.Refresh();
                        break;
                    case Keys.A:
                        //if (checkBoxRectangle1.Checked) Paluba.Move(Constants.LEFT);
                        //if (checkBoxTriangle1.Checked) Iceberg.Move(Constants.LEFT);
                        //if (checkBoxTrapeze1.Checked) Corma.Move(Constants.LEFT);
                        //if (checkBoxCircle1.Checked) Sun.Move(Constants.LEFT);
                        pictureBox1.Refresh();
                        break;
                    case Keys.D:
                        //if (checkBoxRectangle1.Checked) Paluba.Move(Constants.RIGHT);
                        //if (checkBoxTriangle1.Checked) Iceberg.Move(Constants.RIGHT);
                        //if (checkBoxTrapeze1.Checked) Corma.Move(Constants.RIGHT);
                        //if (checkBoxCircle1.Checked) Sun.Move(Constants.RIGHT);
                        pictureBox1.Refresh();
                        break;
                    case Keys.OemMinus:
                        //if (checkBoxRectangle1.Checked) Paluba.Decrease(Constants.XY);
                        //if (checkBoxTriangle1.Checked) Iceberg.Decrease(Constants.XY);
                        //if (checkBoxTrapeze1.Checked) Corma.Decrease(Constants.XY);
                        //if (checkBoxCircle1.Checked) Sun.Decrease(Constants.XY);
                        pictureBox1.Refresh();
                        break;
                    case Keys.Oemplus:
                        //if (checkBoxRectangle1.Checked) Paluba.Increase(Constants.XY);
                        //if (checkBoxTriangle1.Checked) Iceberg.Increase(Constants.XY);
                        //if (checkBoxTrapeze1.Checked) Corma.Increase(Constants.XY);
                        //if (checkBoxCircle1.Checked) Sun.Increase(Constants.XY);
                        pictureBox1.Refresh();
                        break;
                    case Keys.Q:
                        //if (checkBoxRectangle1.Checked) Paluba.Rotate(Constants.LEFT);
                        //if (checkBoxTriangle1.Checked) Iceberg.Rotate(Constants.LEFT);
                        //if (checkBoxTrapeze1.Checked) Corma.Rotate(Constants.LEFT);
                        //if (checkBoxCircle1.Checked) Sun.Rotate(Constants.LEFT);
                        pictureBox1.Refresh();
                        break;
                    case Keys.E:
                        //if (checkBoxRectangle1.Checked) Paluba.Rotate(Constants.RIGHT);
                        //if (checkBoxTriangle1.Checked) Iceberg.Rotate(Constants.RIGHT);
                        //if (checkBoxTrapeze1.Checked) Corma.Rotate(Constants.RIGHT);
                        //if (checkBoxCircle1.Checked) Sun.Rotate(Constants.RIGHT);
                        pictureBox1.Refresh();
                        break;
                }
            }
        }
    }
}
