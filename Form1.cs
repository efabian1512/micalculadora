using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaCalculadoradeEdwin
{
    public enum operaciones { suma, resta, producto, division, porcentaje, nada }


    public partial class Form1 : Form
    {
        operaciones operacion = operaciones.nada;
        public List<double> lista = new List<double>();
        public List<double> lista2 = new List<double>();
        public List<double> lista3 = new List<double>();
        double primervalor;
        operaciones opporcentaje;
        public double resultado = 0;










        public Form1()
        {
            InitializeComponent();
            textBox1.Text = 0.ToString();
            //prueba



        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            this.ActiveControl = null;
        }










        private void uno_Click(object sender, EventArgs e)
        {
            double valor = 1;
            Boton(valor);
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacion == operaciones.suma)
            {               
               
                    //operacion = operaciones.nada
                    Sumando();

                }
            
            if (operacion == operaciones.resta)
            {
                Restando();

                }

            if (operacion == operaciones.producto)
            {
                Multiplicando();
            }
            if (operacion == operaciones.division)
            {
                Dividiendo();
            }
            if (operacion == operaciones.porcentaje)
            {
                if (opporcentaje == operaciones.resta)
                {
                    double total = primervalor - resultado;
                    resultado = total;
                    textBox1.Text = resultado.ToString();
                    //opporcentaje = operaciones.nada;


                }
                if (opporcentaje == operaciones.suma)
                {
                    double total = primervalor + resultado;
                    resultado = total;
                    textBox1.Text = resultado.ToString();
                    //opporcentaje =operaciones.nada;
                }
                if (opporcentaje == operaciones.producto)
                {
                    double total = primervalor * resultado;
                    resultado = total;
                    textBox1.Text = resultado.ToString();
                    //opporcentaje = operaciones.nada;
                }
                if (opporcentaje == operaciones.division)
                {
                    double total = primervalor / resultado;
                    resultado = total;
                    textBox1.Text = resultado.ToString();
                    //opporcentaje = operaciones.nada;
                }

            }


            this.ActiveControl = null;
                textBox2.Text = "";
        }
            

        private void sumar_Click(object sender, EventArgs e)
        {
            //if (lista3.Count == 0) {
            if (textBox1.Text == resultado.ToString())
            {
                operacion = operaciones.suma;
                //textBox2.Text = textBox2.Text +" + "+ textBox1.Text;
                textBox2.Text = textBox1.Text + " + ";



            }
            else
            {
                //if (lista3.Count == 0) { 
                operacion = operaciones.suma;
                if (textBox2.Text == "")
                {
                    primervalor = (double.Parse(textBox1.Text));
                    //lista3.Add(primervalor);
                   

               
                
                textBox2.Text = textBox1.Text;
                }else
                {
                    if (textBox2.Text == resultado.ToString() + " + ")
                    {
                        textBox2.Text = textBox2.Text + textBox1.Text;
                        Sumando();
                        //igual.PerformClick();
                        primervalor = resultado;

                    }
                    else { 
                        
                    textBox2.Text= textBox2.Text+" + " +textBox1.Text;
                    Sumando();
                    //igual.PerformClick();
                    primervalor = resultado;
                    }


                }
                //}

            }
           // }/*else
            //{
                /*double suma = 0;
                for(int i = 0; i < lista3.Count; i++)
                {
                    if (i == lista.Count - 1)
                    {
                        suma = suma + lista[i];
                    }

                }
                /resultado = suma;
                textBox1.Text = resultado.ToString();*/
            //}
            
            this.ActiveControl = null;

        }

        private void dos_Click(object sender, EventArgs e)
        {
            double valor = 2;
            Boton(valor);
           
        }

        private void clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = 0.ToString();
            resultado = 0;
            operacion = operaciones.nada;
            opporcentaje = operaciones.nada;
            primervalor = 0;
            lista.Clear();
            lista2.Clear();

            this.ActiveControl = null;

        }

        private void tres_Click(object sender, EventArgs e)
        {
            double valor = 3;
            Boton(valor);
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            double valor = 4;
            Boton(valor);
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            double valor = 5;
            Boton(valor);
            
        }

        private void seis_Click(object sender, EventArgs e)
        {
            double valor = 6;
            Boton(valor);
        }

        private void siete_Click(object sender, EventArgs e)
        {
            double valor = 7;
            Boton(valor);
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            double valor = 8;
            Boton(valor);
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            double valor = 9;

            Boton(valor);

        }

        private void cero_Click(object sender, EventArgs e)
        {
            double valor = 0;
            Boton(valor);
        }

        private void restar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != 0.ToString())
            {
                if (textBox1.Text == resultado.ToString())
                {
                    operacion = operaciones.resta;
                    textBox2.Text = textBox1.Text + " - ";

                    /* if (textBox2.Text == "")
                     {


                     }
                     else
                     {

                     }*/

                }
                else
                    /* {
                         operacion = operaciones.resta;
                         primervalor = (double.Parse(textBox1.Text));
                     }*/
                    operacion = operaciones.resta;
                if (textBox2.Text == "")
                {
                    primervalor = (double.Parse(textBox1.Text));
                    //lista3.Add(primervalor);



                    textBox2.Text = textBox1.Text;
                }
                else
                {
                    if(textBox2.Text== resultado.ToString() + " - ")
                    {
                        //textBox2.Text = textBox2.Text + textBox1.Text;
                        Restando();
                        //igual.PerformClick();
                        primervalor = resultado;
                    }else if(textBox2.Text!= resultado.ToString() + " - ") {

                    textBox2.Text = textBox2.Text + " - " + textBox1.Text;
                    Restando();
                    //igual.PerformClick();
                    primervalor = resultado;
                    }


                }

            }
            else
            {
                textBox1.Text = "-";
            }
            this.ActiveControl = null;
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == resultado.ToString())
            {
                operacion = operaciones.producto;
                textBox2.Text = textBox1.Text + " x ";

            }
            else
                /*{
                    operacion = operaciones.producto;
                    primervalor = (double.Parse(textBox1.Text));
                }*/
                operacion = operaciones.producto;
            if (textBox2.Text == "")
            {
                primervalor = (double.Parse(textBox1.Text));
                //lista3.Add(primervalor);




                textBox2.Text = textBox1.Text;
            }
            else
            {
                if (textBox2.Text == resultado.ToString() + " x ")
                {
                    textBox2.Text = textBox2.Text + textBox1.Text;
                    Multiplicando();
                    //igual.PerformClick();
                    primervalor = resultado;

                }
                else
                {

                    textBox2.Text = textBox2.Text + " x " + textBox1.Text;
                    Multiplicando();
                    //igual.PerformClick();
                    primervalor = resultado;
                }


            }
            //}

        
            this.ActiveControl = null;

        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == resultado.ToString())
            {
                operacion = operaciones.division;

            }
            else
            {



                operacion = operaciones.division;
                primervalor = (double.Parse(textBox1.Text));

            }
            this.ActiveControl = null;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

      

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {

                sumar.PerformClick();


            }
            if (e.KeyCode == Keys.Subtract)
            {

                restar.PerformClick();

            }
            if (e.KeyCode == Keys.Multiply)
            {

                multiplicar.PerformClick();

            }
            if (e.KeyCode == Keys.Divide)
            {

                dividir.PerformClick();


            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                //uno.Focus();

                uno.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                // dos.Focus();

                dos.PerformClick();


            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                // tres.Focus();

                tres.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                //cuatro.Focus();

                cuatro.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                //cinco.Focus();

                cinco.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                // seis.Focus();

                seis.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                //siete.Focus();

                siete.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                //ocho.Focus();

                ocho.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                //nueve.Focus();

                nueve.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                //cero.Focus();

                cero.PerformClick();

            }
            if (e.KeyCode == Keys.Enter)
            {
                //igual.Focus();

                igual.PerformClick();

            }

            if (e.KeyCode == Keys.Back)
            {
                if (textBox1.Text != resultado.ToString())
                {
                    string cadena = textBox1.Text;

                    if (cadena.Length > 1)
                    {

                        textBox1.Text = cadena.Remove(cadena.Length - 1);


                    }
                    else
                    {
                        textBox1.Text = 0.ToString();
                    }

                }
                else
                {
                    e.Handled = true;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                clear.PerformClick();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                punto.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                clearerror.PerformClick();
            }

        }

       

        private void punto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == resultado.ToString())
            {
                textBox1.Text = 0.ToString() + ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
            this.ActiveControl = null;

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != resultado.ToString())
            {
                string cadena = textBox1.Text;

                if (cadena.Length > 1)
                {

                    textBox1.Text = cadena.Remove(cadena.Length - 1);


                }
                else
                {
                    textBox1.Text = 0.ToString();
                }

            }
            this.ActiveControl = null;

        }

        private void raizcuadrada_Click(object sender, EventArgs e)
        {
            double raiz = Math.Sqrt(double.Parse(textBox1.Text));
            resultado = raiz;
            textBox1.Text = resultado.ToString();
            this.ActiveControl = null;

        }

        private void alcuadrado_Click(object sender, EventArgs e)
        {
            double elevado = Math.Pow(double.Parse(textBox1.Text), 2);
            resultado = elevado;
            textBox1.Text = resultado.ToString();
            this.ActiveControl = null;


        }

        private void entreequis_Click(object sender, EventArgs e)
        {
            double dividirx = 1 / (double.Parse(textBox1.Text));
            resultado = dividirx;
            textBox1.Text = resultado.ToString();
            this.ActiveControl = null;


        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            if (operacion != operaciones.nada)
            {
                if (operacion == operaciones.resta)
                {

                    operacion = operaciones.porcentaje;
                    opporcentaje = operaciones.resta;
                    double porcentaje = (double.Parse(textBox1.Text) / 100 * primervalor);
                    resultado = porcentaje;
                    textBox1.Text = resultado.ToString();
                }
                if (operacion == operaciones.producto)
                {

                    operacion = operaciones.porcentaje;
                    opporcentaje = operaciones.producto;
                    double porcentaje = (double.Parse(textBox1.Text) / 100 * primervalor);
                    resultado = porcentaje;
                    textBox1.Text = resultado.ToString();
                }
                if (operacion == operaciones.suma)
                {

                    operacion = operaciones.porcentaje;
                    opporcentaje = operaciones.suma;
                    double porcentaje = (double.Parse(textBox1.Text) / 100 * primervalor);
                    resultado = porcentaje;
                    textBox1.Text = resultado.ToString();
                }
                if (operacion == operaciones.division)
                {

                    operacion = operaciones.porcentaje;
                    opporcentaje = operaciones.division;
                    double porcentaje = (double.Parse(textBox1.Text) / 100 * primervalor);
                    resultado = porcentaje;
                    textBox1.Text = resultado.ToString();
                }
                
            }
            else
            {
                textBox1.Text = 0.ToString();
            }
            this.ActiveControl = null;
        }

        private void clearerror_Click(object sender, EventArgs e)
        {
            if (operacion != operaciones.nada)

            {
                if (textBox1.Text == resultado.ToString())
                {

                    clear.PerformClick();
                }
                else
                {
                    lista2.Clear();
                    textBox1.Text = 0.ToString();

                }

            }
            else
            {

                clear.PerformClick();


            }
            this.ActiveControl = null;
        }

        private void masmenos_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) >= 0) { 
            textBox1.Text = "-" + textBox1.Text;
            }else //if(textBox1.Text=="-"+textBox1.Text)
            {

               
                textBox1.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();

            }

        }
        public void Sumando()
        {
            if (operacion == operaciones.suma)
            {
                /*string cadena = textBox2.Text;
               
                if (cadena.Length > 2)
                {
                    for(int i = 0; i < cadena.Length; i++)
                    {
                        lista3.Add(double.Parse(char.Tcadena.ElementAt(i)); 
                    }
                }*/

                if (resultado != 0)
                {
                    double suma = 0;
                    suma = resultado + int.Parse(textBox1.Text);
                    resultado = suma;
                    textBox1.Text = resultado.ToString();
                    lista2.Clear();
                    //operacion = operaciones.nada;

                }
                else
                {
                    lista.Add(primervalor);
                    lista.Add(double.Parse(textBox1.Text));
                    double suma = 0;
                    for (int i = 0; i < lista.Count; i++)
                    {

                        suma = suma + lista[i];
                    }
                    resultado = suma;
                    textBox1.Text = resultado.ToString();
                    lista2.Clear();
                    //operacion = operaciones.nada;

                }
            }
        }
        public void Restando()
        {
            lista.Add(primervalor);
            lista.Add(int.Parse(textBox1.Text));
            if (resultado != 0)
            {
                double resta = 0;
                resta = resultado - int.Parse(textBox1.Text);
                resultado = resta;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                //operacion = operaciones.nada;

            }
            else
            {
                double resta = lista[0] - lista[1];

                resultado = resta;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                //operacion = operaciones.nada;

            }
        
           
            
            
        }
        public void Multiplicando()
        {
            lista.Add(primervalor);
            lista.Add(int.Parse(textBox1.Text));
            if (resultado != 0)
            {
                double producto = 0;
                producto = resultado * int.Parse(textBox1.Text);
                resultado = producto;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                operacion = operaciones.nada;

            }
            else
            {
                double producto = 1;
                for (int i = 0; i < lista.Count; i++)
                {

                    producto = producto * lista[i];
                }
                resultado = producto;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                operacion = operaciones.nada;

            }

        }
        public void Dividiendo()
        {
            lista.Add(primervalor);
            lista.Add(int.Parse(textBox1.Text));
            if (resultado != 0)
            {
                double cociente = 0;
                cociente = resultado / int.Parse(textBox1.Text);
                resultado = cociente;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                operacion = operaciones.nada;

            }
            else
            {
                double cociente;
                //for (int i = 0; i < lista.Count; i++)
                //{

                cociente = lista[0] / lista[1];
                //}
                resultado = cociente;
                textBox1.Text = resultado.ToString();
                lista2.Clear();
                operacion = operaciones.nada;

            }

        }
        public void Boton(double valor)
        {
            if (operacion == operaciones.nada)
            {
                if (textBox1.Text == 0.ToString())
                {
                    textBox1.Text = valor.ToString();
                }
                else if (textBox1.Text == resultado.ToString())
                {
                    textBox1.Text = valor.ToString();
                    resultado = 0;
                    lista.Clear();
                    operacion = operaciones.nada;
                }
                else
                {
                    textBox1.Text = textBox1.Text + valor.ToString();
                }

            }
            else
            {
                if (textBox1.Text != 0.ToString())
                {
                    if (lista2.Count() == 0)
                    {

                        textBox1.Text = valor.ToString();
                        lista2.Add(valor);
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + valor.ToString();
                    }

                }
                else
                {
                    textBox1.Text = valor.ToString();

                }
            }
            this.ActiveControl = null;
        }

    

        private void historial_Click(object sender, EventArgs e)
        {
            Application.Run(new Form2());
        }
    }


}

