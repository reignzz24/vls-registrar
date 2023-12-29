using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vls_registrar
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {

            this.Hide();
            var login = new LogIn();
            login.Closed += (s, args) => this.Close();
            login.Show();
            /*
            this.Hide();

            LogIn order = new LogIn();

            order.ShowDialog();*/

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cc = new ClientControl();
            cc.Closed += (s, args) => this.Close();
            cc.Show();
        }
    }
}
