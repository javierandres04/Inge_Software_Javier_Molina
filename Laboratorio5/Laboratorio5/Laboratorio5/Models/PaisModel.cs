﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio5.Models
{
    public class PaisModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Debe proporcionar un nombre")]
        [DisplayName("Nombre del país: ")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un continente")]
        [DisplayName("Nombre del continente: ")]
        public string Continente { get; set; }
        [Required(ErrorMessage = "Debe ingresar un idioma")]
        [DisplayName("Idioma: ")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage ="No puede ingresar numeros")]
        public string Idioma { get; set; }
    }
}
