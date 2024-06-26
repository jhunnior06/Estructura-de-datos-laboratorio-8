namespace Laboratorio_8._1
{
    public partial class Form1 : Form
    {
        private List<int> lista = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumero.Text, out int numero))
            {
                lista.Add(numero);
                txtLista1.AppendText(numero.ToString() + Environment.NewLine);
                txtAgregarNumero.Clear();
                txtAgregarNumero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido.");
            }
        }

        private void btnBuscarPrimos_Click(object sender, EventArgs e)
        {
            var lista2 = new List<int>();

            foreach (var item in lista)
            {
                if (EsPrimo(item))
                {
                    lista2.Add(item);
                }
            }

            txtLista2.Clear();
            foreach (var item in lista2)
            {
                txtLista2.AppendText(item.ToString() + Environment.NewLine);
            }
        }
    }
}


