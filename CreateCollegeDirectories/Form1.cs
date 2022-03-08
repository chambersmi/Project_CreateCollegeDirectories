using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateCollegeDirectories {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
        }

        private void btnCreateDirectories_Click(object sender, EventArgs e) {
            CreateDirectories(txtBoxDirectoryLocation.Text, txtBoxDirectoryName.Text);
        }

        private void CreateDirectories(string filepath, string filename) {
            string filePath = txtBoxDirectoryLocation.Text + "\\" + txtBoxDirectoryName.Text;
            
            try {
                if (txtBoxDirectoryName.Text.Length < 3) {
                    MessageBox.Show("You must enter a valid name");
                    return;
                }

                if (txtBoxDirectoryLocation.Text.Length < 3) {
                    MessageBox.Show("You must enter a valid directory name");
                    return;
                }

                if (!Directory.Exists(filePath)) {

                    Directory.CreateDirectory(filePath);
                    Directory.CreateDirectory(filePath + "\\" + "Course Information");

                    for (int i = 1; i < 9; i++) {
                        Directory.CreateDirectory(filePath + "\\" + "Module " + i);
                    }

                    MessageBox.Show("Directory Created!");
                    ClearAllFields();
                    return;
                } else {
                    MessageBox.Show("That directory already exists.");
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show("An error has occured.");
            }
           
        }

        private void ClearAllFields() {
            txtBoxDirectoryLocation.Text = String.Empty;
            txtBoxDirectoryName.Text = String.Empty;
        }

        private void btnOpenDirectoryList_Click(object sender, EventArgs e) {
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();
                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    txtBoxDirectoryLocation.Text = fbd.SelectedPath;                    
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            ClearAllFields();
        }
    }
}
