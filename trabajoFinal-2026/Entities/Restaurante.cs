namespace trabajoFinal_2026.Entities;

public class Restaurante
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }

    public List<Categoria> Categorias { get; set; } = new();
    public List<Producto> Productos { get; set; } = new();
}