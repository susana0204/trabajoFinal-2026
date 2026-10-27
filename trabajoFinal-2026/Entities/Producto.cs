namespace trabajoFinal_2026.Entities;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public decimal Precio { get; set; }
    public decimal Descuento { get; set; }   // porcentaje de 0 a 100
    public bool EsFavorito { get; set; }
    public bool HappyHour { get; set; }
    public bool Habilitado { get; set; } = true;

    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;

    public int RestauranteId { get; set; }
    public Restaurante Restaurante { get; set; } = null!;
}