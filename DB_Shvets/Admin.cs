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
    public partial class Admin :Form
    {
        Authorization_frm form = new Authorization_frm( );
        DateTime date = DateTime.Now;
        public Admin ()
        {
            InitializeComponent( );
        }

        private void Admin_FormClosing (object sender, FormClosingEventArgs e)
        {
            Application.Exit( );
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if ( CheckFields( ) )
            {
                if ( !CheckLogin( ) )
                {
                    form.connect.Open( );
                    string sql_expression = $"INSERT INTO User_tbl (Login, Password, Count, LastDate, Active, Role) VALUES ('{textBox1.Text}', '{textBox2.Text}', 0, '{date.ToString("yyyy-MM-d")}', '{comboBox2.SelectedItem}', '{comboBox1.SelectedItem}')";
                    SqlCommand command1 = new SqlCommand(sql_expression, form.connect);
                    command1.ExecuteNonQuery( );
                    form.connect.Close( );
                    MessageBox.Show("Вы добавили нового пользователя");
                }
                else
                    MessageBox.Show("Такой пользователь уже существует");
            }
          
        }
        private bool CheckFields ()
        {
            if ( textBox1.Text.Length == 0 )
            {
                MessageBox.Show("Поле логин пусто");
                return false;
            }
            else if( textBox2.Text.Length == 0 )
            {
                MessageBox.Show("Поле пароль пустое");
                return false;
            }
            else if( comboBox1.SelectedItem.ToString( ).Length == 0 )
            {
                MessageBox.Show("Вы не выбрали роль");
                return false;
            }
            else if ( comboBox2.SelectedItem.ToString( ).Length == 0 )
            {
                MessageBox.Show("Вы не выбрали Active");
                return false;
            }
            return true;
        }
        private bool CheckLogin ()
        {
            string sql_expression = $"SELECT * FROM User_tbl WHERE login ='{textBox1.Text}'";
            form.connect.Open( );
            SqlCommand command = new SqlCommand(sql_expression, form.connect);
            
            if ( command.ExecuteScalar( ) != null )// Существует ли уже такой пользователь
            {
                form.connect.Close( );
                return true;

            }
            form.connect.Close( );
            return false;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if ( CheckFields( ) )
            {
                if ( CheckLogin( ) )
                {
                    string sql_expression = $"Update User_tbl SET Password = '{textBox2.Text}',Count = 0,Active = '{comboBox2.SelectedItem}', Role = '{comboBox1.SelectedItem}',LastDate = '{date.ToString("yyyy-MM-d")}' Where Login = '{textBox1.Text}'";
                    form.connect.Open( );
                    SqlCommand command1 = new SqlCommand(sql_expression, form.connect);
                    command1.ExecuteNonQuery( );
                    form.connect.Close( );
                    MessageBox.Show("Вы изменили данные пользователя");
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
        }
    }
}
