using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Models
{
    public class Petshop
    {
        /// <summary>
        /// Nome do PetShop
        /// </summary>
        public string nomePetshop { get; set; }

        /// <summary>
        /// Distancia em metros
        /// </summary>
        public double distancia { get; set; }

        /// <summary>
        /// Valor do banho em dias uteis para caes pequenos
        /// </summary>
        public double vlDiasUteisCaesPequenos { get; set; }

        /// <summary>
        /// Valor do banho nos demais dias para caes pequenos
        /// </summary>
        public double vlFDSCaesPequenos { get; set; }

        /// <summary>
        /// Valor do banho em dias uteis para caes grandes
        /// </summary>
        public double vlDiasUteisCaesGrandes { get; set; }

        /// <summary>
        /// Valor do banho para os demais dias para caes grandes
        /// </summary>
        public double vlFDSCaesGrandes { get; set; }
    }
}
