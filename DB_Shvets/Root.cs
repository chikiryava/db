using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Shvets
{
    public partial class Root :Form
    {
        public Root ()
        {
            InitializeComponent( );
        }

        private void Root_FormClosed (object sender, FormClosedEventArgs e)
        {

        }

        private void Root_FormClosing (object sender, FormClosingEventArgs e)
        {
            Application.Exit( );
        }

        private void button1_Click (object sender, EventArgs e)
        {
            ChangePassword pass = new ChangePassword( );
            pass.ShowDialog( );
        }
    }
}
