using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkDB_Shvets
{
    public partial class Authorization_frm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SecurityDB_Shvets;Integrated Security=True");
        public Authorization_frm()
        {
            InitializeComponent();
            reloadTable();
        }
       
        private void Authorization_frm_Load(object sender, EventArgs e)
        {}

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (userExist(1, loginTextBox.Text) && userExist(2,passwordTextBox.Text))
            {
                MessageBox.Show("Вы успешно вошли");
            }
        }
        private void reloadTable()
        {
            this.user_tblTableAdapter.Fill(this.securityDB_ShvetsDataSet.User_tbl);
        }
        private bool check()
        {
            if (loginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле логин пустое");
                return false;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле пароль пустое");
                return false;
            }
            return true;
        }
        private bool userExist(int column,string field)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (dataGridView1[column, i].Value.ToString() == field)
                {
                    return true;
                }
            }
            return false;
        }
        private void addUser(string login,string password,int count,string date,bool active,string role)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO dbo.User_tbl(login, password, count, date, active, role)VALUES('{login}', '{password}', 0, '2023-05-1', 'True', 'user')",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            reloadTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (!userExist(1, loginTextBox.Text))
                {
                    addUser(loginTextBox.Text, passwordTextBox.Text, 0, "2023-05-1", true, "user");
                }
            }
        }
    }
}
