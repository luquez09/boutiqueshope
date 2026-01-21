using System.Windows.Forms;

namespace BoutiqueShope.CrossCutting
{
    public static class InputValidatorHelper
    {
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Permite solo letras (A–Z, a–z) y espacio
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Permite letras, números y espacios (útil para nombres de usuario)
        public static void LetrasYNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
