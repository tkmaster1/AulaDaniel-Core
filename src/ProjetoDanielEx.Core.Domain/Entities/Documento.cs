namespace ProjetoDanielEx.Core.Domain.Entities
{
    public class Documento : Entity
    {
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public int? CodigoCliente { get; set; }

        /* EF Relations */
        public virtual Cliente Cliente { get; set; }
    }
}
