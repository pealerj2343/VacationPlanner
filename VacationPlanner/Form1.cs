using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationPlanner
{
    public partial class Form1 : Form
    {
        private double totalCost = 0;
        private double roomCost = 0;
        private double mealCost = 0;
        private double flightCost = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void update()
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void single_btn_CheckedChanged(object sender, EventArgs e)
        {
            roomCost = 150;
            Bitmap image = new Bitmap("C:\\Users\\peale\\source\\repos\\VacationPlanner\\VacationPlanner\\Resources\\sngs.png");
            pictureBox2.Image = image;
        }

        private void double_btn_CheckedChanged(object sender, EventArgs e)
        {
            roomCost = 300;
            Bitmap image = new Bitmap("C:\\Users\\peale\\source\\repos\\VacationPlanner\\VacationPlanner\\Resources\\double.png");
            pictureBox2.Image = image;
        }

        private void suite_btn_CheckedChanged(object sender, EventArgs e)
        {
            roomCost = 500;
            Bitmap image = new Bitmap("C:\\Users\\peale\\source\\repos\\VacationPlanner\\VacationPlanner\\Resources\\suite.jpg");
            pictureBox2.Image = image;
        }

        private void prsuite_btn_CheckedChanged(object sender, EventArgs e)
        {
            roomCost = 1500;
            Bitmap image = new Bitmap("C:\\Users\\peale\\source\\repos\\VacationPlanner\\VacationPlanner\\Resources\\pressuite.jpg");
            pictureBox2.Image = image;
        }

        private void dinn_btn_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 75;
        }

        private void ld_btn_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 150;
        }

        private void full_btn_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 200;
        }

        private void noMeal_btn_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 0;
        }

        private void btn_calcCost_Click(object sender, EventArgs e)
        {
            totalCost = mealCost + roomCost + flightCost;
            lbl_cost.Text = totalCost.ToString("C", CultureInfo.CurrentCulture);
        }

        private void departureCityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jFKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightCost = 300;
        }

        private void bostonLoganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightCost = 350;
        }

        private void lAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightCost = 750;
        }
    }
}
