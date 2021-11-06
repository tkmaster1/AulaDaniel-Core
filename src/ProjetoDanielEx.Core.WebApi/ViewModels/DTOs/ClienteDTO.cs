using MiNET.Blocks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDanielEx.Core.WebApi.ViewModels.DTOs
{
    public class ClienteDTO
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        //[ScaffoldColumn(false)]
        //public DateTime DataCadastro { get; set; }

        //[ScaffoldColumn(false)]
        //public DateTime? DataAlteracao { get; set; }

        //[ScaffoldColumn(false)]
        //public DateTime? DataExclusao { get; set; }

     //   public bool Status { get; set; }

        public string Documento { get; set; }

        public string TipoPessoa { get; set; }

        [NotMapped]
        public string DescricaoStatus { get; set; }

        [NotMapped]
        public string CPFCNPJFormatado
        {
            get
            {
                if (Documento.Length == 11)
                {
                    return Convert.ToUInt64(Documento).ToString(@"000\.000\.000\-00");
                }
                else if (Documento.Length > 11)
                {
                    return Convert.ToUInt64(Documento).ToString(@"00\.000\.000\/0000\-00");
                }
                return string.Empty;
            }
        }
    }
}
