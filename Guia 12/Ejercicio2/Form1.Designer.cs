﻿namespace Ejercicio2
{
    partial class Form1
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
            label1 = new Label();
            tbValor = new TextBox();
            btnMostrarValor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(65, 20);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 1;
            // 
            // btnMostrarValor
            // 
            btnMostrarValor.Location = new Point(202, 20);
            btnMostrarValor.Name = "btnMostrarValor";
            btnMostrarValor.Size = new Size(99, 23);
            btnMostrarValor.TabIndex = 2;
            btnMostrarValor.Text = "Mostrar Valor";
            btnMostrarValor.UseVisualStyleBackColor = true;
            btnMostrarValor.Click += btnMostrarValor_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 101);
            Controls.Add(btnMostrarValor);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 2 - Mostrar un Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbValor;
        private Button btnMostrarValor;
    }
}
