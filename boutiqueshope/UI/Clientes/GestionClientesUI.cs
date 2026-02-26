using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BoutiqueShope.Application.Servicios;
using BoutiqueShope.CrossCutting;
using BoutiqueShope.Domain.Entities;

namespace boutiqueshope.UI.Clientes
{
    public partial class GestionClientesUI : Form
    {

        private ClienteService _clienteService;


        BindingList<Cliente> todosLosUsuarios = new BindingList<Cliente>();

        int tamañoPagina = 10;
        int paginaActual = 1;

        public GestionClientesUI()
        {
            _clienteService = new ClienteService();
            InitializeComponent();
            dataGridViewClientes.AutoGenerateColumns = false;
        }

        private async void ConsultarCliente()
        {
            var respuesta = await _clienteService.ListarAsync();
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarError(respuesta.Mensaje);
                return;
            }

            todosLosUsuarios = new BindingList<Cliente>(respuesta.Listado);
            CargarPagina();
            lblInformacion.Text = $"Se encontraron: {respuesta.Listado.Count} clientes.";

        }

        private async void ConsultarClientePorNombre()
        {
            string nombreCliente = txtUsuarioBuscar.Text.Trim();
            var respuesta = await _clienteService.ObtenerClientePorNombre(nombreCliente);
            if (!respuesta.Exitoso)
            {
                UIHelper.MostrarAdvertencia("No encontramos coincidencias.");
                return;
            }
            todosLosUsuarios = new BindingList<Cliente>(respuesta.Listado);
            CargarPagina();
            lblInformacion.Text = $"Se encontraron: {respuesta.Listado.Count} clientes.";
        }

        private void CargarPagina()
        {
            int saltar = (paginaActual - 1) * tamañoPagina;
            var datosPaginados = todosLosUsuarios.Skip(saltar).Take(tamañoPagina).ToList();

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = datosPaginados;

            int totalPaginas = (int)Math.Ceiling((double)todosLosUsuarios.Count / tamañoPagina);
            lblEstadoPagina.Text = $"Página {paginaActual} de {totalPaginas}";

            btnAnterior.Enabled = paginaActual > 1;
            btnSiguiente.Enabled = paginaActual < totalPaginas;
        }

        private Cliente ObtenerClienteSeleccionado()
        {
            if (dataGridViewClientes.CurrentRow != null) // Verificamos que haya una fila seleccionada
            {
                DataGridViewRow fila = dataGridViewClientes.CurrentRow;

                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value?.ToString();
                string cedula = fila.Cells["Cedula"].Value?.ToString();
                string telefono = fila.Cells["Telefono"].Value?.ToString();
                string email = fila.Cells["Email"].Value?.ToString();
                string genero = fila.Cells["Genero"].Value?.ToString();

                decimal totalCompras = Convert.ToDecimal(fila.Cells["TotalCompras"].Value);

                DateTime? ultimaCompra = fila.Cells["UltimaCompra"].Value != DBNull.Value && fila.Cells["UltimaCompra"].Value != null
                                         ? Convert.ToDateTime(fila.Cells["UltimaCompra"].Value)
                                         : (DateTime?)null;

                DateTime fechaCreacion = Convert.ToDateTime(fila.Cells["FechaCreacion"].Value);

                return new Cliente
                {
                    Id = id,
                    Nombre = nombre,
                    Cedula = cedula,
                    Telefono = telefono,
                    Email = email,
                    Genero = genero,
                    TotalCompras = totalCompras,
                    UltimaCompra = ultimaCompra,
                    FechaCreacion = fechaCreacion
                };
            }
            else
            {
                UIHelper.MostrarAdvertencia("Por favor, selecciona un cliente de la lista.");
                return null;
            }
        }

        private Cliente ValidacionAcciones()
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                return ObtenerClienteSeleccionado();
            }

            return null;
        }

        private void GestionClientesUI_Load(object sender, EventArgs e)
        {
            ConsultarCliente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente editarCliente = new Cliente();
            editarCliente = ObtenerClienteSeleccionado();

            if (editarCliente is null)
            {
                UIHelper.MostrarAdvertencia("No se ha seleccionado ningún cliente para editar.");
            }
            else
            {
                Cliente actualizacion = ValidacionAcciones();
                if (actualizacion is null)
                {
                    UIHelper.MostrarAdvertencia("No se ha seleccionado ningún cliente para editar.");
                }
                else
                {
                    ClienteUI clienteUI = new ClienteUI(actualizacion, true);
                    clienteUI.ShowDialog();
                    ConsultarCliente();
                }
            }
        }

        private async void EliminarCliente(Cliente cliente)
        {
            if (!UIHelper.Confirmar($"Seguro de eliminar: {cliente.Nombre} de la base de datos. ?"))
                return;

            var clienteId = cliente == null ? 0 : cliente.Id;
            var response = await _clienteService.EliminarAsync(clienteId);
            UIHelper.MostrarRespuesta(response);
        }

        private void txtUsuarioBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarClientePorNombre();
            }
        }

        private void txtUsuarioBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioBuscar.Text))
            {
                ConsultarCliente();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarPagina();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)todosLosUsuarios.Count / tamañoPagina);
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                CargarPagina();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente eliminacion = ValidacionAcciones();

            if (eliminacion is null)
            {
                UIHelper.MostrarAdvertencia("No se ha seleccionado ningún cliente para eliminar.");
            }
            else
            {
                EliminarCliente(eliminacion);
                ConsultarCliente();
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
