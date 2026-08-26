using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoFutbol
{
    public partial class Form1 : Form
    {
        Equipo unEquipo = new Equipo();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOrdenar.Click += btnOrdenar_Click;
            btnEliminar.Click += btnEliminar_Click;

            dtgListaJugadores.Columns.Add("Nombre", "Nombre");
            dtgListaJugadores.Columns.Add("Dorsal", "Dorsal");
            dtgListaJugadores.Columns.Add("Posicion", "Posicion");
            dtgListaJugadores.Columns.Add("Titular", "Titular");
            dtgListaJugadores.Columns.Add("Fecha de Nacimiento", "Fecha de Nacimiento");
       
            dtgListaJugadores.ReadOnly = true;

            dtgListaJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grpDatosJugador.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }

        private void btnCapturarEquipo_Click(object sender, EventArgs e)
        {
            unEquipo = new Equipo();

            unEquipo.Nombre = txtNombreEquipo.Text;
            if (rad1ra.Checked)
            {
                unEquipo.Categoria=rad1ra.Text;
            }

            if (rad2da.Checked)
            {
                unEquipo.Categoria = rad2da.Text;
            }

            MessageBox.Show("Se ha capturado el equipo\n\n"+unEquipo, "Capturacion Del Equipo");

            grpDatosJugador.Enabled = true;

            txtNombreJugador.Focus();

            grpDatosEquipo.Enabled = false;

        }

        private void MostrarDatosJugador()
        {

            dtgListaJugadores.Rows.Clear();


            foreach (Jugador unJugador in unEquipo)
                dtgListaJugadores.Rows.Add(unJugador.Nombre, unJugador.Dorsal, unJugador.Posicion, unJugador.Titular?"Si" : "No", unJugador.FechaNacimiento.ToShortDateString());


            foreach (Control c in grpDatosJugador.Controls)
                if (c is TextBox)
                    c.Text = "";
            txtNombreJugador.Focus();
        }

        private void btnCapturarJugador_Click(object sender, EventArgs e)
        {
            Jugador unJugador = new Jugador();
            
            unJugador.Nombre = txtNombreJugador.Text;
            unJugador.Dorsal = int.Parse(txtDorsal.Text);
            unJugador.Posicion = char.Parse(cboPosicion.Text);
            unJugador.Titular = chkTitular.Checked;
            unJugador.FechaNacimiento = dtpFechaNacimiento.Value;

            unEquipo.InsertarJugador(unJugador);
            chkTitular.Checked = false;
            MessageBox.Show(unJugador.ToString(),"Capturacion Del Jugador");

            MostrarDatosJugador();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {

           
        }

        private void dtgListaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no se haga clic en el encabezado
            {
                DataGridViewRow fila = dtgListaJugadores.Rows[e.RowIndex];

                txtNombreJugador.Text = fila.Cells["Nombre"].Value.ToString();
                txtDorsal.Text = fila.Cells["Dorsal"].Value.ToString();
                cboPosicion.Text = fila.Cells["Posicion"].Value.ToString();
                chkTitular.Checked = fila.Cells["Titular"].Value.ToString() == "Si";
                dtpFechaNacimiento.Value = DateTime.Parse(fila.Cells["Fecha de Nacimiento"].Value.ToString());

                btnGuardarCambios.Enabled = true; // Habilita el botón para modificar
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            unEquipo.OrdenarJugadores();  // Ordena la lista
            MostrarDatosJugador();  // Refresca el DataGridView
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dtgListaJugadores.SelectedRows.Count > 0)
            {
                int index = dtgListaJugadores.SelectedRows[0].Index; // Obtiene el índice de la fila seleccionada

                Jugador jugadorModificado = unEquipo.ObtenerJugador(index); // Obtiene el jugador de la lista

                // Modificar los datos
                jugadorModificado.Nombre = txtNombreJugador.Text;
                jugadorModificado.Dorsal = int.Parse(txtDorsal.Text);
                jugadorModificado.Posicion = char.Parse(cboPosicion.Text);
                jugadorModificado.Titular = chkTitular.Checked;
                jugadorModificado.FechaNacimiento = dtpFechaNacimiento.Value;

                // Refrescar el DataGridView
                MostrarDatosJugador();

                MessageBox.Show("Jugador modificado correctamente", "Modificación Exitosa");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgListaJugadores.SelectedRows.Count > 0)
            {
                int index = dtgListaJugadores.SelectedRows[0].Index; // Obtiene el índice del jugador seleccionado

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este jugador?",
                                                         "Confirmar Eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    unEquipo.EliminarJugador(index); // Elimina el jugador de la lista
                    MostrarDatosJugador(); // Refresca el DataGridView

                    MessageBox.Show("Jugador eliminado correctamente.", "Eliminación Exitosa");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un jugador para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
