namespace BoutiqueShope.CrossCutting
{
    public class ValidacionCampos
    {
        /**
         * Funcion para validar que un campo sea mayor que cero.*/
        public string ValidacionCampoNumerico(string nombreCampo, decimal valorCampo)
        {
            if (valorCampo <= 0)
            {
                return $"El campo {nombreCampo} debe ser mayor que cero\n";
            }
            return string.Empty;
        }
    }
}
