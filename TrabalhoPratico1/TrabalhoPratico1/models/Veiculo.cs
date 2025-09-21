namespace TrabalhoPratico1.models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; } = null!;
        public int AnoFabricacao { get; set; }
        public int Quilometragem { get; set; }

        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; } = null!;

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

        public ICollection<Aluguel> Alugueis { get; set; } = new List<Aluguel>();
    }
}
