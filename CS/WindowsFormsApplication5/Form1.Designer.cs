﻿namespace WindowsFormsApplication5
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
            this.calcEditDescendant1 = new WindowsFormsApplication5.CalcEditDescendant();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditDescendant1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // calcEditDescendant1
            // 
            this.calcEditDescendant1.Location = new System.Drawing.Point(116, 81);
            this.calcEditDescendant1.Name = "calcEditDescendant1";
            this.calcEditDescendant1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditDescendant1.Size = new System.Drawing.Size(217, 22);
            this.calcEditDescendant1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 383);
            this.Controls.Add(this.calcEditDescendant1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.calcEditDescendant1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CalcEditDescendant calcEditDescendant1;

    }
}

