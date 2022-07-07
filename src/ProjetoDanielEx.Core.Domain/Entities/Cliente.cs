using System.Collections.Generic;

namespace ProjetoDanielEx.Core.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Documento { get; set; }

        public string TipoPessoa { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
