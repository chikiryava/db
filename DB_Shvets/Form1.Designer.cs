namespace DB_Shvets
{
    partial class Authorization_frm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.inputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.securityDB_ShvetsDataSet = new DB_Shvets.SecurityDB_ShvetsDataSet();
            this.securityDBShvetsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_tblTableAdapter = new DB_Shvets.SecurityDB_ShvetsDataSetTableAdapters.User_tblTableAdapter();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.securityDB_ShvetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDBShvetsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(185, 157);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(135, 62);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Войти в приложение";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(231, 60);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 29);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(231, 97);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 29);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // securityDB_ShvetsDataSet
            // 
            this.securityDB_ShvetsDataSet.DataSetName = "SecurityDB_ShvetsDataSet";
            this.securityDB_ShvetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securityDBShvetsDataSetBindingSource
            // 
            this.securityDBShvetsDataSetBindingSource.DataSource = this.securityDB_ShvetsDataSet;
            this.securityDBShvetsDataSetBindingSource.Position = 0;
            // 
            // usertblBindingSource
            // 
            this.usertblBindingSource.DataMember = "User_tbl";
            this.usertblBindingSource.DataSource = this.securityDB_ShvetsDataSet;
            // 
            // user_tblTableAdapter
            // 
            this.user_tblTableAdapter.ClearBeforeFill = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(336, 157);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(235, 62);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Зарегистрироваться в приложении";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Authorization_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputButton);
            this.Name = "Authorization_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Для входа введите логин и пароль";
            this.Load += new System.EventHandler(this.Authorization_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.securityDB_ShvetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDBShvetsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usertblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource securityDBShvetsDataSetBindingSource;
        private SecurityDB_ShvetsDataSet securityDB_ShvetsDataSet;
        private System.Windows.Forms.BindingSource usertblBindingSource;
        private SecurityDB_ShvetsDataSetTableAdapters.User_tblTableAdapter user_tblTableAdapter;
        private System.Windows.Forms.Button registerButton;
    }
}

