namespace Tests
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.testChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testOkButton = new System.Windows.Forms.Button();
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.loadLink = new System.Windows.Forms.LinkLabel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.resultsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // testChoice
            // 
            this.testChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testChoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.testChoice.FormattingEnabled = true;
            this.testChoice.Location = new System.Drawing.Point(14, 33);
            this.testChoice.Name = "testChoice";
            this.testChoice.Size = new System.Drawing.Size(611, 23);
            this.testChoice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тест";
            // 
            // testOkButton
            // 
            this.testOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testOkButton.Location = new System.Drawing.Point(14, 66);
            this.testOkButton.Name = "testOkButton";
            this.testOkButton.Size = new System.Drawing.Size(611, 27);
            this.testOkButton.TabIndex = 2;
            this.testOkButton.Text = "Пройти тест";
            this.testOkButton.UseVisualStyleBackColor = true;
            this.testOkButton.Click += new System.EventHandler(this.testOkButton_Click);
            // 
            // resultsGroup
            // 
            this.resultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGroup.Controls.Add(this.loadLink);
            this.resultsGroup.Controls.Add(this.Grid);
            this.resultsGroup.Location = new System.Drawing.Point(14, 100);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(611, 354);
            this.resultsGroup.TabIndex = 3;
            this.resultsGroup.TabStop = false;
            this.resultsGroup.Text = "Мои результаты";
            // 
            // loadLink
            // 
            this.loadLink.AutoSize = true;
            this.loadLink.Location = new System.Drawing.Point(7, 18);
            this.loadLink.Name = "loadLink";
            this.loadLink.Size = new System.Drawing.Size(85, 16);
            this.loadLink.TabIndex = 1;
            this.loadLink.TabStop = true;
            this.loadLink.Text = "(Загрузить)";
            this.loadLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(8, 37);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(596, 310);
            this.Grid.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 468);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.testOkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testChoice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.resultsGroup.ResumeLayout(false);
            this.resultsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox testChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testOkButton;
        private System.Windows.Forms.GroupBox resultsGroup;
        private System.Windows.Forms.LinkLabel loadLink;
        private System.Windows.Forms.DataGridView Grid;
    }
}