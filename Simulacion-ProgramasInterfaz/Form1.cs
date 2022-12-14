using AlgoritmoLineal_Simulacion;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
namespace Simulacion_ProgramasInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        GeneradorVariablesAleatorias generador1 = new GeneradorVariablesAleatorias();
        GeneradorVariablesAleatorias generador2 = new GeneradorVariablesAleatorias();

        private void button1_Click(object sender, EventArgs e)
        {
            int corridas = int.Parse(txt_numCorridas.Text);
            int landa;

            if (box_distribucion.Text.Equals("Normal"))
            {
                
                generador1.GeneradorVariablesNormal(corridas);
                generador1.TablaFrecuencia();
                string cadena = generador1.cadena;
                string cadenaVar = generador1.cadenaVar;
                txt_impresion.Text = cadena.Replace("\n", Environment.NewLine);
                txt_variables.Text = cadenaVar.Replace("\n", Environment.NewLine);
            }
            else
            {
                
                landa = int.Parse(txt_landa.Text);
                generador2.GeneradorVariablesPoisson(landa,corridas);
                generador2.PruebaChiCuadradaPoisson();
                string cadena = generador2.cadena;
                string cadenaVar = generador2.cadenaVar;
                txt_impresion.Text = cadena.Replace("\n", Environment.NewLine);
                txt_variables.Text = cadenaVar.Replace("\n", Environment.NewLine);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_poisson_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_landa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}