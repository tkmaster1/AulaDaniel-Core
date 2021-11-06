using System;

namespace ProjetoDanielEx.Core.Domain
{
    public abstract class Entity
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataExclusao { get; set; }

        public bool Status { get; set; }
    }
}
