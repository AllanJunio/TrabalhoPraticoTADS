using TrabalhoPratico1.models;

public class Fabricante
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}