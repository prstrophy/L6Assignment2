using PolarHrm_Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarHrm_Assignment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Open Dialog for browsing files
        private OpenFileDialog dlg = new OpenFileDialog();

        //initializing filename
        public static string filename;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = dlg.FileName;
                //    System.IO.StreamReader file = new System.IO.StreamReader(filename);

                //   fileLines = File.ReadAllLines(filename);

                new Form1().Show();
                this.Hide();


            }

        }
        public static string fname()
        {

            return filename;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
