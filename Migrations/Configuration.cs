namespace ONoticiario.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ONoticiario.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ONoticiario.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ONoticiario.Models.ApplicationDbContext";
        }
        protected override void Seed(ONoticiario.Models.ApplicationDbContext context)
        {

            //Inicio do SEED

            //Categorias

            var categorias = new List<Categorias>
                    {
                        new Categorias{ID=1,TipoCategoria="as"},
                        new Categorias{ID=2,TipoCategoria="asd"},
                        new Categorias{ID=3,TipoCategoria="asdf"},
                        new Categorias{ID=4,TipoCategoria="asdfg"},
                        new Categorias{ID=6,TipoCategoria="asdfgh"}
                    };
            categorias.ForEach(aa => context.Categorias.AddOrUpdate(a => a.TipoCategoria, aa));
            context.SaveChanges();

            //Utilizadores
            var utilizadores = new List<Utilizadores> {
                        new Utilizadores {Avatar="",ID=1,Descricao="a",Nome="luis",Username="admin@ipt.pt",DataNascimento= new DateTime(1997, 9, 29) },
                        new Utilizadores { Avatar = "", ID = 2, Descricao = "aa", Nome = "António Silva", Username = "Jornalista@ipt.com", DataNascimento = new DateTime(1970, 2, 09) },
                        new Utilizadores {Avatar="",ID=3,Descricao="aaa", Nome="Mauricio",Username="teste@ipt.pt", DataNascimento=new DateTime(1922,2,20)}

                    };
            utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //criação das noticias
            var noticias = new List<Noticias>
                    {
                        new Noticias{
                            ID =1,
                            Data=new DateTime(2019,06,28),
                            Titulo ="aaa",
                            Capa="asd.jpg",
                            UtilizadorFK=1,
                            Descricao="asdasd.",
                            Conteudo="asdasdsada.",
                            ListaCategorias = new List<Categorias>{categorias[0],categorias[1],categorias[2]},
                            ListaComentarios= new List<Comentarios>{ }
                        },
                          new Noticias{
                            ID =5,
                            Data=new DateTime(2019,07,07),
                            Titulo ="asdasdsa",
                            Capa="asdasdas.jpg",
                            UtilizadorFK=1,
                            Descricao="aaaa",
                            Conteudo="asdasdsadasdas",
                            ListaCategorias = new List<Categorias>{categorias[4],categorias[0]},
                            ListaComentarios= new List<Comentarios>{ }
                        }
                    };
            noticias.ForEach(aa => context.Noticias.AddOrUpdate(a => a.Data, aa));
            context.SaveChanges();

            //criação de comentários
            var comentarios = new List<Comentarios>
                    {
                        new Comentarios{ID=1,Descricao="Comentário de teste",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
                        new Comentarios{ID=2,Descricao="Comentário de teste",Data=new DateTime(2019,6,28),UtilizadorFK=2,NoticiasFK=1},
                        new Comentarios{ID=3,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
                        new Comentarios{ID=4,Descricao="Comentário novo",Data=new DateTime(2019,6,28),UtilizadorFK=1,NoticiasFK=2},
                         new Comentarios{ID=5,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2},
                        new Comentarios{ID=6,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2}


                    };
            comentarios.ForEach(aa => context.Comentarios.AddOrUpdate(a => a.Descricao, aa));
            context.SaveChanges();
        }
    }
    }
}

