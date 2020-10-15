using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;

namespace Plexus_Audit
{
    public partial class Auditar : Form
    {
        public string producto;
        public string serie_a;
        public string serie_b;
        public string serie_c;
        public string serie_d;
        public string serie_e;
        public string serie_f;
        public string contenedor;
        public string operador;
        public bool flash ;
        conexion_sql bd = new conexion_sql("mxcopnapps01", "sqlexpress", "plexus_audit");

        public Auditar()
        {
            InitializeComponent();
        }

        private void Auditar_Load(object sender, EventArgs e)
        {
            flash = true;
            panel1.BackColor = System.Drawing.Color.Green;
            tmr_flash_auditoria.Interval = 333;
            tmr_flash_auditoria.Enabled = true;
            


            lblCapturo.Text = operador;
            lblContenedor.Text = contenedor;
            lblProducto.Text = producto ;
            if (producto == "GS2")
            {
                lblDescripcion.Text = "09-0286";
                lblSerie6.Enabled = false;
                
            } else
            {
                lblDescripcion.Text = "09-0269";
                lblSerie6.Enabled = true;
                lblSerie6.Text = serie_f;
            }

            lblContenedor.Text = contenedor;
            lblSerie1.Text = serie_a;
            lblSerie2.Text = serie_b;
            lblSerie3.Text = serie_c;
            lblSerie4.Text = serie_d;
            lblSerie5.Text = serie_e;

        }


                private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (serie_f == null)
                { serie_f = "N/A"; }

                bd.agregar_auditoria(contenedor, producto, operador, textBox1.Text, serie_a, serie_b, serie_c, serie_d, serie_e, serie_f);

                generar_pdf(serie_a, serie_b, serie_c, serie_d, serie_e, serie_f, producto, "34" , textBox1.Text);

                

                ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetFullPath(@"%USERPROFILE%\Documents\test.pdf").Replace(@"\\",@"\"));
                Process.Start(startInfo);
                this.Close();

            }
        }
        public void generar_pdf(string serie1, string serie2, string serie3, string serie4, string serie5, string serie6, string producto, string numauditoria,string  auditor)
        {
            string descripcionlncr = "";
            string qty = "";
            string descripcionplexus = "";

            if (producto == "GS2")
            {
                descripcionlncr = "09-0286";
                qty = "5";
                descripcionplexus = "283 - 10570 - 524 Rev. 3 - 01";
            }
                else
            {
                descripcionlncr = "09-0269";
                qty = "6";
                descripcionplexus = "43000-524    3-04";
            }
            
           
            string hoy = DateTime.Today.ToString("d");

            var pathWithEnv = @"%USERPROFILE%\Documents\test.pdf";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            /* se generea un objeto file stream con el nombre del archivo*/
            iTextSharp.text.Rectangle tamano_hoja = new iTextSharp.text.Rectangle(iTextSharp.text.PageSize.LETTER);
            /* se genera un objeto rectangle con la medida y orientacion del papel*/
            iTextSharp.text.Document doc = new iTextSharp.text.Document(tamano_hoja);
            /*se genera el objeto Document y se pone el tamano del documento en el contructor de Document*/
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
            /* se crea el objeto writer donde se liga el documento con el filestream*/

            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            String strFilePath = Path.Combine(strAppPath, "Resources");
            String strFullFilename = Path.Combine(strFilePath, "logo_header.png");
            var logo = iTextSharp.text.Image.GetInstance(strFullFilename);
            logo.ScaleToFit(180f, 220f);
            logo.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
            /* aqui se vacia el logo en el objeto logo*/

            iTextSharp.text.pdf.BaseFont bfHelvetica = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.HELVETICA, iTextSharp.text.pdf.BaseFont.CP1252, false);

            iTextSharp.text.Font Helvetica_titulo = new iTextSharp.text.Font(bfHelvetica, 16, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Font Helvetica_regular = new iTextSharp.text.Font(bfHelvetica, 14, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Paragraph titulo = new iTextSharp.text.Paragraph();
            titulo.Add(new Chunk(logo, 0, 0));
            titulo.Add(new Phrase("         CERTIFICATE OF COMPLIANCE", Helvetica_titulo));




            /*Codigo del titulo*/

            Paragraph linea = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(5F, 100.0F, BaseColor.RED, Element.ALIGN_LEFT, 1)));

