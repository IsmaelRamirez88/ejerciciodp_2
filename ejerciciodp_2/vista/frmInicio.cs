using ejerciciodp_2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ejerciciodp_2.vista
{
    public partial class frmInicio : Form
    {
        modelo_datos Datos;        
        public frmInicio()
        {
            InitializeComponent();
            Datos = new modelo_datos();
            CrearGrid();
        }
        private void CrearGrid()
        {
            Datos.DataGridViewDobleBuffer(ref dgvInformacion);
            dgvInformacion.Columns.AddRange(new DataGridViewColumn[] 
            {
                new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "id Distribuidor", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, SortMode = DataGridViewColumnSortMode.NotSortable, Visible = false, ReadOnly = true},
                new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, SortMode = DataGridViewColumnSortMode.NotSortable, Visible = true, ReadOnly = true},
                new DataGridViewTextBoxColumn { Name = "Calle", DataPropertyName = "Calle", HeaderText = "Calle", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, SortMode = DataGridViewColumnSortMode.NotSortable, Visible = true, ReadOnly = true},
                new DataGridViewTextBoxColumn { Name = "Numero_Casa", DataPropertyName = "Numero_Casa", HeaderText = "Numero Casa", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, SortMode = DataGridViewColumnSortMode.NotSortable, Visible = true, ReadOnly = true},
                new DataGridViewTextBoxColumn { Name = "Colonia", DataPropertyName = "Colonia", HeaderText = "Colonia", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, SortMode = DataGridViewColumnSortMode.NotSortable, Visible = true, ReadOnly = true},
                
            });
        }
        private Tuple<bool, string> ValidarCampos(int Tipo)
        {
            bool Respuesta = true;
            string Mensaje = "Ok";
            try
            {
                if (Tipo == 1 && string.IsNullOrEmpty(txtIdDistribuido.Text))
                {
                    Respuesta =  false;
                    Mensaje = "Ingrese id distribuidor";
                }
                if (Tipo == 0 && Respuesta && string.IsNullOrEmpty(txtNombre.Text))
                {
                    Respuesta = false;
                    Mensaje = "Ingrese Nombre";
                }
                if (Tipo == 0 && Respuesta && string.IsNullOrEmpty(txtApellidoPaterno.Text))
                {
                    Respuesta = false;
                    Mensaje = "Ingrese Apellido Paterno";
                }
                if (Tipo == 0 && Respuesta && string.IsNullOrEmpty(txtCalle.Text))
                {
                    Respuesta = false;
                    Mensaje = "Ingrese Calle";
                }
                if (Tipo == 0 && Respuesta && string.IsNullOrEmpty(txtNumero.Text))
                {
                    Respuesta = false;
                    Mensaje = "Ingrese Numero ";
                }
                if (Tipo == 0 && Respuesta && string.IsNullOrEmpty(txtColonia.Text))
                {
                    Respuesta = false;
                    Mensaje = "Ingrese Colonia ";
                }
            }
            catch(Exception ex)
            {
                Respuesta = false;
                Mensaje = "Error";
            }
            return Tuple.Create(Respuesta, Mensaje);
        }
        private void LimpiarCampos()
        {
            txtIdDistribuido.Text = Datos.GenerarFolio();
            txtNombre.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtNumero.Text = string.Empty;
            
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            if (Datos.IsConected())
            {
                txtIdDistribuido.Text = Datos.GenerarFolio();
            }
            else
            {
                txtIdDistribuido.Text = "Error de conexion";
                btnGuardar.Enabled = false;
                btnConsultar.Enabled = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var Resultado =  ValidarCampos(0);
                if(Resultado != null && Resultado.Item1)
                {
                    bool ResultadoBD = Datos.Insertar(1, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtCalle.Text
                        , txtNumero.Text, txtColonia.Text);
                    if (ResultadoBD)
                    {
                        MessageBox.Show("Se guardo con exito", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        LimpiarCampos();
                    }                    
                }
                else
                {
                    string Mensaje = (Resultado != null && !string.IsNullOrEmpty(Resultado.Item2) ? Resultado.Item2 : "Error");
                    MessageBox.Show(Mensaje, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscar frmBuscarDistribuidor = new frmBuscar();
                frmBuscarDistribuidor.ShowDialog();
                if(frmBuscarDistribuidor.ID_DISTRIBUIDOR  != null && !string.IsNullOrEmpty(frmBuscarDistribuidor.ID_DISTRIBUIDOR))
                {
                    DataTable tempDistribuidor = new DataTable();
                    tempDistribuidor = Datos.Consultar(2, frmBuscarDistribuidor.ID_DISTRIBUIDOR);
                    dgvInformacion.DataSource = null;
                    if (tempDistribuidor.Rows.Count > 0)
                    {
                        dgvInformacion.DataSource = tempDistribuidor;
                    }
                    else
                    {
                        MessageBox.Show("Sin Información", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
