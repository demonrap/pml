using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PmlMvc.Models
{

    [Table("ap_marchi")]
    public class ap_marchi
    {
        [Key]
        public string id_marchio { get; set; }
        public string descrizione { get; set; }
    }
}