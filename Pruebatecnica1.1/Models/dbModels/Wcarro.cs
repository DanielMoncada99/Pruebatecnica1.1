using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pruebatecnica1._1.Models.dbModels
{
    [Keyless]
    public partial class Wcarro
    {
        [Column("idcarro")]
        public int Idcarro { get; set; }
        [Column("idusuario")]
        public int Idusuario { get; set; }
        [Column("nombrecarro")]
        [StringLength(30)]
        public string Nombrecarro { get; set; } = null!;
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; } = null!;
        [Column("tipocarro")]
        public int Tipocarro { get; set; }
        [Column("tipocarrodescripcion")]
        [StringLength(10)]
        public string? Tipocarrodescripcion { get; set; }
        [Column("modelo")]
        [StringLength(10)]
        public string? Modelo { get; set; }
        public string? Fotografia { get; set; }
        [Column("idusuarioretiro")]
        public int? Idusuarioretiro { get; set; }
        [Column("fercharetiro", TypeName = "datetime")]
        public DateTime? Fercharetiro { get; set; }
    }
}
