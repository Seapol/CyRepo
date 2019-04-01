namespace CyBLE_MTK_Application
{
    partial class SQLServerConnectionConfigurationDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataSourcetextBox = new System.Windows.Forms.TextBox();
            this.DataBasetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PersistSeurityInfocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionTimeoutnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Read_btn = new System.Windows.Forms.Button();
            this.SaveExitBtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.OpenDB_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TableNametextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTimeoutnumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSource: ";
            // 
            // DataSourcetextBox
            // 
            this.DataSourcetextBox.Location = new System.Drawing.Point(183, 27);
            this.DataSourcetextBox.Name = "DataSourcetextBox";
            this.DataSourcetextBox.Size = new System.Drawing.Size(182, 20);
            this.DataSourcetextBox.TabIndex = 1;
            // 
            // DataBasetextBox
            // 
            this.DataBasetextBox.Location = new System.Drawing.Point(183, 76);
            this.DataBasetextBox.Name = "DataBasetextBox";
            this.DataBasetextBox.Size = new System.Drawing.Size(182, 20);
            this.DataBasetextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database (Initial Catalog): ";
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.Location = new System.Drawing.Point(183, 123);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(182, 20);
            this.UserIDtextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID: ";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(183, 174);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(182, 20);
            this.PasswordtextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Connection Timeout (s): ";
            // 
            // PersistSeurityInfocomboBox
            // 
            this.PersistSeurityInfocomboBox.FormattingEnabled = true;
            this.PersistSeurityInfocomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.PersistSeurityInfocomboBox.Location = new System.Drawing.Point(425, 236);
            this.PersistSeurityInfocomboBox.Name = "PersistSeurityInfocomboBox";
            this.PersistSeurityInfocomboBox.Size = new System.Drawing.Size(74, 21);
            this.PersistSeurityInfocomboBox.TabIndex = 13;
            this.PersistSeurityInfocomboBox.Text = "True";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Persist Security Info: ";
            // 
            // ConnectionTimeoutnumericUpDown
            // 
            this.ConnectionTimeoutnumericUpDown.Location = new System.Drawing.Point(183, 236);
            this.ConnectionTimeoutnumericUpDown.Name = "ConnectionTimeoutnumericUpDown";
            this.ConnectionTimeoutnumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.ConnectionTimeoutnumericUpDown.TabIndex = 14;
            this.ConnectionTimeoutnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Read_btn
            // 
            this.Read_btn.Location = new System.Drawing.Point(425, 27);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(75, 23);
            this.Read_btn.TabIndex = 17;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // SaveExitBtn
            // 
            this.SaveExitBtn.Location = new System.Drawing.Point(424, 121);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveExitBtn.TabIndex = 18;
            this.SaveExitBtn.Text = "Save";
            this.SaveExitBtn.UseVisualStyleBackColor = true;
            this.SaveExitBtn.Click += new System.EventHandler(this.SaveExitBtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(424, 172);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 19;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // OpenDB_btn
            // 
            this.OpenDB_btn.Location = new System.Drawing.Point(424, 74);
            this.OpenDB_btn.Name = "OpenDB_btn";
            this.OpenDB_btn.Size = new System.Drawing.Size(75, 23);
            this.OpenDB_btn.TabIndex = 20;
            this.OpenDB_btn.Text = "Open DB";
            this.OpenDB_btn.UseVisualStyleBackColor = true;
            this.OpenDB_btn.Click += new System.EventHandler(this.OpenDB_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "No Available DB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Table Name: ";
            // 
            // TableNametextBox
            // 
            this.TableNametextBox.Location = new System.Drawing.Point(183, 300);
            this.TableNametextBox.Name = "TableNametextBox";
            this.TableNametextBox.Size = new System.Drawing.Size(182, 20);
            this.TableNametextBox.TabIndex = 24;
            // 
            // SQLServerConnectionConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 369);
            this.Controls.Add(this.TableNametextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OpenDB_btn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.SaveExitBtn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.ConnectionTimeoutnumericUpDown);
            this.Controls.Add(this.PersistSeurityInfocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserIDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataBasetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataSourcetextBox);
            this.Controls.Add(this.label1);
            this.Name = "SQLServerConnectionConfigurationDialog";
            this.Text = "SQLServerConnectionConfigurationDialog";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTimeoutnumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataSourcetextBox;
        private System.Windows.Forms.TextBox DataBasetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PersistSeurityInfocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ConnectionTimeoutnumericUpDown;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button SaveExitBtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button OpenDB_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TableNametextBox;
    }
}