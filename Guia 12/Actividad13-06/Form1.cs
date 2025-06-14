namespace Actividad13_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fdatos fdatos = new Fdatos();

        string[] nombres = new string[30];
        int[] dnis = new int[30];
        int contador = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1° Crear el objeto ventana.
            //Fdatos fdatos = new Fdatos();

            // 2° Mostrar ventana.
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                // 3° Leer datos.
                nombres[contador] = fdatos.tbNombre.Text;
                dnis[contador] = Convert.ToInt32(fdatos.tbDni.Text);
                contador++;

                lsbAlumnos.Items.Add($"{fdatos.tbNombre.Text}");
                //lsbAlumnos.Items.Add($"{fdatos.tbDni.Text}");

            }
            else
            {
                MessageBox.Show("Cancelado por el usuario");
            }
            fdatos.tbNombre.Clear();
            fdatos.tbDni.Clear();
            /* Dispose(): Liberar recursos - Le avisa al SO que limpie la basura, si no lo pongo, 
             * no pasa nada en codigo pero dejo mugre (informacion que ocupa espacio)
             * */
            //fdatos.Dispose();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = lsbAlumnos.SelectedIndex;

            if (indiceSeleccionado > -1 && indiceSeleccionado < contador)
            {

                fdatos.tbNombre.Text = nombres[indiceSeleccionado];
                fdatos.tbDni.Text = dnis[indiceSeleccionado].ToString("00,000,00");
                fdatos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona.");
            }

        }

        private string[] Ordenar()
        {
            string[] lista = new string[contador];
            int[] auxDni = new int [contador];
            string[] auxNombre = new string [contador];

            for (int i = 0; i < contador; i++) {
                auxDni[i] = dnis[i];
                auxNombre[i] = nombres[i];
            }

            for (int i = 0; i < contador-1; i++) {
                for (int j = i+1;  j < contador; j++) {
                    if (auxDni[i] > auxDni[j])
                    {
                        int xDni = auxDni[i];
                        auxDni[i] = auxDni[j];
                        auxDni[j] = xDni;

                        string xNombre = auxNombre[i];
                        auxNombre[i] = auxNombre[j];
                        auxNombre[j] = xNombre;
                    }
                }
            }

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = auxDni[i].ToString("00,000,000") + " " + auxNombre[i];

            }

            return lista;

        }
        private void btnVerOrdenado_Click(object sender, EventArgs e)
        {
            string[] mostrar = Ordenar();

            FVerOrdenado ventanaVerOrdenado = new FVerOrdenado();

            foreach (string linea in mostrar)
            {
                ventanaVerOrdenado.lsbVerOrdenado.Items.Add(linea);
            }
            ventanaVerOrdenado.ShowDialog();

            ventanaVerOrdenado.Dispose();
        }
    }
}
