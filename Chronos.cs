using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;


namespace Chronos_V2
{
    public partial class Chronos : Form
    {
        
        


        public Chronos()
        {
            InitializeComponent();
            MainAPI.Load(); //Loads Krnl
        }

        

        private void Key_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Thanks For Using Chronos");
            this.Hide();
        
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MainAPI.Execute(FastColoredTextBox.Text); //Executes script after Krnl has Injected
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(FastColoredTextBox.Text);
                }
            }
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            FastColoredTextBox.Clear();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                FastColoredTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Settings openform = new Settings();
            openform.Show();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            Settings openform = new Settings();
            openform.Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            MainAPI.Inject(); //Inject Krnl
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click_1(object sender, EventArgs e)
        {
           Credits openform = new Credits();
            openform.Show();
        }
    }
        
       


}

