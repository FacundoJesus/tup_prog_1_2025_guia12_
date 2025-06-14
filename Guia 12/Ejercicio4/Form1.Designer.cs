namespace Ejercicio4
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
            btnSolicitarValor = new Button();
            lsbListado = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lbCantidad = new Label();
            SuspendLayout();
            // 
            // btnSolicitarValor
            // 
            btnSolicitarValor.Location = new Point(63, 12);
            btnSolicitarValor.Name = "btnSolicitarValor";
            btnSolicitarValor.Size = new Size(172, 23);
            btnSolicitarValor.TabIndex = 0;
            btnSolicitarValor.Text = "Solicitar Valor";
            btnSolicitarValor.UseVisualStyleBackColor = true;
            btnSolicitarValor.Click += btnSolicitarValor_Click;
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(12, 66);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(277, 139);
            lsbListado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(231, 48);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 217);
            Controls.Add(lbCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsbListado);
            Controls.Add(btnSolicitarValor);
            Name = "Form1";
            Text = "Ejemplo Modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitarValor;
        private ListBox lsbListado;
        private Label label1;
        private Label label2;
        private Label lbCantidad;
    }
}
