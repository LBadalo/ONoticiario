using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Comentarios
    {
        public Comentarios()
        {

        }

        //ID
        [Key]
        public int ID { get; set; }
        //Comentario
        public string Descricao { get; set; }

        //Hora do Comentário
        public DateTime Data { get; set; }

        //Visivel

        //Forasteira
        [ForeignKey("Utilizador")]
        public int UtilizadorFK { get; set; }
        public virtual Utilizadores Utilizador { get; set; }

        //Forasteira
        [ForeignKey("Noticia")]
        public int NoticiasFK { get; set; }
        public virtual Noticias Noticia { get; set; }

    }
}