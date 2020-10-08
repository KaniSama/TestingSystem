namespace Tests
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.okButton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.regOK = new System.Windows.Forms.Button();
            this.faNameBox = new System.Windows.Forms.TextBox();
            this.faNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.passConfirmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.regPassConfirmBox = new System.Windows.Forms.TextBox();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.regLogBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.okButton.Location = new System.Drawing.Point(19, 228);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(184, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Вход";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Location = new System.Drawing.Point(19, 121);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(386, 23);
            this.loginBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Location = new System.Drawing.Point(19, 180);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(346, 23);
            this.passBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginLabel.Location = new System.Drawing.Point(19, 100);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 17);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passLabel.Location = new System.Drawing.Point(19, 159);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(63, 17);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Пароль";
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showPasswordButton.BackColor = System.Drawing.SystemColors.Control;
            this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showPasswordButton.Location = new System.Drawing.Point(373, 175);
            this.showPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(32, 30);
            this.showPasswordButton.TabIndex = 6;
            this.showPasswordButton.TabStop = false;
            this.showPasswordButton.Text = "*";
            this.showPasswordButton.UseVisualStyleBackColor = false;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.registerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerButton.Location = new System.Drawing.Point(250, 228);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(155, 30);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(352, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 413);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.registerButton);
            this.tabPage1.Controls.Add(this.okButton);
            this.tabPage1.Controls.Add(this.showPasswordButton);
            this.tabPage1.Controls.Add(this.loginBox);
            this.tabPage1.Controls.Add(this.passLabel);
            this.tabPage1.Controls.Add(this.passBox);
            this.tabPage1.Controls.Add(this.loginLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.cancelButton);
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.regOK);
            this.tabPage2.Controls.Add(this.faNameBox);
            this.tabPage2.Controls.Add(this.faNameLabel);
            this.tabPage2.Controls.Add(this.fNameLabel);
            this.tabPage2.Controls.Add(this.lNameLabel);
            this.tabPage2.Controls.Add(this.passConfirmLabel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fNameBox);
            this.tabPage2.Controls.Add(this.lNameBox);
            this.tabPage2.Controls.Add(this.regPassConfirmBox);
            this.tabPage2.Controls.Add(this.regPassBox);
            this.tabPage2.Controls.Add(this.regLogBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(191, 293);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 30);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.Location = new System.Drawing.Point(329, 293);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 27);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // regOK
            // 
            this.regOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.regOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.regOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regOK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.regOK.Location = new System.Drawing.Point(6, 293);
            this.regOK.Name = "regOK";
            this.regOK.Size = new System.Drawing.Size(131, 27);
            this.regOK.TabIndex = 26;
            this.regOK.Text = "OK";
            this.regOK.UseVisualStyleBackColor = false;
            this.regOK.Click += new System.EventHandler(this.regOK_Click);
            // 
            // faNameBox
            // 
            this.faNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faNameBox.Location = new System.Drawing.Point(6, 250);
            this.faNameBox.MaxLength = 100;
            this.faNameBox.Name = "faNameBox";
            this.faNameBox.Size = new System.Drawing.Size(410, 23);
            this.faNameBox.TabIndex = 25;
            // 
            // faNameLabel
            // 
            this.faNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faNameLabel.AutoSize = true;
            this.faNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.faNameLabel.Location = new System.Drawing.Point(6, 230);
            this.faNameLabel.Name = "faNameLabel";
            this.faNameLabel.Size = new System.Drawing.Size(79, 17);
            this.faNameLabel.TabIndex = 24;
            this.faNameLabel.Text = "Отчество";
            // 
            // fNameLabel
            // 
            this.fNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fNameLabel.Location = new System.Drawing.Point(6, 187);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(38, 17);
            this.fNameLabel.TabIndex = 23;
            this.fNameLabel.Text = "Имя";
            // 
            // lNameLabel
            // 
            this.lNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lNameLabel.Location = new System.Drawing.Point(6, 142);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(77, 17);
            this.lNameLabel.TabIndex = 22;
            this.lNameLabel.Text = "Фамилия";
            // 
            // passConfirmLabel
            // 
            this.passConfirmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passConfirmLabel.AutoSize = true;
            this.passConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passConfirmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passConfirmLabel.Location = new System.Drawing.Point(6, 96);
            this.passConfirmLabel.Name = "passConfirmLabel";
            this.passConfirmLabel.Size = new System.Drawing.Size(185, 17);
            this.passConfirmLabel.TabIndex = 21;
            this.passConfirmLabel.Text = "Подтверждение пароля";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Логин";
            // 
            // fNameBox
            // 
            this.fNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fNameBox.Location = new System.Drawing.Point(6, 206);
            this.fNameBox.MaxLength = 100;
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(410, 23);
            this.fNameBox.TabIndex = 18;
            // 
            // lNameBox
            // 
            this.lNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNameBox.Location = new System.Drawing.Point(6, 161);
            this.lNameBox.MaxLength = 100;
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(410, 23);
            this.lNameBox.TabIndex = 17;
            // 
            // regPassConfirmBox
            // 
            this.regPassConfirmBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regPassConfirmBox.Location = new System.Drawing.Point(6, 115);
            this.regPassConfirmBox.MaxLength = 50;
            this.regPassConfirmBox.Name = "regPassConfirmBox";
            this.regPassConfirmBox.PasswordChar = '*';
            this.regPassConfirmBox.Size = new System.Drawing.Size(410, 23);
            this.regPassConfirmBox.TabIndex = 16;
            // 
            // regPassBox
            // 
            this.regPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regPassBox.Location = new System.Drawing.Point(6, 72);
            this.regPassBox.MaxLength = 50;
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.PasswordChar = '*';
            this.regPassBox.Size = new System.Drawing.Size(410, 23);
            this.regPassBox.TabIndex = 15;
            // 
            // regLogBox
            // 
            this.regLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regLogBox.Location = new System.Drawing.Point(6, 27);
            this.regLogBox.MaxLength = 25;
            this.regLogBox.Name = "regLogBox";
            this.regLogBox.Size = new System.Drawing.Size(410, 23);
            this.regLogBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tests.Properties.Resources.eztest;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 96);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(13, 116);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(333, 309);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Пусть школьные годы давно прошли. Наши тесты помогут проверить, насколько хорошо " +
    "вы помните то, чему вас учили терпеливые учителя.";
            // 
            // Auth
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 437);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизуйтесь.";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button regOK;
        private System.Windows.Forms.TextBox faNameBox;
        private System.Windows.Forms.Label faNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label passConfirmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox regPassConfirmBox;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.TextBox regLogBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancelButton;
    }
}

