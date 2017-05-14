namespace Utility
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
            this.Save = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.lbtTruck = new System.Windows.Forms.Label();
            this.txtTruckName = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblDeliminator = new System.Windows.Forms.Label();
            this.txtDeliminator = new System.Windows.Forms.TextBox();
            this.btnWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(40, 173);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(135, 173);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 1;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // lbtTruck
            // 
            this.lbtTruck.AutoSize = true;
            this.lbtTruck.Location = new System.Drawing.Point(31, 27);
            this.lbtTruck.Name = "lbtTruck";
            this.lbtTruck.Size = new System.Drawing.Size(63, 13);
            this.lbtTruck.TabIndex = 2;
            this.lbtTruck.Text = "TruckName";
            // 
            // txtTruckName
            // 
            this.txtTruckName.Location = new System.Drawing.Point(93, 24);
            this.txtTruckName.Name = "txtTruckName";
            this.txtTruckName.Size = new System.Drawing.Size(170, 20);
            this.txtTruckName.TabIndex = 3;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(34, 54);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "DateTime";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(34, 79);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(58, 13);
            this.lblFolderPath.TabIndex = 6;
            this.lblFolderPath.Text = "FolderPath";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(93, 72);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(170, 20);
            this.txtFilePath.TabIndex = 7;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(259, 72);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(22, 21);
            this.btnFilePath.TabIndex = 8;
            this.btnFilePath.Text = "...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.CreatePrompt = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(37, 107);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(93, 99);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(170, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // lblDeliminator
            // 
            this.lblDeliminator.AutoSize = true;
            this.lblDeliminator.Location = new System.Drawing.Point(37, 131);
            this.lblDeliminator.Name = "lblDeliminator";
            this.lblDeliminator.Size = new System.Drawing.Size(59, 13);
            this.lblDeliminator.TabIndex = 12;
            this.lblDeliminator.Text = "Deliminator";
            // 
            // txtDeliminator
            // 
            this.txtDeliminator.Location = new System.Drawing.Point(93, 128);
            this.txtDeliminator.Name = "txtDeliminator";
            this.txtDeliminator.Size = new System.Drawing.Size(33, 20);
            this.txtDeliminator.TabIndex = 13;
            this.txtDeliminator.Tag = ',';
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(269, 99);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(33, 25);
            this.btnWeight.TabIndex = 14;
            this.btnWeight.Text = "...";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 220);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.txtDeliminator);
            this.Controls.Add(this.lblDeliminator);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.txtTruckName);
            this.Controls.Add(this.lbtTruck);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label lbtTruck;
        private System.Windows.Forms.TextBox txtTruckName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblDeliminator;
        private System.Windows.Forms.TextBox txtDeliminator;
        private System.Windows.Forms.Button btnWeight;
    }
}

