namespace phumla_kamnandi_83
{
    partial class HomePageForm
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
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roleLabel1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Items.AddRange(new object[] {
            "Cape Town",
            "Jahanessburg",
            "Durban",
            "Richards Bay",
            "Gqeberha",
            "Stellenbosch",
            "Strand"});
            this.hotelComboBox.Location = new System.Drawing.Point(323, 72);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(161, 27);
            this.hotelComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select hotel";
            // 
            // roleLabel1
            // 
            this.roleLabel1.AutoSize = true;
            this.roleLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel1.Location = new System.Drawing.Point(212, 132);
            this.roleLabel1.Name = "roleLabel1";
            this.roleLabel1.Size = new System.Drawing.Size(88, 21);
            this.roleLabel1.TabIndex = 4;
            this.roleLabel1.Text = "Select role";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.comboBox1.Location = new System.Drawing.Point(323, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(315, 180);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(169, 26);
            this.id_txt.TabIndex = 8;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(315, 227);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(169, 20);
            this.password_txt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelComboBox);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Login";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button button1;
    }
}

