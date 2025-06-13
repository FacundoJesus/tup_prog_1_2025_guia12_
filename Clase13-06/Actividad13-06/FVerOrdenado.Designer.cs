namespace Actividad13_06
{
    partial class FVerOrdenado
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
            lsbVerOrdenado = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbVerOrdenado
            // 
            lsbVerOrdenado.FormattingEnabled = true;
            lsbVerOrdenado.ItemHeight = 15;
            lsbVerOrdenado.Location = new Point(12, 12);
            lsbVerOrdenado.Name = "lsbVerOrdenado";
            lsbVerOrdenado.Size = new Size(338, 364);
            lsbVerOrdenado.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(139, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FVerOrdenado
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 450);
            Controls.Add(button1);
            Controls.Add(lsbVerOrdenado);
            Name = "FVerOrdenado";
            Text = "Lista Ordenada";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public ListBox lsbVerOrdenado;
    }
}