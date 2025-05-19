using System.Reflection;

namespace Ch13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblLight.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Right)
            {
                lblLight.BackColor = Color.Green;
            }
        }
    }
}
