using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace businesstechapi.Models
{
    public class Aportes
    {
        [Key]
        public int idaportes { get; set; }
        public int idcliente { get; set; }
        public decimal valor { get; set; }
        public decimal percentual { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime datafinal { get; set; }
        public int tempoMeses { get; set; }
        public decimal valorDisponivelResgate { get; set; }
        public int renovaAporte { get; set; }
        public int resgataTodoAporte { get; set; }
        public string comprovante { get; set; }
        public string carteiraDestino { get; set; }
        public string agenciaDestino { get; set; }
        public string contaDestino { get; set; }
        public string nomeContaDestino { get; set; }
        public string cnpjCpfDestino { get; set; }
        public decimal comissaojaresgatada { get; set; }
        public decimal valorInicialInformado { get; set; }
        public DateTime dtCriacao { get; set; }



    }
}
