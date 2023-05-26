using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Shvets
{
    public partial class ChangePassword :Form
    {
        public ChangePassword ()
        {
            InitializeComponent( );
        }

        readonly Authorization_frm form = new Authorization_frm( );

        private void button1_Click (object sender, EventArgs e)
        {
            if(textBox1.Text != form.GetPass() ) 
            {
                MessageBox.Show("Неверный пароль");
            }
            else if ( textBox2.Text != textBox3.Text )
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                string sql_command = $"Update User_tbl SET Password = '{textBox2.Text}' Where Login = '{form.GetLogin()}'";
                form.connect.Open( );
                SqlCommand command = new SqlCommand(sql_command, form.connect);
                command.ExecuteNonQuery( );
                MessageBox.Show("Пароль был обновлен");
                form.connect.Close( );
                this.Close( );
            }
        }

        private void ChangePassword_Load (object sender, EventArgs e)
        {

        }
    }
}
