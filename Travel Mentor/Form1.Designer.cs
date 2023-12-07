namespace Travel_Mentor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.entryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.holiTypeBox = new System.Windows.Forms.ComboBox();
            this.accomTypeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.releaseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transTypeBox = new System.Windows.Forms.ComboBox();
            this.activityListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.withWhoBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.weaPreferBox = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numberPeopleBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Holiday Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Accommodation Type";
            // 
            // locationBox
            // 
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(150, 24);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(151, 28);
            this.locationBox.TabIndex = 11;
            // 
            // entryTimePicker
            // 
            this.entryTimePicker.CustomFormat = "dd.MM";
            this.entryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryTimePicker.Location = new System.Drawing.Point(209, 73);
            this.entryTimePicker.MinDate = new System.DateTime(2023, 11, 4, 16, 33, 41, 0);
            this.entryTimePicker.Name = "entryTimePicker";
            this.entryTimePicker.Size = new System.Drawing.Size(125, 27);
            this.entryTimePicker.TabIndex = 12;
            this.entryTimePicker.Value = new System.DateTime(2023, 11, 4, 16, 33, 41, 0);
            // 
            // holiTypeBox
            // 
            this.holiTypeBox.FormattingEnabled = true;
            this.holiTypeBox.Location = new System.Drawing.Point(209, 304);
            this.holiTypeBox.Name = "holiTypeBox";
            this.holiTypeBox.Size = new System.Drawing.Size(238, 28);
            this.holiTypeBox.TabIndex = 14;
            this.holiTypeBox.SelectedIndexChanged += new System.EventHandler(this.holiTypeBox_SelectedIndexChanged);
            // 
            // accomTypeBox
            // 
            this.accomTypeBox.FormattingEnabled = true;
            this.accomTypeBox.Location = new System.Drawing.Point(209, 355);
            this.accomTypeBox.Name = "accomTypeBox";
            this.accomTypeBox.Size = new System.Drawing.Size(238, 28);
            this.accomTypeBox.TabIndex = 15;
            this.accomTypeBox.SelectedIndexChanged += new System.EventHandler(this.accomTypeBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Entry";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Release";
            // 
            // releaseTimePicker
            // 
            this.releaseTimePicker.CustomFormat = "dd.MM";
            this.releaseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.releaseTimePicker.Location = new System.Drawing.Point(209, 123);
            this.releaseTimePicker.MinDate = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            this.releaseTimePicker.Name = "releaseTimePicker";
            this.releaseTimePicker.Size = new System.Drawing.Size(125, 27);
            this.releaseTimePicker.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Transportation Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Activity";
            // 
            // transTypeBox
            // 
            this.transTypeBox.FormattingEnabled = true;
            this.transTypeBox.Location = new System.Drawing.Point(209, 408);
            this.transTypeBox.Name = "transTypeBox";
            this.transTypeBox.Size = new System.Drawing.Size(238, 28);
            this.transTypeBox.TabIndex = 21;
            this.transTypeBox.SelectedIndexChanged += new System.EventHandler(this.transTypeBox_SelectedIndexChanged);
            // 
            // activityListBox
            // 
            this.activityListBox.FormattingEnabled = true;
            this.activityListBox.Location = new System.Drawing.Point(209, 471);
            this.activityListBox.Name = "activityListBox";
            this.activityListBox.Size = new System.Drawing.Size(238, 136);
            this.activityListBox.TabIndex = 22;
            this.activityListBox.SelectedIndexChanged += new System.EventHandler(this.activityListBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "With whom";
            // 
            // withWhoBox
            // 
            this.withWhoBox.FormattingEnabled = true;
            this.withWhoBox.Location = new System.Drawing.Point(209, 619);
            this.withWhoBox.Name = "withWhoBox";
            this.withWhoBox.Size = new System.Drawing.Size(238, 28);
            this.withWhoBox.TabIndex = 27;
            this.withWhoBox.SelectedIndexChanged += new System.EventHandler(this.withWhoBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 707);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Weather Preference";
            // 
            // weaPreferBox
            // 
            this.weaPreferBox.FormattingEnabled = true;
            this.weaPreferBox.Location = new System.Drawing.Point(208, 707);
            this.weaPreferBox.Name = "weaPreferBox";
            this.weaPreferBox.Size = new System.Drawing.Size(151, 28);
            this.weaPreferBox.TabIndex = 29;
            this.weaPreferBox.SelectedIndexChanged += new System.EventHandler(this.weaPreferBox_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 817);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(182, 47);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Number of People";
            // 
            // numberPeopleBox
            // 
            this.numberPeopleBox.FormattingEnabled = true;
            this.numberPeopleBox.Location = new System.Drawing.Point(209, 243);
            this.numberPeopleBox.Name = "numberPeopleBox";
            this.numberPeopleBox.Size = new System.Drawing.Size(238, 28);
            this.numberPeopleBox.TabIndex = 32;
            this.numberPeopleBox.SelectedIndexChanged += new System.EventHandler(this.numberPeopleBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(640, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 28);
            this.label15.TabIndex = 35;
            this.label15.Text = "Mentor Önerileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(527, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 155);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suggestion 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(527, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 165);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suggestion 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(527, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 187);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suggestion 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(527, 637);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 179);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Suggestion 4";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(527, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(287, 35);
            this.welcomeLabel.TabIndex = 38;
            this.welcomeLabel.Text = "Welcome, @user_name";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(208, 180);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(239, 27);
            this.txtBudget.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1331, 885);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 73);
            this.button1.TabIndex = 40;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(413, 885);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(58, 20);
            this.test.TabIndex = 41;
            this.test.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 1005);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numberPeopleBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.weaPreferBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.withWhoBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.activityListBox);
            this.Controls.Add(this.transTypeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.releaseTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accomTypeBox);
            this.Controls.Add(this.holiTypeBox);
            this.Controls.Add(this.entryTimePicker);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Mentor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox locationBox;
        private DateTimePicker entryTimePicker;
        private ComboBox holiTypeBox;
        private ComboBox accomTypeBox;
        private Label label6;
        private Label label7;
        private DateTimePicker releaseTimePicker;
        private Label label8;
        private Label label9;
        private ComboBox transTypeBox;
        private CheckedListBox activityListBox;
        private Label label10;
        private ComboBox withWhoBox;
        private Label label12;
        private ComboBox weaPreferBox;
        private Button btnCreate;
        private Label label13;
        private ComboBox numberPeopleBox;
        private Label label15;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label welcomeLabel;
        private TextBox txtBudget;
        private Button button1;
        private Label test;
    }
}