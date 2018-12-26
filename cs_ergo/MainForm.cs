using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_ergo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ERGO_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать", "Эрго",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Point tmp_location;
            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
            
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы усердны!!"); // Завершить приложение 
            Application.Exit();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы не сомневались в вешем безразличии", "Внимание", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
