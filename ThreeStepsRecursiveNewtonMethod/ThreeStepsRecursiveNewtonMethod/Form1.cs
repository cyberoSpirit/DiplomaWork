using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MathNet.Numerics.LinearAlgebra.Double;
using System.Collections;

//final program (work excelent)
namespace ThreeStepsRecursiveNewtonMethod
{
    public partial class Form1 : Form
    {
        int n;

        public Form1()
        {
            InitializeComponent();
            comboBFunc.SelectedIndex = 0;
            dataG_x.ColumnCount = 1;
            dataG_x.RowCount = 1;
            dataG_x.Columns[0].Name = "1";
            dataG_x.Columns[0].Width = 40;
            butnExtend.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfFunction = comboBFunc.SelectedIndex;
            double eps = Convert.ToDouble(textB_eps.Text);
            DenseVector x = new DenseVector(n);
            int depth = (int)textB_depth.Value;
            double gamma = Convert.ToDouble(textBGamma.Text);

            for (int i = 0; i < n; ++i)
            {
                x[i] = Convert.ToDouble(dataG_x.Rows[0].Cells[i].Value);
            }
                       
            Newton newt = new Newton(x, n, eps, gamma, depth, numberOfFunction);
            if (radioClassical.Checked == true)
            {
                x = newt.NewtonMethod();
            }
            if (radioRecursive.Checked == true)
            {
                x = newt.ThreeStepsRecursiveNewtonMethod();
            }
            Documentator doc = new Documentator();
            doc = newt.GetDoc();
            int docsize = doc.GetSize();
            textB_IterNum.Text = Convert.ToString(docsize - 1);
            textB_FCount.Text = Convert.ToString(doc.GetCalcFunc());
            textB_FPCount.Text = Convert.ToString(doc.GetCalcPrimeFunc());
            textB_FDPCount.Text = Convert.ToString(doc.GetCalcDoublePrimeFunc());

            dataGridView1.Rows.Clear();
            for (int i = 0; i < docsize; ++i)
            {
                String[] arr = new String[6];
                arr = doc.GetNextArray();
                dataGridView1.Rows.Add(i, arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]);
            }
        }

        //extend two first values for all vector x
        private void butnExtend_Click(object sender, EventArgs e)
        {
            double val1, val2;
            val1 = Convert.ToDouble(dataG_x.Rows[0].Cells[0].Value);
            val2 = Convert.ToDouble(dataG_x.Rows[0].Cells[1].Value);

            for (int i = 2; i < n; i += 2)
            {
                dataG_x.Rows[0].Cells[i].Value = val1;
                dataG_x.Rows[0].Cells[i+1].Value = val2;
            }
        }

        //create and rsize table
        private void textB_n_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textB_n.Text);
            double[] mas = null;
            try
            {
                mas = new double[2];
                mas[0] = Convert.ToDouble(dataG_x.Rows[0].Cells[0].Value);
                mas[1] = Convert.ToDouble(dataG_x.Rows[0].Cells[1].Value);
            }
            catch(Exception)
            {
            }

            dataG_x.Rows.Clear();

            dataG_x.ColumnCount = n;
            dataG_x.RowCount = 1;

            for (int i = 0; i < n; ++i)
            {
                dataG_x.Columns[i].Name = Convert.ToString(i + 1);
                dataG_x.Columns[i].Width = 40;
            }

            if (mas != null && n > 1)
            {
                dataG_x.Rows[0].Cells[0].Value = mas[0];
                dataG_x.Rows[0].Cells[1].Value = mas[1];
            }

            butnExtend.Enabled = ((n > 2) && (n % 2.0 == 0)) ? true : false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 4.5, 6.5 };
            fillForm(2, 0, mas, 7, 0.5, 0.0000001);
        }

        private void rosenbrokaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 0.9, -3.2 };
            fillForm(2, 1, mas, 7, 0.5, 0.0000001);
        }

        private void gradient1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 10, 10 };
            fillForm(2, 2, mas, 7, 0.5, 0.0000001);
        }

        private void gradient2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 5, 5 };
            fillForm(2, 3, mas, 7, 0.5, 0.0000001);
        }

        private void розширенаФункціяВайтаІХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 1.25, -1 };
            fillForm(2, 4, mas, 7, 0.5, 0.0000001);
        }

        private void функціяПауелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] mas = { 5, 1, 0, -2 };
            fillForm(4, 5, mas, 7, 0.5, 0.0000001);
        }

        private void fillForm(int n1, int fNumber, double[] mas, int depth, double gamma, double eps)
        {
            n = n1;
            comboBFunc.SelectedIndex = fNumber;
            textB_n.Value = n;

            dataG_x.Rows.Clear();

            dataG_x.ColumnCount = n;
            dataG_x.RowCount = 1;

            for (int i = 0; i < n; ++i)
            {
                dataG_x.Columns[i].Name = Convert.ToString(i + 1);
                dataG_x.Columns[i].Width = 40;
            }
            for (int i = 0; i < n; ++i)
            {
                dataG_x.Rows[0].Cells[i].Value = mas[i];
            }

            butnExtend.Enabled = ((n > 2) && (n % 2.0 == 0)) ? true : false;

            textB_depth.Value = depth;
            textBGamma.Text = Convert.ToString(gamma);
            textB_eps.Text = Convert.ToString(eps);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
