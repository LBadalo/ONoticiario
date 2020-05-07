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
            this.ListaComentarios = new HashSet<Comentarios>();

            this.ListaCategorias = new HashSet<Categorias>();
        }

        //Chave primaria
        [Key]
        public int ID { get; set; }

        //Data da publicação
        public DateTime Data { get; set; }
        /// <summary>
        /// Titulo da noticia
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Titulo { get; set; }

        /// <summary>
        /// Capa da Noticia
        /// </summary>
        public string Capa { get; set; }

    

        //Paragrafo a negrito da Noticia
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Descricao { get; set; }

        //Conteudo da Noticia
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Conteudo { get; set; }

        /// <summary>
        /// Chave forasteira para o Utilizador
        /// </summary>
        [ForeignKey("Autor")]
        public int AutorFK { get; set; }
        public virtual Utilizadores Autor { get; set; }

        //Relacionar a notícia aos vários comentários
        public virtual ICollection<Comentarios> ListaComentarios { get; set; }

        //Relacionar a notícia às várias categorias
        public virtual ICollection<Categorias> ListaCategorias { get; set; }
    }
}