using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pruebatecnica1._1.Models.dbModels
{
    public class AplicationUser :IdentityUser<int>
    {
        public string? Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [InverseProperty(nameof(Carro.IdusuarioNavigations))]
        public virtual ICollection<Carro>? Carros { get; set; }

    }
}
