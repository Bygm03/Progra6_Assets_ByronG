using Progra6_Assets_ByronG.Models;

namespace Progra6_Assets_ByronG.ModelsDTOs
{
    public class UserDTO
    {
        //Un DTO (data transfer object) sirve para varios objetivos.

        //1. desacoplar eI modelo de la funcionalidad de los control ters
        //para evitar que en futuras actualizaciones de los modelos
        //puedan ocurrir errores dificiles de reparar.

        //2. sirve para simplificar modelos muy complejos y que tienen
        //composiciones recursivas, muy comunes cuando se generan
        //mediante ORM como Entity Framework, Dapper, Django...

        //3. Por un asunto de Seguridad. Ya que normalmente Los equipos
        //de desarrollo de las apps y web apis estån separados, y no
        //se quiere que los programadores de front end sepan como esta
        //estructurada la base de datos tomando como base los modelos.

        public int CodigoUsuario { get; set; }

        public string Cedula { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }

        public string Correo { get; set; } = null!;

        //en este ejemplo no usaremos la contraseña ya que este DTO
        //sera usado para mostrar la lista de usuarios en una UI
        //tendremos otra version de DTO que si tiene la contraseña
        //para cuando querramos agregar un usuario.

        //public string Contrasennia { get; set; } = null!;

        public bool? Activo { get; set; }

        public int CodigoDeRol { get; set; }

        public string? RolDeUsuario { get; set; }

        public string? NotasDeUsuario { get; set; }

        //acá se pueden agregar los atributos que sean necesarios.

    }
}
