﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegradorSofttekImanol.Models.Entities
{
    [Table("trabajos")]

    /// <summary>
    /// Represents a work entity.
    /// </summary>
    public class Trabajo : BaseEntity
    {

        [Key]
        [Column("codTrabajo", TypeName = "int")]
        public int CodTrabajo { get; set; }

        [Column("fecha", TypeName = "datetime")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("codProyecto", TypeName = "int")]
        [ForeignKey("Proyecto")]
        [Required]
        public int CodProyecto { get; set; }

        [Column("codServicio", TypeName = "int")]
        [ForeignKey("Servicio")]
        [Required]
        public int CodServicio { get; set; }

        [Column("cantHoras", TypeName = "int")]
        [Required]
        public int CantHoras { get; set; }

        [Column("valorHora")]
        [Required]
        public decimal valorHora { get; set; }

        /// <summary>
        /// Esta propiedad devuelve el producto de las propiedades ValorHora y CantHoras
        /// </summary>
        [Column("costo")]
        [Required]
        public decimal Costo
        {
            private set
            {
                
            }
            get
            {
                return valorHora * CantHoras;
            }
        }

        //Navigation Properties
        public Servicio Servicio { get; set; }
        public Proyecto Proyecto { get; set; }

    }
}
