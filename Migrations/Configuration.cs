namespace ONoticiario.Migrations
{
    using System;
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

            //       var categorias = new List<Categorias>
            //        {
            //            new Categorias{ID=1,TipoCategoria="Pc"},
            //            new Categorias{ID=2,TipoCategoria="Xboxone"},
            //            new Categorias{ID=3,TipoCategoria="Playstation"},
            //            new Categorias{ID=4,TipoCategoria="Switch"},
            //            new Categorias{ID=5,TipoCategoria="Esports"},
            //            new Categorias{ID=6,TipoCategoria="Outros"}
            //        };
            //        categorias.ForEach(aa => context.Categorias.AddOrUpdate(a => a.TipoCategoria, aa));
            //        context.SaveChanges();

            //        //Utilizadores
            //        var utilizadores = new List<Utilizadores> {
            //            new Utilizadores {Avatar="default.jpg",ID=1,Descricao="Administrador da Aplicaçao web",Nome="Carlos Poupado",Username="admin@ipt.pt",DataNascimento= new DateTime(1995, 2, 22) },
            //            new Utilizadores { Avatar = "default.jpg", ID = 2, Descricao = "Jornalista da Aplicaçao web", Nome = "António Silva", Username = "Jornalista@ipt.com", DataNascimento = new DateTime(1970, 2, 09) },
            //            new Utilizadores {ID=3,Nome="Joao Fonseca",DataNascimento=new DateTime(1995,2,20),Descricao="Jornalista da pagina web",Avatar="default.jpg",Username="teste@ipt.pt"}

            //        };
            //        utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            //        context.SaveChanges();

            //        //criação das noticias
            //        var noticias = new List<Noticias>
            //        {
            //            new Noticias{
            //                ID =1,
            //                Data=new DateTime(2019,06,28),
            //                Titulo ="Chega no próximo ano, Cyberpunk 2077",
            //                Capa="Cyberpunk.jpg",
            //                UtilizadorFK=1,
            //                Descricao="É um dos mais desejados entre os jogadores das várias plataformas.",
            //                Conteudo="Só chega no próximo ano, mas o próximo jogo da CD Projekt Red, Cyberpunk 2077, é um dos mais desejados entre os jogadores das várias plataformas, conquistando os principais prémios da última E3 e deixando o mundo boquiaberto ao introduzir Keanu Reeves como Johnny Silverhand. O projeto é enorme, e por isso as informações sobre ele têm sido cirurgicamente introduzidas pelo estúdio polaco. As mais recentes têm a ver com uma característica do sistema de progressão das armas, que funciona de modo independente para cada tipo, e é mais do que um mero acumular numérico de poder. Cyberpunk 2077 vai ser lançado em abril do próximo ano, para PlayStation 4, Xbox One e PC. Se ainda não o fizeram, convidamos-vos a conferir a entrevista que conduzimos com Keanu Reeves, a propósito da sua aventura no jogo da CDPR.",
            //                ListaCategorias = new List<Categorias>{categorias[0],categorias[1],categorias[2]},
            //                ListaComentarios= new List<Comentarios>{ }
            //            },            
            //              new Noticias{
            //                ID =5,
            //                Data=new DateTime(2019,07,07),
            //                Titulo ="COLDZERA PEDE PARA SAIR DA MIBR - PROCURA NOVO DESAFIO",
            //                Capa="coldzera.jpg",
            //                UtilizadorFK=1,
            //                Descricao="Para além disso, os números estatísticos de 2019 de coldzera estão muito aquém quando comparados com os seus anteriores, revelando que estes 'problemas internos' afetaram a confiança e jogo do jogador de 24 anos.",
            //                Conteudo="De acordo com a HLTV.org, o melhor jogador do mundo em 2016 e 2017, Marcelo 'coldzera' David, pediu à organização da MIBR para ser colocado no banco da equipa de Counter-Strike: Global Offensive, pois procura um novo desafio para a sua carreira. O conjunto brasileiro foi eliminado da ESL One Cologne 2019 cedo depois de derrotas frente aos fnatic e BIG naquele que foi o seu primeiro evento com Lucas 'LUCAS1' Teles, que chegou no dia 25 de junho por empréstimo da Luminosity para o lugar de João 'felps' Vasconcellos. A HLTV.org adianta que coldzera está 'frustrado com os pobres resultados' que têm obtido, sendo que este ano ainda não conseguiram chegar a nenhuma final e é evidente que a saída de felps não foi suficiente para corrigir os 'problemas internos' existentes na atual 12ª melhor equipa do mundo. Caso isto se confirme, Wilton 'zews' Prado será obrigado a colmatar a ausência da estrela brasileira no StarLadder Major 2019 em setembro, embora coldzera ainda alinhará pela equipa de Gabriel 'FalleN' Toledo em mais dois torneios (BLAST Pro Series Los Angeles 2019 e IEM Chicago 2019) antes de deixar o roster ativo.",
            //                ListaCategorias = new List<Categorias>{categorias[4],categorias[0]},
            //                ListaComentarios= new List<Comentarios>{ }
            //            }
            //        };
            //        noticias.ForEach(aa => context.Noticias.AddOrUpdate(a => a.Data, aa));
            //        context.SaveChanges();

            //        //criação de comentários
            //        var comentarios = new List<Comentarios>
            //        {
            //            new Comentarios{ID=1,Descricao="Comentário de teste",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
            //            new Comentarios{ID=2,Descricao="Comentário de teste",Data=new DateTime(2019,6,28),UtilizadorFK=2,NoticiasFK=1},
            //            new Comentarios{ID=3,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
            //            new Comentarios{ID=4,Descricao="Comentário novo",Data=new DateTime(2019,6,28),UtilizadorFK=1,NoticiasFK=2},
            //             new Comentarios{ID=5,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2},
            //            new Comentarios{ID=6,Descricao="Outro comentário",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2}


            //        };
            //        comentarios.ForEach(aa => context.Comentarios.AddOrUpdate(a => a.Descricao, aa));
            //        context.SaveChanges();
            //    }
        }
    }
}

