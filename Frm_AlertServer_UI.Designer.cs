﻿namespace FYP_Alert_Server
{
    partial class Frm_AlertServer_UI
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
            btnTest1 = new Button();
            btnThreadStart_CommsAnchor = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnTest1
            // 
            btnTest1.Location = new Point(35, 38);
            btnTest1.Name = "btnTest1";
            btnTest1.Size = new Size(75, 23);
            btnTest1.TabIndex = 0;
            btnTest1.Text = "Test1";
            btnTest1.UseVisualStyleBackColor = true;
            btnTest1.Click += btnTest1_Click;
            // 
            // btnThreadStart_CommsAnchor
            // 
            btnThreadStart_CommsAnchor.Location = new Point(35, 387);
            btnThreadStart_CommsAnchor.Name = "btnThreadStart_CommsAnchor";
            btnThreadStart_CommsAnchor.Size = new Size(294, 23);
            btnThreadStart_CommsAnchor.TabIndex = 1;
            btnThreadStart_CommsAnchor.Text = "Start Anchor Comms Thread";
            btnThreadStart_CommsAnchor.UseVisualStyleBackColor = true;
            btnThreadStart_CommsAnchor.Click += btnThreadStart_CommsAnchor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(219, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "MQTT";
            button1.UseVisualStyleBackColor = true;
            // 
            // Frm_AlertServer_UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 482);
            Controls.Add(button1);
            Controls.Add(btnThreadStart_CommsAnchor);
            Controls.Add(btnTest1);
            Name = "Frm_AlertServer_UI";
            Text = "Alert Server UI";
            FormClosing += Frm_AlertServer_UI_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest1;
        private Button btnThreadStart_CommsAnchor;
        private Button button1;
    }
}