namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        int contador = 0;
        private void btnSolicitarValor_Click(object sender, EventArgs e)
        {
            while (form2.ShowDialog() == DialogResult.OK) {

                if (form2.tbValor.Text != "") { 
                    int valor = Convert.ToInt32(form2.tbValor.Text);
                    lsbListado.Items.Add(valor);
                    contador++;
                    form2.tbValor.Clear();

                    lbCantidad.Text = $"{contador}";
                }
            }
            
        }
    }
}
