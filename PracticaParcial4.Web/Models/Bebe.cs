using System.ComponentModel.DataAnnotations;

namespace PracticaParcial4.Web.Models;

public class Bebe
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El peso es obligatorio.")]
    [Range(1, 20, ErrorMessage = "El peso debe estar entre 1 y 20 kg.")]
    public int Peso { get; set; }

    [Range(0, 5, ErrorMessage = "La edad debe estar entre 0 y 5 años.")]
    public int Edad { get; set; }

    public string? TallaPañal { get; set; }

}
