﻿namespace Actividad13_06
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
            btnAgregar = new Button();
            btnVer = new Button();
            lsbAlumnos = new ListBox();
            btnVerOrdenado = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(12, 58);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(120, 23);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // lsbAlumnos
            // 
            lsbAlumnos.FormattingEnabled = true;
            lsbAlumnos.ItemHeight = 15;
            lsbAlumnos.Location = new Point(12, 101);
            lsbAlumnos.Name = "lsbAlumnos";
            lsbAlumnos.Size = new Size(209, 199);
            lsbAlumnos.TabIndex = 2;
            // 
            // btnVerOrdenado
            // 
            btnVerOrdenado.Location = new Point(138, 23);
            btnVerOrdenado.Name = "btnVerOrdenado";
            btnVerOrdenado.Size = new Size(83, 45);
            btnVerOrdenado.TabIndex = 3;
            btnVerOrdenado.Text = "Ver ordenado";
            btnVerOrdenado.UseVisualStyleBackColor = true;
            btnVerOrdenado.Click += btnVerOrdenado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 313);
            Controls.Add(btnVerOrdenado);
            Controls.Add(lsbAlumnos);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnVer;
        private ListBox lsbAlumnos;
        private Button btnVerOrdenado;
    }
}
