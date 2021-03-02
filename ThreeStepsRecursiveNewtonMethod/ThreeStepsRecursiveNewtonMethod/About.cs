using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ThreeStepsRecursiveNewtonMethod
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", "Про програму");
            this.labelProductName.Text = "Трикроковий рекурсивний метод Ньютона";
            this.labelVersion.Text = String.Format("Version {0}", "Версія: 0.1.1.12");
            this.labelCopyright.Text = "(с) Грицик Юлія";
            this.labelCompanyName.Text = "студентка групи ПМА-51м";
            this.textBoxDescription.Text = "Трикроковий рекурсивний метод Ньютона з глибиною";
        }
               
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
