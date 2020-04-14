using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Categorias
    {
        public Categorias() {
            ListaNoticias = new HashSet<Noticias>();
        }
        //ID
        [Key]
        public int ID { get; set; }
        //Nome da categoria
        public string TipoCategoria { get; set; }
        //Relacionar as categorias com as noticias
        public ICollection<Noticias> ListaNoticias { get; set; }
    }
    
}