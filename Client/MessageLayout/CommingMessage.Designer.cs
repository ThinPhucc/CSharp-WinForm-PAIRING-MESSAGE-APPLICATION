﻿namespace Client
{
    partial class CommingMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageIn
            // 
            this.MessageIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MessageIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageIn.ForeColor = System.Drawing.Color.Black;
            this.MessageIn.Location = new System.Drawing.Point(0, 0);
            this.MessageIn.Name = "MessageIn";
            this.MessageIn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MessageIn.Size = new System.Drawing.Size(248, 21);
            this.MessageIn.TabIndex = 0;
            this.MessageIn.Text = "label1";
            // 
            // CommingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MessageIn);
            this.Name = "CommingMessage";
            this.Size = new System.Drawing.Size(400, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageIn;
    }
}
