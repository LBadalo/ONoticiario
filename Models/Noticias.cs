using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Noticias
    {
        public Noticias()
        {
           
        }

        //Chave primaria
        [Key]
        public int ID { get; set; }

        //Data da publicação
        public DateTime Data { get; set; }

        //Titulo da noticia
        public string Titulo { get; set; }

        //Capa da Noticia
        public string Capa { get; set; }

        //Chave forasterira
        [ForeignKey("Utilizadores")]
        public int UtilizadorFK { get; set; }

        //Texto da noticia
        public string Texto { get; set; }

        //Relacionar a noticia aos varios comentarios
        public virtual ICollection<Comentarios> ListaComentarios { get; set; }

        //Relacionar a noticia às varias categorias
        public virtual ICollection<Categorias> ListaCategorias { get; set; }
    }
}