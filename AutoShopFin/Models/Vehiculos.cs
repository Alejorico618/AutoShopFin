﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopFin.Models
{
    public class Vehiculos
    {
        [Key]
        public int IdVehiculo { get; set; }

        [Required]
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public string Color { get; set; }

        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
    }
}
