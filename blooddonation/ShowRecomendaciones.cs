using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blooddonation
{
    public partial class ShowRecomendaciones : Form
    {
        public ShowRecomendaciones()
        {
            InitializeComponent();
            //Se usa la clase Path para buscar el pdf, ese pdf se agrega a properties y se agrega en resource
            string abrirPdf = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "PDFtemporal.pdf");
            System.IO.File.WriteAllBytes(abrirPdf, Properties.Resources.Recomendaciones);
            axAcroPDF1.src = abrirPdf;
        }

    }
}
