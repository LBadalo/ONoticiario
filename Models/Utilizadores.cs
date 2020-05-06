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
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório.")]
        [StringLength(40, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        [RegularExpression("[A-ZÂÓÍÉ][a-záéíóúàèìòùâêîôûãôûäëïöüçñ]+(( | d[oa](s)? | (d)?e |-|'| d')[A-ZÂÓÍÉ][a-záéíóúàèìòùâêîôûãôûäëïöüçñ]+){1,3}",
        ErrorMessage = "Só são aceites letras.<br />A primeira letra de cada nome é uma Maiúscula seguida de minúsculas.<br />Deve escrever entre 2 e 4 nomes.")]
        public string Nome { get; set; }
        //Username
        [RegularExpression("^[a-zA-Z0-9_.,áãàâÃÀÁÂÔÒÓÕòóôõÉÈÊéèêíìîÌÍÎúùûçÇ!-.? ]*", ErrorMessage = "O {0} tem caracteres inválidos!")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Username { get; set; }


            //Data nascimento
            //data no formato ano/mes/dia
            public DateTime DataNascimento { get; set; }

            //Descricao do utilizador
            public string Descricao { get; set; }

            public string Avatar { get; set; }
        //atributo auxiliar para relacionar a tabela dos utilizadores Asp.Net com a tabela utilizadores

        //Relacionar o utilizadoes às varias noticias onde escreveu e quais comentarios
        public virtual ICollection<Comentarios> ListaComentarios { get; set; }
        public virtual ICollection<Noticias> ListaNoticias { get; set; }


    }
}
