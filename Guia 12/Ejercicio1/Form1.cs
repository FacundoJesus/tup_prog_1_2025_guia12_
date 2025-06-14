namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void btnSolicitarValor_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(form2.tbValor.Text);

                lsbResultado.Items.Add(valor);
            }
            else
            {
                MessageBox.Show("Operacion Cancelada");
            }
            form2.tbValor.Clear();


        }
    }
}
