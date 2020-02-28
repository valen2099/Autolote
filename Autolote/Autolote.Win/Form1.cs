
using Autolote.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolote.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var marcasBL = new MarcasBL();
            var listadeMarcas = marcasBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = listadeMarcas;

        }
    }
}
