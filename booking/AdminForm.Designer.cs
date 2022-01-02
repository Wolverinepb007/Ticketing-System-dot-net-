
namespace booking
{
    partial class AdminForm
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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtboxWholeDay = new System.Windows.Forms.TextBox();
			this.lblWholeDay = new System.Windows.Forms.Label();
			this.btnReport = new System.Windows.Forms.Button();
			this.btnSetTicketPrice = new System.Windows.Forms.Button();
			this.txtboxTicketPrice = new System.Windows.Forms.TextBox();
			this.lblTicketPrice = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.cmbboxGroup = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblAdminTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightCyan;
			this.button3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button3.Location = new System.Drawing.Point(569, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 27);
			this.button3.TabIndex = 51;
			this.button3.Text = "Price details";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCyan;
			this.button2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.button2.Location = new System.Drawing.Point(463, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 27);
			this.button2.TabIndex = 50;
			this.button2.Text = "Visitors details";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCyan;
			this.button1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(277, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 34);
			this.button1.TabIndex = 49;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Weekday",
            "Holiday"});
			this.comboBox1.Location = new System.Drawing.Point(280, 95);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(132, 24);
			this.comboBox1.TabIndex = 48;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(112, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 47;
			this.label6.Text = "Day:";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(277, 258);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 23);
			this.textBox3.TabIndex = 46;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(112, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 16);
			this.label5.TabIndex = 45;
			this.label5.Text = "3 hr TicketPrice:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(574, 258);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(132, 23);
			this.textBox2.TabIndex = 44;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(440, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 43;
			this.label4.Text = "4 hr TicketPrice:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(574, 216);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(132, 23);
			this.textBox1.TabIndex = 42;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(440, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 16);
			this.label3.TabIndex = 41;
			this.label3.Text = "2 hr TicketPrice:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(277, 177);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(58, 20);
			this.radioButton2.TabIndex = 40;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Adult ";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(277, 154);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(102, 20);
			this.radioButton1.TabIndex = 39;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Child (5 - 12)";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(112, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 38;
			this.label2.Text = "Age:";
			// 
			// txtboxWholeDay
			// 
			this.txtboxWholeDay.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxWholeDay.Location = new System.Drawing.Point(277, 301);
			this.txtboxWholeDay.Name = "txtboxWholeDay";
			this.txtboxWholeDay.Size = new System.Drawing.Size(132, 23);
			this.txtboxWholeDay.TabIndex = 37;
			// 
			// lblWholeDay
			// 
			this.lblWholeDay.AutoSize = true;
			this.lblWholeDay.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWholeDay.Location = new System.Drawing.Point(112, 304);
			this.lblWholeDay.Name = "lblWholeDay";
			this.lblWholeDay.Size = new System.Drawing.Size(70, 16);
			this.lblWholeDay.TabIndex = 36;
			this.lblWholeDay.Text = "Whole day:";
			// 
			// btnReport
			// 
			this.btnReport.BackColor = System.Drawing.Color.LightCyan;
			this.btnReport.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnReport.Location = new System.Drawing.Point(357, 3);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(100, 27);
			this.btnReport.TabIndex = 35;
			this.btnReport.Text = "Report";
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.btnDailyReport_Click);
			// 
			// btnSetTicketPrice
			// 
			this.btnSetTicketPrice.BackColor = System.Drawing.Color.LightCyan;
			this.btnSetTicketPrice.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetTicketPrice.Location = new System.Drawing.Point(115, 347);
			this.btnSetTicketPrice.Name = "btnSetTicketPrice";
			this.btnSetTicketPrice.Size = new System.Drawing.Size(117, 34);
			this.btnSetTicketPrice.TabIndex = 33;
			this.btnSetTicketPrice.Text = "Set Price";
			this.btnSetTicketPrice.UseVisualStyleBackColor = false;
			this.btnSetTicketPrice.Click += new System.EventHandler(this.btnSetTicketPrice_Click);
			// 
			// txtboxTicketPrice
			// 
			this.txtboxTicketPrice.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxTicketPrice.Location = new System.Drawing.Point(277, 216);
			this.txtboxTicketPrice.Name = "txtboxTicketPrice";
			this.txtboxTicketPrice.Size = new System.Drawing.Size(132, 23);
			this.txtboxTicketPrice.TabIndex = 32;
			// 
			// lblTicketPrice
			// 
			this.lblTicketPrice.AutoSize = true;
			this.lblTicketPrice.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTicketPrice.Location = new System.Drawing.Point(112, 222);
			this.lblTicketPrice.Name = "lblTicketPrice";
			this.lblTicketPrice.Size = new System.Drawing.Size(99, 16);
			this.lblTicketPrice.TabIndex = 31;
			this.lblTicketPrice.Text = "1 hr TicketPrice:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(357, 42);
			this.label1.MaximumSize = new System.Drawing.Size(0, 25);
			this.label1.MinimumSize = new System.Drawing.Size(0, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 25);
			this.label1.TabIndex = 30;
			this.label1.Text = "Set Ticket Price:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogout.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Info;
			this.btnLogout.Location = new System.Drawing.Point(679, 2);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(109, 27);
			this.btnLogout.TabIndex = 29;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// cmbboxGroup
			// 
			this.cmbboxGroup.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbboxGroup.FormattingEnabled = true;
			this.cmbboxGroup.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
			this.cmbboxGroup.Location = new System.Drawing.Point(574, 95);
			this.cmbboxGroup.Name = "cmbboxGroup";
			this.cmbboxGroup.Size = new System.Drawing.Size(132, 24);
			this.cmbboxGroup.TabIndex = 28;
			this.cmbboxGroup.SelectedIndexChanged += new System.EventHandler(this.cmbboxGroup_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(494, 95);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(45, 16);
			this.lblCategory.TabIndex = 27;
			this.lblCategory.Text = "Group:";
			// 
			// lblAdminTitle
			// 
			this.lblAdminTitle.AutoSize = true;
			this.lblAdminTitle.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdminTitle.Location = new System.Drawing.Point(1, 9);
			this.lblAdminTitle.Name = "lblAdminTitle";
			this.lblAdminTitle.Size = new System.Drawing.Size(105, 21);
			this.lblAdminTitle.TabIndex = 26;
			this.lblAdminTitle.Text = "Admin Panel";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtboxWholeDay);
			this.Controls.Add(this.lblWholeDay);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.btnSetTicketPrice);
			this.Controls.Add(this.txtboxTicketPrice);
			this.Controls.Add(this.lblTicketPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.cmbboxGroup);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblAdminTitle);
			this.Name = "AdminForm";
			this.Text = "Admin Pannel";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxWholeDay;
        private System.Windows.Forms.Label lblWholeDay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSetTicketPrice;
        private System.Windows.Forms.TextBox txtboxTicketPrice;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cmbboxGroup;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAdminTitle;
    }
}