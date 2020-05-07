using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONoticiario.Models
{
    public class Utilizadores
    {
            //construtor
            public Utilizadores()
            {
                this.ListaComentarios = new HashSet<Comentarios>();
                this.ListaNoticias = new HashSet<Noticias>();
            }

            //atributos da class
            //ID
            [Key]
            public int ID { get; set; }

        //Nome do utilizador
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(40, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Username { get; set; }


            //Data nascimento
            //data no formato ano/mes/dia
            public DateTime DataNascimento { get; set; }

            //Descricao do utilizador
            public string Biografia { get; set; }

            public string Avatar { get; set; }
        //atributo auxiliar para relacionar a tabela dos utilizadores Asp.Net com a tabela utilizadores

        //Relacionar o utilizadoes às varias noticias onde escreveu e quais comentarios
        public virtual ICollection<Comentarios> ListaComentarios { get; set; }
        public virtual ICollection<Noticias> ListaNoticias { get; set; }


    }
}
