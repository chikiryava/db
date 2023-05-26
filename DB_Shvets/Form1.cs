using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;

namespace DB_Shvets
{
    public partial class Authorization_frm :Form
    {
        DateTime date = DateTime.Now;
        string role = string.Empty;
        bool active;
        int count = 0;
        public static string password;
        public static string login = string.Empty;

        public Authorization_frm ()
        {
            InitializeComponent( );
        }

        public SqlConnection connect = new SqlConnection(@"Data Source=PC325L15;Initial Catalog=SecurityDB_Shvets;Integrated Security=True");


        private void registerButton_Click (object sender, EventArgs e) // Регистрация в приложении
        {
            if ( CheckField( ) )
            {
                string sql_expression = $"SELECT * FROM User_tbl WHERE login ='{loginTextBox.Text}'";
                connect.Open( );
                SqlCommand command = new SqlCommand(sql_expression, connect);
                if(command.ExecuteScalar( ) != null )// Существует ли уже такой пользователь
                {
                    MessageBox.Show("Такой пользователь уже существует");
                }
                else // Добавление пользователя
                {
                    sql_expression = $"INSERT INTO User_tbl (Login, Password, Count, LastDate, Active, Role) VALUES ('{loginTextBox.Text}', '{passwordTextBox.Text}', 0, '{date.ToString("yyyy-MM-d")}', 'True', 'User')";
                    SqlCommand command1 = new SqlCommand(sql_expression, connect);
                    command1.ExecuteNonQuery( );
                    MessageBox.Show("Вы успешно зарегестрировались в приложении");
                }
                connect.Close( );
            }
        }
        private bool CheckField () // Проверка на заполненность полей
        {             
            if ( loginTextBox.Text.Length == 0 )
            {
                MessageBox.Show("Поле логин пустое");
                return false;
            }
            if ( passwordTextBox.Text.Length == 0 )
            {
                MessageBox.Show("Поле пароль пустое");
                return false;
            }
            return true;            
        }
        private void inputButton_Click (object sender, EventArgs e) // Вход в программу
        {

            
                connect.Open( );
                DateTime last_date;
                
                string sql_expression = $"SELECT * FROM User_tbl WHERE login ='{loginTextBox.Text}'";
                SqlCommand command = new SqlCommand(sql_expression, connect);
                SqlDataReader dataReader = command.ExecuteReader( );
            if ( dataReader.HasRows )// Совпадения найдены
            {
                dataReader.Read( );

                DateTime currDate = date.AddDays(-30);

                role = dataReader [ "Role" ].ToString( );

                count = int.Parse(dataReader [ "Count" ].ToString( ));

                active = Convert.ToBoolean(dataReader [ "Active" ].ToString( ).ToLower( ));

                password = dataReader [ "Password" ].ToString( );

                login = dataReader [ "Login" ].ToString( );

                last_date = (DateTime) dataReader [ "LastDate" ];

                dataReader.Close( );

                if(password != passwordTextBox.Text && count<3 )
                {
                    sql_expression = $"Update user_tbl Set Count = Count+1 Where Login = '{loginTextBox.Text}'";
                    role = "none";
                    MessageBox.Show("Неверный пароль");
                }
                else if ( count >= 3 && active )
                {
                    sql_expression = $"Update User_tbl Set Active = 'False' Where Login = '{loginTextBox.Text}'";
                    MessageBox.Show("Много неудачных попыток. Пользователь заблокирован");
                    role = "None";
                }
                else if (currDate>last_date)
                {
                    sql_expression = $"Update User_tbl Set Active = 'False' Where Login = '{loginTextBox.Text}'";
                    role = "none";
                    MessageBox.Show("Ваш аккаунт заблокирован так как вы не заходили в приложение больше 14 дней");
                }
                else if ( !active )
                {
                    MessageBox.Show("Пользователь заблокирован");
                    role = "none";
                }
                SqlCommand command1 = new SqlCommand(sql_expression, connect);
                command1.ExecuteNonQuery( );
            }

            else // Совпадения не найдены
            {
                MessageBox.Show("Неверный логин");
            }
                switch ( role ) // форма
                { 
                    case "Admin":
                        Admin admin = new Admin( );
                        admin.Show( );
                        this.Visible = false;
                        break;
                    case "User":
                        Root root = new Root( );
                        root.Show( );
                        this.Visible = false;
                        break;
                    default:
                        break;
                }
                dataReader.Close( );
                connect.Close( );
            
        }
        public string GetLogin ()
        {
            return login;
        }
        public string GetPass ()
        {
            return password;
        }

        private void Authorization_frm_Load (object sender, EventArgs e)
        {

        }
    }
}
