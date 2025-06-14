namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void btnMostrarValor_Click_1(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbValor.Text);

            form2.lbMostrarValor.Text = valor.ToString();

            if (form2.ShowDialog() == DialogResult.OK) ;
            else
            {
                MessageBox.Show("Cancelada por el usuario.");
            }

            tbValor.Clear();

        }
    }
}
