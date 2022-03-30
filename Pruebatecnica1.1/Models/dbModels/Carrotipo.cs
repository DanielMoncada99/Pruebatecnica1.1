using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pruebatecnica1._1.Models.dbModels
{
    [Table("carrotipo")]
    public partial class Carrotipo
    {
        public Carrotipo()
        {
            Carros = new HashSet<Carro>();
        }

        [Key]
        [Column("idtipocarro")]
        public int Idtipocarro { get; set; }
        [Column("descripcion")]
        [StringLength(10)]
        public string? Descripcion { get; set; }

        [InverseProperty("TipocarroNavigation")]
        public virtual ICollection<Carro> Carros { get; set; }
    }
}
