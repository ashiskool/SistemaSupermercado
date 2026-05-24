using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaSupermercado
{
    public partial class FormNota : Form
    {
        public FormNota(string nota)
        {
            InitializeComponent();
            txtNota.Text = nota;
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
