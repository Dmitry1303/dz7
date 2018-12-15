using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_7
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void OnStartMenuClick(object sender, EventArgs e)
        {
            // киляем всё
            Application.Exit();
        }

        private void OnStartClick(object sender, EventArgs e)
        {
            // прячем эту, загружаем игру
            this.Hide();
            var mainform = new MainForm();
            mainform.Show();
        }

        private void OnStartLoad(object sender, EventArgs e)
        {

        }
    }
}
