using System;

namespace AnunciosVeiculos.DL
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        public Modelo Modelo { get; set; }

        public Usuario Usuario { get; set; }

        public decimal Valor { get; set; }

        public int AnoFabricacao { get; set; }

        public int AnoModelo { get; set; }

        public DateTime DataCadastro { get; set; }

        public int Hodometro { get; set; }
    }
}
