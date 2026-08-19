// Nombre completo: MEYBELINE ABIGAIL CORVERA CRUZ
// Nota de auto-evaluación: 10/10

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U20261631
{
    public partial class FrmFichaEmpleado : Form
    {
        public FrmFichaEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "Nombre: " + txtNombre.Text + "\n" +
                             "Apellido: " + txtApellido.Text + "\n" +
                             "Fecha de Ingreso: " + dtpFechaIngreso.Value.ToShortDateString() + "\n" +
                             "Cargo: " + txtCargo.Text;

            MessageBox.Show(mensaje, "Datos Guardados");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            // Quitar el guion para trabajar solo con los dígitos
            string digitos = txtDUI.Text.Replace("-", "");

            // Limitar a máximo 9 dígitos (00000000-0)
            if (digitos.Length > 9)
            {
                digitos = digitos.Substring(0, 9);
            }

            string textoFormateado = digitos;

            // Insertar el guion automáticamente después del octavo dígito
            if (digitos.Length > 8)
            {
                textoFormateado = digitos.Substring(0, 8) + "-" + digitos.Substring(8);
            }

            if (txtDUI.Text != textoFormateado)
            {
                txtDUI.Text = textoFormateado;
                txtDUI.SelectionStart = txtDUI.Text.Length; // mantiene el cursor al final
            }
        }

        private void FrmFichaEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "Meybeline";
            txtApellido.Text = "Corvera";
            txtDUI.Text = "069016961";
            txtEdad.Text = "20";
            txtCargo.Text = "Data Analyst";
        }
    }
}
