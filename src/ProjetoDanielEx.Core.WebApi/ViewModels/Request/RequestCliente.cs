namespace ProjetoDanielEx.Core.WebApi.ViewModels.Request
{
    public class RequestCliente
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public string TipoPessoa { get; set; }
    }

    public class RequestAtualizarCliente
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string TipoPessoa { get; set; }
    }

    public class RequestExcluirCliente
    {
        public int Codigo { get; set; }
    }
}
