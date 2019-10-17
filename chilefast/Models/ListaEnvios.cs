using System;
namespace chilefast.Models
{
    public class ListaEnvios
    {
        public int id { get; set; }
        public string direccion { get; set; }
        public string lat_origen { get; set; }
        public string lon_origen { get; set; }
        public string lat_destino { get; set; }
        public string lon_destino { get; set; }
        public string estado { get; set; }
        public string chofer { get; set; }
    }
}
