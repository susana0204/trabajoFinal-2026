namespace trabajoFinal_2026.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public int RestauranteId { get; set; }
    public Restaurante Restaurante { get; set; } = null!;

    public List<Producto> Productos { get; set; } = new();
}