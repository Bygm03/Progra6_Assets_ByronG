namespace Progra6_Assets_ByronG.ModelsDTOs
{
    public class UserPostDTO
    {
        //Usaremos este DTO para el proceso de crear un usuario nuevo
        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        public string Contrasennia { get; set; } = null!;

        public int CodigoDeRol { get; set; }

    }
}