            iTextSharp.text.Paragraph datos_generales1 = new iTextSharp.text.Paragraph("Customer: PLEXUS                                                 Quantity: "+qty, Helvetica_regular);
            iTextSharp.text.Paragraph datos_generales2 = new iTextSharp.text.Paragraph("Verification Date: "+ hoy  +  "                                  Customer PO#: ", Helvetica_regular);
            iTextSharp.text.Paragraph datos_generales3 = new iTextSharp.text.Paragraph("Customer PN and REV: " + descripcionplexus , Helvetica_regular);
            iTextSharp.text.Paragraph datos_generales4 = new iTextSharp.text.Paragraph("Part Description:  COLD PLATE", Helvetica_regular);
            iTextSharp.text.Paragraph datos_generales5 = new iTextSharp.text.Paragraph("Lancer PN and Rev. : " + producto + " " + descripcionlncr + " 001", Helvetica_regular);

            iTextSharp.text.Paragraph componentes = new iTextSharp.text.Paragraph("Components / Assemblies", Helvetica_regular);
            iTextSharp.text.Paragraph componentes2 = new iTextSharp.text.Paragraph("LANCER Corporation – hereby certifies that all articles furnished in this lot are in compliance with the requirements, specifications and drawings applicable to this assembly.This lot of assemblies is hereby released for shipment.", Helvetica_regular);


            iTextSharp.text.Paragraph materiales = new iTextSharp.text.Paragraph("Materials", Helvetica_regular);
            iTextSharp.text.Paragraph materiales2 = new iTextSharp.text.Paragraph("LANCER Corporation – hereby certifies that all materials used in the components / assemblies are verified by Lancer. They meet customer registry requirements and the material certificates of compliance are maintained by Lancer. They can be made available by individual request. These are retained for duration of 3-years as per our Control of Records (QSP 4.2.4).", Helvetica_regular);

            iTextSharp.text.Paragraph approved = new iTextSharp.text.Paragraph("Approved by LANCER or LancerMEX - Quality Assurance Authorization", Helvetica_regular);
            iTextSharp.text.Paragraph quality_rep = new iTextSharp.text.Paragraph("Quality Representative Number: " + auditor, Helvetica_regular);
            iTextSharp.text.Paragraph fecha = new iTextSharp.text.Paragraph("Date: "+hoy, Helvetica_regular);

            iTextSharp.text.pdf.PdfPTable seriales = new iTextSharp.text.pdf.PdfPTable(3);

            iTextSharp.text.Paragraph espacio = new iTextSharp.text.Paragraph("If Applicable (Serial Numbers Associated to C of C).", Helvetica_regular);

            seriales.SpacingBefore = 10f;
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie1, Helvetica_regular)));
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie2, Helvetica_regular)));
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie3, Helvetica_regular)));
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie4, Helvetica_regular)));
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie5, Helvetica_regular)));
            seriales.AddCell(new iTextSharp.text.pdf.PdfPCell(new Phrase(serie6, Helvetica_regular)));


           
            doc.Open();
            
            doc.Add(titulo);
            doc.Add(linea);
            doc.Add(datos_generales1);
            doc.Add(Chunk.NEWLINE);
            doc.Add(datos_generales2);
            doc.Add(Chunk.NEWLINE);
            doc.Add(datos_generales3);
            doc.Add(Chunk.NEWLINE);
            doc.Add(datos_generales4);
            doc.Add(Chunk.NEWLINE);
            doc.Add(datos_generales5);
            doc.Add(linea);
            doc.Add(componentes);
            doc.Add(Chunk.NEWLINE);
            doc.Add(componentes2);
            doc.Add(linea);
            doc.Add(materiales);
            doc.Add(Chunk.NEWLINE);
            doc.Add(materiales2);
            doc.Add(linea);
            doc.Add(approved);
            doc.Add(Chunk.NEWLINE);
            doc.Add(quality_rep);
            doc.Add(Chunk.NEWLINE);
            doc.Add(fecha);
            doc.Add(linea);
            doc.Add(espacio);
            doc.Add(seriales);



            doc.AddTitle("LancerWorldWide Certificate of Compliance");
            doc.AddSubject("Certificate of Compliance");
            doc.AddKeywords("Certificate, Compliance, Lancerworldwide");
            doc.AddCreator("LancerWorldWide Plexus Audit");
            doc.AddAuthor("LancerWorldWide");
            doc.AddHeader("Plexus", "Certificate");
            doc.Close();
        }

        private void tmr_flash_auditoria_Tick(object sender, EventArgs e)
        {
            if (flash)
            {
                flash = false;
                panel1.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                flash = true;
                panel1.BackColor = System.Drawing.Color.Green;
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
