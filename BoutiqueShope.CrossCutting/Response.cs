using System.Collections.Generic;

namespace BoutiqueShope.CrossCutting
{
    public class Response<T>
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public string CodigoError { get; set; }
        public T Data { get; set; }
        public List<T> Listado { get; set; }

        public Response()
        {
            Exitoso = false;
            Mensaje = string.Empty;
            CodigoError = string.Empty;
            Listado = new List<T>();
        }

        public static Response<T> Success(string mensaje = "Operación exitosa", T data = default)
        {
            return new Response<T>
            {
                Exitoso = true,
                Mensaje = mensaje,
                Data = data
            };
        }

        public static Response<T> SuccessList(List<T> lista, string mensaje = "Consulta exitosa")
        {
            return new Response<T>
            {
                Exitoso = true,
                Mensaje = mensaje,
                Listado = lista
            };
        }

        public static Response<T> Fail(string mensaje, string codigoError = "")
        {
            return new Response<T>
            {
                Exitoso = false,
                Mensaje = mensaje,
                CodigoError = codigoError
            };
        }
    }
}

