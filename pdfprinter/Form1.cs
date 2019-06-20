using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using Spire.Pdf;
//using Spire.Pdf.Graphics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace pdfprinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(textBox_pdffolder_orig.Text) == false)
            {
                MessageBox.Show("nem létezik a forrásmappa (?)","",MessageBoxButtons.OK,MessageBoxIcon.Question);
                textBox_pdffolder_orig.Focus();
                return;
            }
            if (Directory.Exists(textBox_pdffolder_dest.Text) == false)
            {
                DialogResult ret= MessageBox.Show("nem létezik a célmappa (Létrehozzuk?)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret==DialogResult.Yes)
                {
                    Directory.CreateDirectory(textBox_pdffolder_dest.Text);
                }
                else
                {
                    textBox_pdffolder_dest.Focus();
                    return;
                }
            }
            if (checkBox_print.Checked==true & comboBox_printer.SelectedIndex == 0)
            {
                MessageBox.Show("Nyomtató választás szükséges :P");
                return;
            }
            string[] filePaths = Directory.GetFiles(textBox_pdffolder_orig.Text, "*.pdf");

            foreach (string f in filePaths)
            {

                PdfDocument doc = new PdfDocument();
                doc = PdfReader.Open(f);

                PdfPage page = doc.Pages[0];
                page.Orientation = 0;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Courier", 10);
                
                string newname = textBox_pdffolder_dest.Text +"\\"+ f.Substring(textBox_pdffolder_orig.Text.Length + 1);

                gfx.DrawString(
                    newname, 
                    font, 
                    XBrushes.Black,
                    10, 
                    10
                    );

                
                doc.Save(newname);
                doc.Close();

                if (checkBox_print.Checked == true)
                {
                    ProcessStartInfo info = new ProcessStartInfo(newname);
                    info.Verb = "Print";
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(info);

                    Process.Start(newname);
                }

            }

            MessageBox.Show("Kész :)");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBox_printer.Items.Add(printer);
            }
            comboBox_printer.Enabled = checkBox_print.Checked;
        }

        private void button_folderbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Kérlek válaszd ki a pdf-eket tartalmazó mappát";
            dlg.ShowDialog();
            textBox_pdffolder_orig.Text = dlg.SelectedPath.ToString();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Ez az app a PDF fileokba beszúrja az adott file útvonalát \n (és igény szerint kiküldi a kiválasztott nyomtatóra)");
            e.Cancel = true;
        }

        private void checkBox_print_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_printer.Enabled = checkBox_print.Checked;
        }

        private void button_folderbrowse_destination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Kérlek válassz célmappát";
            dlg.ShowDialog();
            textBox_pdffolder_dest.Text = dlg.SelectedPath.ToString();
        }
    }
}
