using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using iTextSharp.text;
namespace Plexus_Audit
{
    public partial class Auditoria : Form
    {
        conexion_sql bd = new conexion_sql("mxcopnapps01", "sqlexpress", "plexus_audit");
        public string operador;
        public Auditoria()
        {
            InitializeComponent();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            gs2.Checked = true;
            contenedor.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(7588);
            
        }

        private void gs2_CheckedChanged(object sender, EventArgs e)
        {
            cambio_producto();
        }

        private void gs1_CheckedChanged(object sender, EventArgs e)
        {
            cambio_producto();
        }

        protected void cambio_producto()
        {
            if (gs2.Checked)
            {
                serie6.Enabled = false;
            }

            if (gs1.Checked)
            {
                serie6.Enabled = true;
            }

            control_contenedor();
        }







        protected void control_contenedor()
        {

            if (gs1.Checked)

            {
                if (serie1.Text != "" && serie2.Text != "" && serie3.Text != "" && serie4.Text != "" && serie5.Text != "" && serie6.Text != "")
                {
                    contenedor.Enabled = true;
                }
                else
                {
                    contenedor.Enabled = false;
                }
            }



            if (gs2.Checked)

            {
                if (serie1.Text != "" && serie2.Text != "" && serie3.Text != "" && serie4.Text != "" && serie5.Text != "")
                {
                    contenedor.Enabled = true;
                }
                else
                {
                    contenedor.Enabled = false;
                }
            }



        }

        private void serie1_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void serie4_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void serie2_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void serie5_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void serie3_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void serie6_TextChanged(object sender, EventArgs e)
        {
            control_contenedor();
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            bool contenedor_flag = false;

            if (gs2.Checked)
            { resultado = (bd.auditar_embarque("GS2", serie1.Text, serie2.Text, serie3.Text, serie4.Text, serie5.Text, "0") && repetidos_locales(serie1.Text, serie2.Text, serie3.Text, serie4.Text, serie5.Text, "0")); }
            if (gs1.Checked)
            { resultado = (bd.auditar_embarque("GS1", serie1.Text, serie2.Text, serie3.Text, serie4.Text, serie5.Text, serie6.Text) && repetidos_locales(serie1.Text, serie2.Text, serie3.Text, serie4.Text, serie5.Text, serie6.Text)); }

            if (contenedor.Text != "")
            {
                contenedor_flag = true;
            }

            if (!contenedor_flag)
            {

                MessageBox.Show("Falta el dato del contenedor.");
            }
            else { 
                if (!resultado)
            {
                    MessageBox.Show("Los numeros de serie presentan incogruencias.");
            }
            else
            {
                var ventana_auditor = new Auditar();

                if (gs2.Checked)
                {   ventana_auditor.producto = "GS2";
                    ventana_auditor.serie_a = serie1.Text;
                    ventana_auditor.serie_b = serie2.Text;
                    ventana_auditor.serie_c = serie3.Text;
                    ventana_auditor.serie_d = serie4.Text;
                    ventana_auditor.serie_e = serie5.Text;
                    ventana_auditor.contenedor = contenedor.Text;
                    ventana_auditor.operador = operador;
                }
                if (gs1.Checked)
                {
                    ventana_auditor.producto = "GS1";
                    ventana_auditor.serie_a = serie1.Text;
                    ventana_auditor.serie_b = serie2.Text;
                    ventana_auditor.serie_c = serie3.Text;
                    ventana_auditor.serie_d = serie4.Text;
                    ventana_auditor.serie_e = serie5.Text;
                    ventana_auditor.serie_f = serie6.Text;
                    ventana_auditor.contenedor = contenedor.Text;
                    ventana_auditor.operador = operador;
                }

                contenedor.Text="";
                serie1.Text = "";
                serie2.Text = "";
                serie3.Text = "";
                serie4.Text = "";
                serie5.Text = "";
                serie6.Text = "";
                gs2.Checked = true;


                ventana_auditor.Show();

                }
            }

        }

        protected Boolean repetidos_locales(string a, string b, string c, string d, string e, string f)
        {
            Boolean valor = false;

            if (a!=b && a!=c  && a != d && a != e && a != f && b != c && b != d && b != e && b != f && c != d && c != e && c != f && d != e && d != f)
            { valor = true; }

            return valor;
          }
            
    }
}

