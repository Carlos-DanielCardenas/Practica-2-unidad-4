namespace Practica_2__unidad_4
{
    public partial class Form1 : Form
    {
        // `Declaracion de variable de cantidad
        int cantidadHamburguesas;
        int cantidadHotDogs;
        int cantidadSandwich;
        int cantidadTe;
        int cantidadRefrescos;
        int cantidadPapas;

        double totalVta;
        double costoHamburguesa;
        double costoHotDog;
        double costoSandwich;
        double costoTe;
        double costoRefresco;
        double costoPapas;

        //`Ìnicializar las variables con los precios de los productos
        double Hamburguesa = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double PapasFritas = 4.5;
        double Refresco = 4;
        double te = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.1 de comida
            textBox1.Text = " ";
            if (radioButton1.Checked == true)
            {
                cantidadHamburguesas = 1;
                cantidadRefrescos = 1;
                cantidadPapas = 1;
                cantidadHotDogs = 0;
                cantidadSandwich = 0;
                cantidadTe = 0;
                //Inicializar valores
                textBox2.Text = cantidadHamburguesas.ToString();
                textBox6.Text = cantidadRefrescos.ToString();
                textBox7.Text = cantidadPapas.ToString();

                //Activar las cajas  de texto del paquete
                textBox2.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;

                //`Desactivar las otras cajas 
                textBox3.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                //limpiar las cajas de texto
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.2 de comida
            textBox1.Text = "";
            if (radioButton2.Checked == true)
            {
                cantidadRefrescos = 1;
                cantidadPapas = 1;
                cantidadHotDogs = 1;
                cantidadSandwich = 0;

                //inizializar  valores
                textBox4.Text = cantidadHamburguesas.ToString();
                textBox6.Text = cantidadRefrescos.ToString();
                textBox7.Text = cantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                textBox4.Enabled = true;
                textBox7.Enabled = true;
                textBox6.Enabled = true;

                //`Desactivar las otras cajas
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                textBox2.Enabled = false;

                //`Limpiar las cajas  de texto
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (radioButton3.Checked == true)
            {
                cantidadHamburguesas = 0;
                cantidadRefrescos = 1;
                cantidadHotDogs = 0;
                cantidadPapas = 1;
                cantidadSandwich = 1;
                cantidadTe = 0;
                //Inicializar valores
                textBox4.Text = cantidadSandwich.ToString();
                textBox6.Text = cantidadRefrescos.ToString();
                textBox7.Text = cantidadPapas.ToString();

                //Activar las cajas de texto del paquete
                textBox4.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;

                //`Desactivar las otras cajas
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                //`Limpiar las cajas de texto
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";


            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Opcion otro pedido
            textBox1.Text = "";
            if (radioButton4.Checked == true)
            {
                //Habilitar todas las entradas
                textBox2.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                /*
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";*/

                double cantidadHamburguesas = int.Parse(textBox2.Text);
                double cantidadHotDogs = int.Parse(textBox3.Text);
                double cantidadSandwich = int.Parse(textBox4.Text);
                double cantidadTe = int.Parse(textBox5.Text);
                double cantidadRefresco = int.Parse(textBox6.Text);
                double cantidadPapas = int.Parse(textBox7.Text);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //`Multiplicando la cantidad por el precio y sumando el total 
            costoHamburguesa = (cantidadHamburguesas * Hamburguesa);
            costoHotDog = (cantidadHotDogs * HotDog);
            costoSandwich = (cantidadSandwich * Sandwich);
            costoTe = (cantidadTe * te);
            costoRefresco = (cantidadRefrescos * Refresco);
            costoPapas = (cantidadPapas * PapasFritas);
            totalVta = costoHamburguesa + costoHotDog + costoSandwich + costoTe + costoRefresco + costoPapas;
            textBox1.Text = totalVta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}