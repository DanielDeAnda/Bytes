using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int p = 0;
            p = Convert.ToInt32(txtDec.Text);

            int s = 0;

            string cadena1 = "";
            string txt = "";
            char letra;
            cadena1 = Convert.ToString(p, 2);
            string nuevacadena = cadena1;
            int tamaño = cadena1.Length;
            int contador = 0;

            if (p<256)
            {
                for (int c = tamaño; c <= 7; c++)
                {
                    contador++;
                    txt += "0";
                }
                txt = txt + "" + nuevacadena;
                lblThree.Text = txt;
                string cadena2y3 = "";
                string cadena4ala6 = "";

                for (s = 0; s <= 7; s++)
                {
                    letra = txt[s];
                    if (s == 2 || s == 3)
                    {
                        cadena2y3 += txt[s];
                    }
                    else if (s >= 4 && s < 7)
                    {
                        cadena4ala6 += txt[s];
                    }

                    if (s == 0)
                    {
                        if (letra == '1')
                        {
                            label1.Text = "Good"; 
                        }
                        else if (letra == '0')
                        {
                            label2.Text = "Bad";
                        }
                    }
                    else if (s == 1)
                    {
                        if (letra == '1')
                        {
                            label1.Text = "Good";
                        }
                        else if (letra == '0')
                        {
                            label1.Text = "Bad";
                        }
                    }
                }

                
                if (cadena2y3 == "00")
                {

                    label1.Text = "Vacio";
                }
                else if (cadena2y3 == "01")
                {

                    label1.Text = "Medio";
                }
                else if (cadena2y3 == "10")
                {

                    label1.Text = "Lleno";
                }
                else if (cadena2y3 == "11")
                {

                    label1.Text = "Llenando";
                }

                
                if (cadena4ala6 == "000")
                {
                    label1.Text = "Norte";
                }
                else if (cadena4ala6 == "001")
                {
                    label1.Text = "Noreste";
                }
                else if (cadena4ala6 == "010")
                {
                    label1.Text = "Este";
                }
                else if (cadena4ala6 == "011")
                {
                    label1.Text = "Sureste";
                }
                else if (cadena4ala6 == "100")
                {
                    label1.Text = "Sur";
                }
                else if (cadena4ala6 == "101")
                {
                    label1.Text = "Suroeste";
                }
                else if (cadena4ala6 == "110")
                {
                    label1.Text = "Oeste";
                }
                else if (cadena4ala6 == "111")
                {
                    label1.Text = "Noreste";
                }
            }
            else
            {
                txtBin.Text = "Ingrese un numero menor a 256";
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime Fecha = dataFecha.Value;
            int año = Fecha.Year;
            int mes = Fecha.Month;
            int dia = Fecha.Day;

            int tamañodelaño, tamañodelmes, tamañodeldia;

            año = año - 1900;

            string año1 = Convert.ToString(año, 2);
            string mes1 = Convert.ToString(mes, 2);
            string dia1 = Convert.ToString(dia, 2);
            string FechaNumero="";

            tamañodelaño = año1.Length;
            tamañodelmes = mes1.Length;
            tamañodeldia = dia1.Length;

            int[] contador1 = new int[3];

            contador1[0] = 7 - tamañodelaño;
            contador1[1] = 4 - tamañodelmes;
            contador1[2] = 5 - tamañodeldia;

            int con = 0;
            string txt1 = "";
            string txt2 = "";
            string txt3 = "";
            

            for (int d = tamañodelaño; d < 7; d++)
            {
                con++;
                txt1 += "0";
            }

            for (int g = tamañodelmes; g < 4; g++)
            {
                con++;
                txt2 += "0";
            }

            for (int l = tamañodeldia; l < 5; l++)
            {
                con++;
                txt3 += "0";
            }
            
            año1 = txt1 + "" + año1;
            mes1 = txt2 + "" + mes1;
            dia1 = txt3 + "" + dia1;
            FechaNumero = año1 + "" + mes1 + "" + dia1;

            int n = 0;
            string binario = "";


            for (int x = FechaNumero.Length-1, y=0; x >= 0; x--, y++)
            {
                if (FechaNumero[x]=='0' || FechaNumero[x]=='1')
                {
                    n += (int)(int.Parse(FechaNumero[x].ToString()) * Math.Pow(2,y));
                }
            }
            txtFechaNum.Text = n.ToString();
            lblPrueba.Text = n+"---"+FechaNumero;
        }
    }
}
