﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.EF_Models
{
    public class CategoriaProductos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        
        [Required]
        public long CategoriaId { get; set; }
        [Required]
        public Categorias Categorias { get; set; } = null!;

        [Required]
        public long ProductoId { get; set; }

        [Required]
        public Productos Productos { get; set; } = null!;
    }
}
