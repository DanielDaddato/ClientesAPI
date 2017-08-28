using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Infra.Entidades
{
    public class Conta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ContaID { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public int TipoConta { get; set; }
        public double Saldo { get; set; }

        
        public Guid ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        public Cliente Cliente { get; set; }


    }
}
