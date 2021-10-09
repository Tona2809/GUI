using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ConnectBT_Click(object sender, EventArgs e)
        {
            ConnectDB formConnection = new ConnectDB();
            formConnection.ShowDialog();
        }
    }
}
