using Modelo.Modelo.Entidades;

namespace Modelo.Modelo.Infraestructura
{
    public static class Sesion
    {
        // aca guardamos el usuario que inicio sesion para poder usarlo en todo el sistema mientras este abierto
        public static Usuario UsuarioActual { get; set; }
    }
}
