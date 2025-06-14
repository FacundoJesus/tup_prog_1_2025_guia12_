namespace Ejercicio5
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
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            tbBuscado = new TextBox();
            rbBiseccional = new RadioButton();
            btnBuscar = new Button();
            rbSecuencial = new RadioButton();
            rbBurbuja = new RadioButton();
            rbQuickSort = new RadioButton();
            tbLista = new TextBox();
            btnMostrarListado = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            lbCantidad = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(124, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 30);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar Valor";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBuscado);
            groupBox1.Controls.Add(rbBiseccional);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(rbSecuencial);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Búsqueda";
            // 
            // tbBuscado
            // 
            tbBuscado.Location = new Point(31, 38);
            tbBuscado.Name = "tbBuscado";
            tbBuscado.Size = new Size(100, 23);
            tbBuscado.TabIndex = 2;
            // 
            // rbBiseccional
            // 
            rbBiseccional.AutoSize = true;
            rbBiseccional.Location = new Point(31, 101);
            rbBiseccional.Name = "rbBiseccional";
            rbBiseccional.Size = new Size(84, 19);
            rbBiseccional.TabIndex = 5;
            rbBiseccional.TabStop = true;
            rbBiseccional.Text = "Biseccional";
            rbBiseccional.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(176, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbSecuencial
            // 
            rbSecuencial.AutoSize = true;
            rbSecuencial.Location = new Point(31, 76);
            rbSecuencial.Name = "rbSecuencial";
            rbSecuencial.Size = new Size(81, 19);
            rbSecuencial.TabIndex = 4;
            rbSecuencial.TabStop = true;
            rbSecuencial.Text = "Secuencial";
            rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // rbBurbuja
            // 
            rbBurbuja.AutoSize = true;
            rbBurbuja.Location = new Point(9, 39);
            rbBurbuja.Name = "rbBurbuja";
            rbBurbuja.Size = new Size(66, 19);
            rbBurbuja.TabIndex = 2;
            rbBurbuja.TabStop = true;
            rbBurbuja.Text = "Burbuja";
            rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbQuickSort
            // 
            rbQuickSort.AutoSize = true;
            rbQuickSort.Enabled = false;
            rbQuickSort.Location = new Point(9, 64);
            rbQuickSort.Name = "rbQuickSort";
            rbQuickSort.Size = new Size(77, 19);
            rbQuickSort.TabIndex = 3;
            rbQuickSort.TabStop = true;
            rbQuickSort.Text = "QuickSort";
            rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // tbLista
            // 
            tbLista.Location = new Point(12, 213);
            tbLista.Multiline = true;
            tbLista.Name = "tbLista";
            tbLista.Size = new Size(170, 203);
            tbLista.TabIndex = 2;
            // 
            // btnMostrarListado
            // 
            btnMostrarListado.Location = new Point(188, 213);
            btnMostrarListado.Name = "btnMostrarListado";
            btnMostrarListado.Size = new Size(107, 42);
            btnMostrarListado.TabIndex = 4;
            btnMostrarListado.Text = "Mostrar Listado";
            btnMostrarListado.UseVisualStyleBackColor = true;
            btnMostrarListado.Click += btnMostrarListado_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbQuickSort);
            groupBox2.Controls.Add(rbBurbuja);
            groupBox2.Location = new Point(188, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(145, 137);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Ordenamiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 426);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(124, 426);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 7;
            lbCantidad.Text = "\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Listado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 453);
            Controls.Add(label2);
            Controls.Add(lbCantidad);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(btnMostrarListado);
            Controls.Add(tbLista);
            Controls.Add(groupBox1);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Número";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private RadioButton rbQuickSort;
        private RadioButton rbBurbuja;
        private TextBox tbBuscado;
        private TextBox tbLista;
        private Button btnMostrarListado;
        private GroupBox groupBox2;
        private RadioButton rbBiseccional;
        private RadioButton rbSecuencial;
        private Label label1;
        private Label lbCantidad;
        private Label label2;
    }
}
