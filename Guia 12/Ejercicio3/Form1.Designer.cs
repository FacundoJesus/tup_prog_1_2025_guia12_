namespace Ejercicio3
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
            label2 = new Label();
            lbCantidad = new Label();
            btnSolicitarValor = new Button();
            lsbListado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 64);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(291, 64);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 2;
            lbCantidad.Text = "\r\n";
            // 
            // btnSolicitarValor
            // 
            btnSolicitarValor.Location = new Point(119, 12);
            btnSolicitarValor.Name = "btnSolicitarValor";
            btnSolicitarValor.Size = new Size(116, 39);
            btnSolicitarValor.TabIndex = 3;
            btnSolicitarValor.Text = "Solicitar Valor";
            btnSolicitarValor.UseVisualStyleBackColor = true;
            btnSolicitarValor.Click += btnSolicitarValor_Click;
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(12, 82);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(337, 139);
            lsbListado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 235);
            Controls.Add(lsbListado);
            Controls.Add(btnSolicitarValor);
            Controls.Add(lbCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 3 - Solicitar una cantidad de valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbCantidad;
        private Button btnSolicitarValor;
        private ListBox lsbListado;
    }
}
