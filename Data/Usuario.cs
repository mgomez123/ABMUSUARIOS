using System;
using System.Collections.Generic;

namespace ABMUSUARIOS.Data;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public DateTime? FechaNac { get; set; }

    public string Email { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Ciudad { get; set; }

    public string? CodigoPostal { get; set; }
}
