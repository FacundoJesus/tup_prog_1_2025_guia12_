﻿namespace Ejercicio1
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
            btnSolicitarValor = new Button();
            lsbResultado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Resultado:";
            // 
            // btnSolicitarValor
            // 
            btnSolicitarValor.Location = new Point(93, 12);
            btnSolicitarValor.Name = "btnSolicitarValor";
            btnSolicitarValor.Size = new Size(107, 23);
            btnSolicitarValor.TabIndex = 1;
            btnSolicitarValor.Text = "Solicitar Valor";
            btnSolicitarValor.UseVisualStyleBackColor = true;
            btnSolicitarValor.Click += btnSolicitarValor_Click;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(93, 52);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(120, 64);
            lsbResultado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 129);
            Controls.Add(lsbResultado);
            Controls.Add(btnSolicitarValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejercicio 1 - Solicitar Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSolicitarValor;
        private ListBox lsbResultado;
    }
}
