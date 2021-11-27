namespace ProjetoDanielEx.Core.WebApi.ViewModels.Request.Cliente
{
    public class RequestAtualizarCliente
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string TipoPessoa { get; set; }
    }
}
