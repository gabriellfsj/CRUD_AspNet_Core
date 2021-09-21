 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_CLIENTES.Models.Entidades
{
    [Table("Clientes_Db")]
    public class Clientes
    {
        [Display(Description = "Código" )]
        public int Id { get; set; }

        [Display(Description = "Nome Completo")]
        public string nome_completo { get; set; }

        [Display(Description = "CPF")]
        public int cpf { get; set; }

        [Display(Description = "Identidade")]
        public int identidade { get; set; }

        [Display(Description = "Telefone Celular")]
        public int telefone_celular { get; set; }

        [Display(Description = "Telefone Fixo")]
        public int telefone_fixo { get; set; }

        [Display(Description = "Telefone Comercial")]
        public int telefone_comercial { get; set; }

        [Display(Description = "Endereço para Cobrança")]
        public string endereço_cobrança { get; set; }

        [Display(Description = "Endereço Correspondência")]
        public string endereço_correpondencia { get; set; }

        [Display(Description = "Endereço Entrega")]
        public string endereço_entrega { get; set; }

        [Display(Description = "Endereço Residencial")]
        public string endereço_residencial { get; set; }
    }
}
