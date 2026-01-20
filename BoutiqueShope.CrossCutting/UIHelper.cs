using System.Windows.Forms;

namespace BoutiqueShope.CrossCutting
{
    public static class UIHelper
    {
        public static void MostrarExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirmar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes;
        }

        public static void MostrarRespuesta<T>(Response<T> respuesta)
        {
            if (respuesta.Exitoso)
                MostrarExito(respuesta.Mensaje);
            else
                MostrarError($"{respuesta.Mensaje}\nCódigo: {respuesta.CodigoError}");
        }
    }
}
