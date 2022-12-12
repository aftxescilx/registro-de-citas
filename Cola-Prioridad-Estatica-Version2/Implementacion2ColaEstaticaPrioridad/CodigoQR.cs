using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using System.Drawing;
using System.Windows.Forms;

namespace Implementacion2ColaEstaticaPrioridad
{
    class CodigoQR
    {
        public Bitmap generarCita(string nombre, string prioridad)
        {
            BarcodeWriter br = new BarcodeWriter();
            br.Format = BarcodeFormat.QR_CODE;
            string query = "INSERT INTO citas (nombre, prioridad) VALUES ('" + nombre + "', '0');";
            Bitmap bm = new Bitmap(br.Write(query), 300, 300);

           return bm;
        }
    }
}
