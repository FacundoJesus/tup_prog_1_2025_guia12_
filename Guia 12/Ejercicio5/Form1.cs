namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormModal formModal = new FormModal();

        double[] vector = new double[100];
        int contador = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (formModal.ShowDialog() == DialogResult.OK)
            {
                if (formModal.tbValor.Text != "")
                {
                    double valor = Convert.ToDouble(formModal.tbValor.Text);
                    vector[contador] = valor;
                    contador++;

                    lbCantidad.Text = $"{contador}";
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }

            formModal.tbValor.Clear();
        }


        private void OrdenamientoBurbuja()
        {
            double aux;
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
            
        }

        private int BusquedaSecuencial(double seBusca)
        {
            int pos = -1;
            int i = 0;
            while (pos == -1 && i < contador)
            {
                if (vector[i] == seBusca)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }


        private int BusquedaBiseccional(double seBusca)
        {
            OrdenamientoBurbuja();
            int medio;
            int izq = 0;
            int der = contador - 1;
            int ret = -1;
            bool encontrado = false;
            do
            {
                medio = (izq + der) / 2;
                if (vector[medio] == seBusca)
                {
                    encontrado = true;
                }
                else
                if (vector[medio] < seBusca)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }
            } while (izq <= der && !encontrado);
            if (encontrado)
            {
                ret = medio;
            }
            return ret;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double buscado = Convert.ToDouble(tbBuscado.Text);

            if (rbSecuencial.Checked && tbBuscado.Text != "")
            {
                int indiceEncontrado = BusquedaSecuencial(buscado);

                if (indiceEncontrado != -1)
                {
                    tbLista.Text = $"Elemento: {vector[indiceEncontrado]} encontrado en la posición: {indiceEncontrado}";
                }
                else
                {
                    tbLista.Text = "Elemento no encontrado";
                }
            }
            else
            if (rbBiseccional.Checked && tbBuscado.Text != "")
            {
                int indiceEncontradoconBiseccion = BusquedaBiseccional(buscado);
                if (indiceEncontradoconBiseccion != -1)
                {
                    tbLista.Text = $"Elemento: {vector[indiceEncontradoconBiseccion]} encontrado en la posición: {indiceEncontradoconBiseccion}";
                }
                else
                {
                    tbLista.Text = "Elemento no encontrado";
                }
            }
            else
            {   
                MessageBox.Show("Debe elegir una opción e ingresar un elemento a buscar.");
            }
            tbBuscado.Clear();
        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            tbLista.Clear();
            if (rbBurbuja.Checked) {
                OrdenamientoBurbuja();
                for (int i = 0; i < contador; i++) {
                    tbLista.Text += $@"{vector[i],2}  ";
                }
            }
        }
    }
}

