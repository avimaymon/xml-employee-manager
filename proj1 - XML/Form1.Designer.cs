namespace proj1___XML
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_LoadTxt = new System.Windows.Forms.Button();
            this.grp_radio = new System.Windows.Forms.GroupBox();
            this.radio_Female = new System.Windows.Forms.RadioButton();
            this.radio_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Children = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.chk_Mobile = new System.Windows.Forms.CheckBox();
            this.chk_Married = new System.Windows.Forms.CheckBox();
            this.combo_Dept = new System.Windows.Forms.ComboBox();
            this.txt_Load = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.grp_radio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Employee ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(21, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Department";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(21, 282);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 34);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_LoadTxt
            // 
            this.btn_LoadTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_LoadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_LoadTxt.ForeColor = System.Drawing.Color.Black;
            this.btn_LoadTxt.Location = new System.Drawing.Point(113, 282);
            this.btn_LoadTxt.Name = "btn_LoadTxt";
            this.btn_LoadTxt.Size = new System.Drawing.Size(121, 34);
            this.btn_LoadTxt.TabIndex = 8;
            this.btn_LoadTxt.Text = "LOAD TEXT";
            this.btn_LoadTxt.UseVisualStyleBackColor = false;
            this.btn_LoadTxt.Click += new System.EventHandler(this.btn_LoadTxt_Click);
            // 
            // grp_radio
            // 
            this.grp_radio.Controls.Add(this.radio_Female);
            this.grp_radio.Controls.Add(this.radio_Male);
            this.grp_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grp_radio.Location = new System.Drawing.Point(14, 115);
            this.grp_radio.Name = "grp_radio";
            this.grp_radio.Size = new System.Drawing.Size(200, 49);
            this.grp_radio.TabIndex = 2;
            this.grp_radio.TabStop = false;
            this.grp_radio.Text = "Gender";
            // 
            // radio_Female
            // 
            this.radio_Female.AutoSize = true;
            this.radio_Female.Location = new System.Drawing.Point(91, 19);
            this.radio_Female.Name = "radio_Female";
            this.radio_Female.Size = new System.Drawing.Size(80, 24);
            this.radio_Female.TabIndex = 1;
            this.radio_Female.TabStop = true;
            this.radio_Female.Text = "Female";
            this.radio_Female.UseVisualStyleBackColor = true;
            // 
            // radio_Male
            // 
            this.radio_Male.AutoSize = true;
            this.radio_Male.Location = new System.Drawing.Point(11, 19);
            this.radio_Male.Name = "radio_Male";
            this.radio_Male.Size = new System.Drawing.Size(61, 24);
            this.radio_Male.TabIndex = 0;
            this.radio_Male.TabStop = true;
            this.radio_Male.Text = "Male";
            this.radio_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.combo_Children);
            this.groupBox2.Location = new System.Drawing.Point(27, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Children";
            // 
            // combo_Children
            // 
            this.combo_Children.Enabled = false;
            this.combo_Children.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.combo_Children.FormattingEnabled = true;
            this.combo_Children.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "more"});
            this.combo_Children.Location = new System.Drawing.Point(86, 13);
            this.combo_Children.Name = "combo_Children";
            this.combo_Children.Size = new System.Drawing.Size(81, 21);
            this.combo_Children.TabIndex = 17;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(78, 60);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(78, 86);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(29, 20);
            this.txt_Age.TabIndex = 1;
            // 
            // chk_Mobile
            // 
            this.chk_Mobile.AutoSize = true;
            this.chk_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk_Mobile.Location = new System.Drawing.Point(25, 190);
            this.chk_Mobile.Name = "chk_Mobile";
            this.chk_Mobile.Size = new System.Drawing.Size(74, 24);
            this.chk_Mobile.TabIndex = 4;
            this.chk_Mobile.Text = "Mobile";
            this.chk_Mobile.UseVisualStyleBackColor = true;
            // 
            // chk_Married
            // 
            this.chk_Married.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chk_Married.Location = new System.Drawing.Point(105, 192);
            this.chk_Married.Name = "chk_Married";
            this.chk_Married.Size = new System.Drawing.Size(96, 20);
            this.chk_Married.TabIndex = 5;
            this.chk_Married.Text = "Married";
            this.chk_Married.UseVisualStyleBackColor = true;
            this.chk_Married.CheckedChanged += new System.EventHandler(this.chk_Married_CheckedChanged);
            // 
            // combo_Dept
            // 
            this.combo_Dept.FormattingEnabled = true;
            this.combo_Dept.Items.AddRange(new object[] {
            "IT",
            "QA",
            "Costumer Service",
            "General"});
            this.combo_Dept.Location = new System.Drawing.Point(121, 169);
            this.combo_Dept.Name = "combo_Dept";
            this.combo_Dept.Size = new System.Drawing.Size(121, 21);
            this.combo_Dept.TabIndex = 3;
            // 
            // txt_Load
            // 
            this.txt_Load.Enabled = false;
            this.txt_Load.Location = new System.Drawing.Point(259, 66);
            this.txt_Load.Multiline = true;
            this.txt_Load.Name = "txt_Load";
            this.txt_Load.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Load.Size = new System.Drawing.Size(230, 198);
            this.txt_Load.TabIndex = 18;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(300, 282);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 34);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "DELETE XML";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 354);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Load);
            this.Controls.Add(this.combo_Dept);
            this.Controls.Add(this.chk_Mobile);
            this.Controls.Add(this.chk_Married);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_radio);
            this.Controls.Add(this.btn_LoadTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Employee Management System";
            this.grp_radio.ResumeLayout(false);
            this.grp_radio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_LoadTxt;
        private System.Windows.Forms.GroupBox grp_radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Children;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.CheckBox chk_Mobile;
        private System.Windows.Forms.CheckBox chk_Married;
        private System.Windows.Forms.RadioButton radio_Female;
        private System.Windows.Forms.RadioButton radio_Male;
        private System.Windows.Forms.ComboBox combo_Dept;
        private System.Windows.Forms.TextBox txt_Load;
        private System.Windows.Forms.Button btn_Delete;
    }
}

