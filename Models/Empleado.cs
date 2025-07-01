using System.ComponentModel.DataAnnotations;

namespace AGEXPORTBACKEND.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string? Genero { get; set; }
        public string? EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DPI { get; set; }
        public string NIT { get; set; }
        public bool AfiliadoIGSS { get; set; }
        public bool AfiliadoIRTRA { get; set; }
        public string? Direccion { get; set; }
        public decimal? Salario { get; set; }

        public int Edad => DateTime.Today.Year - FechaNacimiento.Year;
    }
}
