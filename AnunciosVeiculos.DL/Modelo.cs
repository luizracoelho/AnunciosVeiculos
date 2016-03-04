using System;

namespace AnunciosVeiculos.DL
{
    public class Modelo
    {
        public int ModeloId { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca { get; set; }
    }
}
