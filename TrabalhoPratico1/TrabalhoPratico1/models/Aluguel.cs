namespace TrabalhoPratico1.models
{
    public class Aluguel
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; } = null!;

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public int QuilometragemInicial { get; set; }
        public int? QuilometragemFinal { get; set; }

        public decimal ValorDiaria { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
