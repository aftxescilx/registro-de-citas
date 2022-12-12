using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using ZXing;
using System.Drawing.Imaging;

namespace Implementacion2ColaEstaticaPrioridad
{
    public partial class Form1 : Form
    {
        ColaPrioridad MiCola;
        CodigoQR codigoQR = new CodigoQR();

        public Form1()
        {
            InitializeComponent();
        }

        //private void btnEncolar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string dato = txtDato.Text;
        //        int prioridad = int.Parse(txtPrioridad.Text);
        //        if (prioridad > 2 | prioridad < 0)
        //        {
        //            MessageBox.Show("Prioridad no valida");
        //            return;
        //        }
        //        if(dato == "")
        //        {
        //            return;
        //        }
        //        MiCola.Encolar(prioridad, dato);
        //        lblCola0.Text = MiCola.Imprimir(0);
        //        lblCola1.Text = MiCola.Imprimir(1);
        //        lblCola2.Text = MiCola.Imprimir(2);
        //        txtDato.Clear();
        //        txtPrioridad.Clear();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Dato o prioridad no valida");
        //    }

        //}

        //private void btnDesencolar_Click(object sender, EventArgs e)
        //{
        //    MiCola.Desencolar();
        //    lblCola0.Text = MiCola.Imprimir(0);
        //    lblCola1.Text = MiCola.Imprimir(1);
        //    lblCola2.Text = MiCola.Imprimir(2);
        //}

        //private void btnIncrementar_Click(object sender, EventArgs e)
        //{
        //    MiCola.IncrementarPrioridad();
        //    lblCola0.Text = MiCola.Imprimir(0);
        //    lblCola1.Text = MiCola.Imprimir(1);
        //    lblCola2.Text = MiCola.Imprimir(2);
        //}



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int maximo = int.Parse(txtTamaño.Text);
        //        if (maximo < 0)
        //        {
        //            MessageBox.Show("Tamaño minimo : 1");
        //            return;
        //        }
        //        MiCola = new ColaPrioridad(maximo);
        //        groupBox1.Visible = true;
        //        groupBox2.Visible = false;

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Tamaño no valido");
        //    }
        //}

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FolderBrowserDialog Dialogo = new FolderBrowserDialog();
        //        if (Dialogo.ShowDialog() == DialogResult.OK)
        //        {
        //            lblCola0.Text = MiCola.Imprimir(0);
        //            lblCola1.Text = MiCola.Imprimir(1);
        //            lblCola2.Text = MiCola.Imprimir(2);
        //            string prioridad0 = lblCola0.Text;
        //            if (prioridad0 == "La cola esta vacia")
        //            {
        //                prioridad0 = "";
        //            }
        //            string prioridad1 = lblCola1.Text;
        //            if (prioridad1 == "La cola esta vacia")
        //            {
        //                prioridad1 = "";
        //            }
        //            string prioridad2 = lblCola2.Text;
        //            if (prioridad2 == "La cola esta vacia")
        //            {
        //                prioridad2 = "";
        //            }
        //            string tamaño = MiCola.MatrizEscalonada[0].Length + "";
        //            string[] ColasYTamaños = { prioridad0, prioridad1, prioridad2, tamaño };
        //            string nombreDelArchivo;
        //            if (txtArchivo.Text == "")
        //            {
        //                nombreDelArchivo = "Cola";
        //            }
        //            else
        //            {
        //                nombreDelArchivo = txtArchivo.Text;
        //            }
        //            string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
        //            using (var writer = new StreamWriter(ruta))
        //            {
        //                writer.Close();
        //            }
        //            File.WriteAllLines(ruta, ColasYTamaños);
        //            MessageBox.Show("Datos guardados en la ruta : " + ruta);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        //private void btnCargar_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog Seleccionar = new OpenFileDialog();
        //    if (Seleccionar.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            string ruta = Seleccionar.FileName;
        //            string[] ColasYTamaño = File.ReadAllLines(ruta);
        //            string[] cola0Arreglo = ColasYTamaño[0].Split(',');
        //            string[] cola1Arreglo = ColasYTamaño[1].Split(',');
        //            string[] cola2Arreglo = ColasYTamaño[2].Split(',');
        //            int tamaño = int.Parse(ColasYTamaño[3]);
        //            MiCola = new ColaPrioridad(tamaño);
        //            CargarColas(cola0Arreglo, 0);
        //            CargarColas(cola1Arreglo, 1);
        //            CargarColas(cola2Arreglo, 2);
        //            lblCola0.Text = MiCola.Imprimir(0);
        //            lblCola1.Text = MiCola.Imprimir(1);
        //            lblCola2.Text = MiCola.Imprimir(2);
        //            groupBox1.Visible = true;
        //            groupBox2.Visible = false;


        //        }
        //        catch
        //        {
        //            MessageBox.Show("Error al cargar la cola");

        //        }
        //    }
        //}
        public void CargarColas(string[] arreglo, int prioridad)
        {
            int contador = 0;
            foreach (string i in arreglo)
            {
                MiCola.Encolar(prioridad, arreglo[contador]);
                contador++;
            }
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            string prioridad;
            int idCita = 1;
           
            if (txtNombre.Text != "")
            {
                //fecha = dateCita.Value.ToString("G");
                if (checkPrioridad.Checked)
                {
                    prioridad = "0";
                    idCita++;

                    pbCodigo.Image = codigoQR.generarCita(txtNombre.Text, prioridad);

                    string ruta = @"C:\Users\miria\Desktop\citas\cita" + idCita + ".Png";
                    pbCodigo.Image.Save(ruta, ImageFormat.Png);

                }
                else
                {
                    string query = "INSERT INTO citas (nombre, fecha, prioridad) VALUES ('" + txtNombre.Text + "', '1'";
                }

                MessageBox.Show("Cita agendada");
            }
        }

        private void btnAbrirCodigo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.Png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\citas"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbCodigo.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbCodigo.Image).ToString();
                txtMostrar.Text = texto;
            }
        }
    }
}
