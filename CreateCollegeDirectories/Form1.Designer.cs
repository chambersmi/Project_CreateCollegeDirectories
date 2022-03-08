namespace CreateCollegeDirectories {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCreateDirectories = new System.Windows.Forms.Button();
            this.txtBoxDirectoryName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtBoxDirectoryLocation = new System.Windows.Forms.TextBox();
            this.lblDirectoryLocation = new System.Windows.Forms.Label();
            this.btnOpenDirectoryList = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateDirectories
            // 
            this.btnCreateDirectories.Location = new System.Drawing.Point(87, 101);
            this.btnCreateDirectories.Name = "btnCreateDirectories";
            this.btnCreateDirectories.Size = new System.Drawing.Size(181, 23);
            this.btnCreateDirectories.TabIndex = 0;
            this.btnCreateDirectories.Text = "Create Directories";
            this.btnCreateDirectories.UseVisualStyleBackColor = true;
            this.btnCreateDirectories.Click += new System.EventHandler(this.btnCreateDirectories_Click);
            // 
            // txtBoxDirectoryName
            // 
            this.txtBoxDirectoryName.Location = new System.Drawing.Point(88, 64);
            this.txtBoxDirectoryName.Name = "txtBoxDirectoryName";
            this.txtBoxDirectoryName.Size = new System.Drawing.Size(180, 20);
            this.txtBoxDirectoryName.TabIndex = 1;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(19, 67);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(63, 13);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Class Name";
            // 
            // txtBoxDirectoryLocation
            // 
            this.txtBoxDirectoryLocation.Location = new System.Drawing.Point(87, 25);
            this.txtBoxDirectoryLocation.Name = "txtBoxDirectoryLocation";
            this.txtBoxDirectoryLocation.Size = new System.Drawing.Size(181, 20);
            this.txtBoxDirectoryLocation.TabIndex = 3;
            // 
            // lblDirectoryLocation
            // 
            this.lblDirectoryLocation.AutoSize = true;
            this.lblDirectoryLocation.Location = new System.Drawing.Point(33, 28);
            this.lblDirectoryLocation.Name = "lblDirectoryLocation";
            this.lblDirectoryLocation.Size = new System.Drawing.Size(48, 13);
            this.lblDirectoryLocation.TabIndex = 4;
            this.lblDirectoryLocation.Text = "Location";
            // 
            // btnOpenDirectoryList
            // 
            this.btnOpenDirectoryList.Location = new System.Drawing.Point(274, 25);
            this.btnOpenDirectoryList.Name = "btnOpenDirectoryList";
            this.btnOpenDirectoryList.Size = new System.Drawing.Size(40, 23);
            this.btnOpenDirectoryList.TabIndex = 5;
            this.btnOpenDirectoryList.Text = "...";
            this.btnOpenDirectoryList.UseVisualStyleBackColor = true;
            this.btnOpenDirectoryList.Click += new System.EventHandler(this.btnOpenDirectoryList_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 175);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOpenDirectoryList);
            this.Controls.Add(this.lblDirectoryLocation);
            this.Controls.Add(this.txtBoxDirectoryLocation);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtBoxDirectoryName);
            this.Controls.Add(this.btnCreateDirectories);
            this.Name = "Form1";
            this.Text = "Create College Directories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDirectories;
        private System.Windows.Forms.TextBox txtBoxDirectoryName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtBoxDirectoryLocation;
        private System.Windows.Forms.Label lblDirectoryLocation;
        private System.Windows.Forms.Button btnOpenDirectoryList;
        private System.Windows.Forms.Button btnReset;
    }
}

