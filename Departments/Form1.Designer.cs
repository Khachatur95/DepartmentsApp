namespace ShopApp
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
            this.cmb_Departments = new System.Windows.Forms.ComboBox();
            this.dGrdViewEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Insert_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.SurName_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Patro_TextBox = new System.Windows.Forms.TextBox();
            this.Birt_TextBox = new System.Windows.Forms.TextBox();
            this.Delete_Update_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Departments
            // 
            this.cmb_Departments.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.cmb_Departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Departments.FormattingEnabled = true;
            this.cmb_Departments.Location = new System.Drawing.Point(114, 4);
            this.cmb_Departments.MaxDropDownItems = 10;
            this.cmb_Departments.Name = "cmb_Departments";
            this.cmb_Departments.Size = new System.Drawing.Size(201, 21);
            this.cmb_Departments.TabIndex = 0;
            this.cmb_Departments.SelectedIndexChanged += new System.EventHandler(this.cmb_Departments_SelectedIndexChanged);
            // 
            // dGrdViewEmployees
            // 
            this.dGrdViewEmployees.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dGrdViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdViewEmployees.Location = new System.Drawing.Point(1, 31);
            this.dGrdViewEmployees.Name = "dGrdViewEmployees";
            this.dGrdViewEmployees.Size = new System.Drawing.Size(787, 226);
            this.dGrdViewEmployees.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departments";
            // 
            // Insert_Button
            // 
            this.Insert_Button.Location = new System.Drawing.Point(331, 2);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(75, 23);
            this.Insert_Button.TabIndex = 4;
            this.Insert_Button.Text = "Insert";
            this.Insert_Button.UseVisualStyleBackColor = true;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(412, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 5;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(493, 2);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Button.TabIndex = 6;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(56, 306);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ID_TextBox.TabIndex = 7;
            // 
            // SurName_TextBox
            // 
            this.SurName_TextBox.Location = new System.Drawing.Point(162, 306);
            this.SurName_TextBox.Name = "SurName_TextBox";
            this.SurName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.SurName_TextBox.TabIndex = 8;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(279, 306);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Name_TextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "dpt_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "emp_FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "emp_LastName";
            // 
            // Patro_TextBox
            // 
            this.Patro_TextBox.Location = new System.Drawing.Point(387, 306);
            this.Patro_TextBox.Name = "Patro_TextBox";
            this.Patro_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Patro_TextBox.TabIndex = 13;
            // 
            // Birt_TextBox
            // 
            this.Birt_TextBox.Location = new System.Drawing.Point(493, 306);
            this.Birt_TextBox.Name = "Birt_TextBox";
            this.Birt_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Birt_TextBox.TabIndex = 14;
            // 
            // Delete_Update_TextBox
            // 
            this.Delete_Update_TextBox.Location = new System.Drawing.Point(599, 306);
            this.Delete_Update_TextBox.Name = "Delete_Update_TextBox";
            this.Delete_Update_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Delete_Update_TextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "emp_Patronymic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "emp_BirdtDay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "emp_ID(Delete_Update)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Delete_Update_TextBox);
            this.Controls.Add(this.Birt_TextBox);
            this.Controls.Add(this.Patro_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.SurName_TextBox);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGrdViewEmployees);
            this.Controls.Add(this.cmb_Departments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Departments;
        private System.Windows.Forms.DataGridView dGrdViewEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insert_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.TextBox SurName_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Patro_TextBox;
        private System.Windows.Forms.TextBox Birt_TextBox;
        private System.Windows.Forms.TextBox Delete_Update_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

