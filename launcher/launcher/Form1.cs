using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher
{
    public partial class GameduLauncher : Form
    {
        public GameduLauncher()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
