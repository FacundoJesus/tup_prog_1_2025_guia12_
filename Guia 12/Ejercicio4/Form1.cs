using System.Drawing;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormModal formModal = new FormModal();
        int[] vector = new int[30];
        int contador = 0;
        private void btnSolicitarValor_Click(object sender, EventArgs e)
        {
            while(formModal.ShowDialog() == DialogResult.OK) {
                int valor = Convert.ToInt32(formModal.tbValor.Text);
                vector[contador] = valor;
                contador++;

                lsbListado.Items.Add(valor);
                lbCantidad.Text = $"{contador}";
                formModal.tbValor.Clear();
            }
        }
    }
}
