using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class AddRoleDto
{
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }

    /*
    
    public class MascotaEspecieDto
    {
        public string Nombre {get; set;}
        public string Especie {get; set;}
    }


    public class MedicinaPrecioDto
    {
        public string Nombre {get; set;}
        public decimal Precio {get; set;}
    }

    
    */
}
