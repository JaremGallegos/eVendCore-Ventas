using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eVend_SysVentas.Models;

public class Usuario
{
    // Identificador único para cada usuario
    [Key]
    [ReadOnly(true)]
    [Display(Name = "ID")]
    public long Id { get; set; }

    // Identificador único público en formato binario
    [ReadOnly(true)]
    [Display(Name = "UID")]
    public Guid Uuid  { get; set; }

    // Nombre de usuario del individuo
    [Required]
    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Se ingresó caracteres no permitidos")]
    [Length(4, 20, ErrorMessage = "El usuario debe tener como mínimo 4 cracteres")]
    [Display(Name = "Usuario")]
    public string? Username { get; set; }

    // Contraseña del usuario
    [Display(Name = "Contraseña")]
    [Length(12, 50, ErrorMessage = "Tu contraseña debe tener como mínimo 12 caracteres")]
    public string? Password { get; set; }

    // Pin rápido para poder inciiar sesión de forma rápida
    [Display(Name = "PIN")]
    public byte PIN { get; set; }

    // Nombre de la instalación personalizada
    [Required]
    [Display(Name = "Localidad")]
    public string? Facility { get; set; }

    // Dirección de correo electrónico del usuario
    [Required]
    [Display(Name = "Correo electrónico")]
    public string? Email { get; set; }

    // Dirección de correo electrónico asociado a Google
    [Required]
    [Display(Name = "Correo Inicio Sesion")]
    public string? GoogleSigningEmail { get; set; }

    // URL asociada al avatar del usuario
    [Required]
    [Display(Name = "Avatar")]
    public string? UrlAvatar { get; set; }

    // Indica el origen del usuario.
    [Required]
    [Display(Name = "País de Origen")]
    public string? Source { get; set; }

    // Indica si la cuenta del usuario está activa
    [Display(Name = "Activo")]
    public byte Active { get; set; }

    // Fecha y hora de la última vez que accedieron al sistema
    [DataType(DataType.Date)]
    [Display(Name = "Último Inicio de Sesión")]
    public DateTime LastLogin { get; set; }

    // Fecha y hora de creación del registro del usuario
    [DataType(DataType.Date)]
    [Display(Name = "Fecha de Creación")]
    public DateTime DateCreated { get; }

    // Fecha y hora de la última actualización del registro
    [DataType(DataType.Date)]
    [Display(Name = "Última Actualización")]
    public DateTime LastUpdated { get; set; }

    // Alamacén de datos por defecto
    [Display(Name = "Almacén de Datos por Defecto")]
    public string? DefaultWarehouse { get; set; }
}
