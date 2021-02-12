using System;

namespace EthernetTest
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
            this.connectButton1 = new System.Windows.Forms.Button();
            this.ethernetOn1 = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.changeDir = new System.Windows.Forms.Button();
            this.currentDir = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectButton2 = new System.Windows.Forms.Button();
            this.ethernetOn2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton1
            // 
            this.connectButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.connectButton1.FlatAppearance.BorderSize = 0;
            this.connectButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton1.Location = new System.Drawing.Point(29, 27);
            this.connectButton1.Name = "connectButton1";
            this.connectButton1.Size = new System.Drawing.Size(138, 30);
            this.connectButton1.TabIndex = 3;
            this.connectButton1.Text = "Ethernet Port 1";
            this.connectButton1.UseVisualStyleBackColor = false;
            this.connectButton1.Click += new System.EventHandler(this.connectButton1_Click);
            // 
            // ethernetOn1
            // 
            this.ethernetOn1.AutoSize = true;
            this.ethernetOn1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethernetOn1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ethernetOn1.Location = new System.Drawing.Point(30, 75);
            this.ethernetOn1.Name = "ethernetOn1";
            this.ethernetOn1.Size = new System.Drawing.Size(86, 18);
            this.ethernetOn1.TabIndex = 6;
            this.ethernetOn1.Text = "connected";
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLabel.ForeColor = System.Drawing.Color.White;
            this.dirLabel.Location = new System.Drawing.Point(10, 125);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(75, 18);
            this.dirLabel.TabIndex = 11;
            this.dirLabel.Text = "Directory:";
            // 
            // changeDir
            // 
            this.changeDir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDir.Location = new System.Drawing.Point(17, 255);
            this.changeDir.Name = "changeDir";
            this.changeDir.Size = new System.Drawing.Size(90, 30);
            this.changeDir.TabIndex = 12;
            this.changeDir.Text = "Assign";
            this.changeDir.UseVisualStyleBackColor = true;
            this.changeDir.Click += new System.EventHandler(this.changeDir_Click);
            // 
            // currentDir
            // 
            this.currentDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDir.AutoEllipsis = true;
            this.currentDir.AutoSize = true;
            this.currentDir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDir.ForeColor = System.Drawing.Color.White;
            this.currentDir.Location = new System.Drawing.Point(10, 150);
            this.currentDir.MaximumSize = new System.Drawing.Size(160, 80);
            this.currentDir.Name = "currentDir";
            this.currentDir.Size = new System.Drawing.Size(0, 17);
            this.currentDir.TabIndex = 13;
            this.currentDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "**TURN OFF WIFI BEFORE RUNNING**";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dirLabel);
            this.panel1.Controls.Add(this.currentDir);
            this.panel1.Controls.Add(this.changeDir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 305);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 81);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ethernet\r\nDiagnositic\r\nTool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ethernetOn2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.connectButton2);
            this.panel2.Controls.Add(this.connectButton1);
            this.panel2.Controls.Add(this.ethernetOn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 305);
            this.panel2.TabIndex = 16;
            // 
            // connectButton2
            // 
            this.connectButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.connectButton2.FlatAppearance.BorderSize = 0;
            this.connectButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton2.Location = new System.Drawing.Point(29, 125);
            this.connectButton2.Name = "connectButton2";
            this.connectButton2.Size = new System.Drawing.Size(138, 30);
            this.connectButton2.TabIndex = 9;
            this.connectButton2.Text = "Ethernet Port 2";
            this.connectButton2.UseVisualStyleBackColor = false;
            this.connectButton2.Click += new System.EventHandler(this.connectButton2_Click);
            // 
            // ethernetOn2
            // 
            this.ethernetOn2.AutoSize = true;
            this.ethernetOn2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethernetOn2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ethernetOn2.Location = new System.Drawing.Point(30, 175);
            this.ethernetOn2.Name = "ethernetOn2";
            this.ethernetOn2.Size = new System.Drawing.Size(86, 18);
            this.ethernetOn2.TabIndex = 15;
            this.ethernetOn2.Text = "connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "AQUABEAM® Ethernet Port Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button connectButton1;
        private System.Windows.Forms.Label ethernetOn1;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Button changeDir;
        private System.Windows.Forms.Label currentDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectButton2;
        private System.Windows.Forms.Label ethernetOn2;
    }
}

