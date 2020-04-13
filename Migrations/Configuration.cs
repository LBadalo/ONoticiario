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
            //            new Utilizadores {Avatar="default.jpg",ID=1,Descricao="Administrador da Aplica�ao web",Nome="Carlos Poupado",Username="admin@ipt.pt",DataNascimento= new DateTime(1995, 2, 22) },
            //            new Utilizadores { Avatar = "default.jpg", ID = 2, Descricao = "Jornalista da Aplica�ao web", Nome = "Ant�nio Silva", Username = "Jornalista@ipt.com", DataNascimento = new DateTime(1970, 2, 09) },
            //            new Utilizadores {ID=3,Nome="Joao Fonseca",DataNascimento=new DateTime(1995,2,20),Descricao="Jornalista da pagina web",Avatar="default.jpg",Username="teste@ipt.pt"}

            //        };
            //        utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            //        context.SaveChanges();

            //        //cria��o das noticias
            //        var noticias = new List<Noticias>
            //        {
            //            new Noticias{
            //                ID =1,
            //                Data=new DateTime(2019,06,28),
            //                Titulo ="Chega no pr�ximo ano, Cyberpunk 2077",
            //                Capa="Cyberpunk.jpg",
            //                UtilizadorFK=1,
            //                Descricao="� um dos mais desejados entre os jogadores das v�rias plataformas.",
            //                Conteudo="S� chega no pr�ximo ano, mas o pr�ximo jogo da CD Projekt Red, Cyberpunk 2077, � um dos mais desejados entre os jogadores das v�rias plataformas, conquistando os principais pr�mios da �ltima E3 e deixando o mundo boquiaberto ao introduzir Keanu Reeves como Johnny Silverhand. O projeto � enorme, e por isso as informa��es sobre ele t�m sido cirurgicamente introduzidas pelo est�dio polaco. As mais recentes t�m a ver com uma caracter�stica do sistema de progress�o das armas, que funciona de modo independente para cada tipo, e � mais do que um mero acumular num�rico de poder. Cyberpunk 2077 vai ser lan�ado em abril do pr�ximo ano, para PlayStation 4, Xbox One e PC. Se ainda n�o o fizeram, convidamos-vos a conferir a entrevista que conduzimos com Keanu Reeves, a prop�sito da sua aventura no jogo da CDPR.",
            //                ListaCategorias = new List<Categorias>{categorias[0],categorias[1],categorias[2]},
            //                ListaComentarios= new List<Comentarios>{ }
            //            },            
            //              new Noticias{
            //                ID =5,
            //                Data=new DateTime(2019,07,07),
            //                Titulo ="COLDZERA PEDE PARA SAIR DA MIBR - PROCURA NOVO DESAFIO",
            //                Capa="coldzera.jpg",
            //                UtilizadorFK=1,
            //                Descricao="Para al�m disso, os n�meros estat�sticos de 2019 de coldzera est�o muito aqu�m quando comparados com os seus anteriores, revelando que estes 'problemas internos' afetaram a confian�a e jogo do jogador de 24 anos.",
            //                Conteudo="De acordo com a HLTV.org, o melhor jogador do mundo em 2016 e 2017, Marcelo 'coldzera' David, pediu � organiza��o da MIBR para ser colocado no banco da equipa de Counter-Strike: Global Offensive, pois procura um novo desafio para a sua carreira. O conjunto brasileiro foi eliminado da ESL One Cologne 2019 cedo depois de derrotas frente aos fnatic e BIG naquele que foi o seu primeiro evento com Lucas 'LUCAS1' Teles, que chegou no dia 25 de junho por empr�stimo da Luminosity para o lugar de Jo�o 'felps' Vasconcellos. A HLTV.org adianta que coldzera est� 'frustrado com os pobres resultados' que t�m obtido, sendo que este ano ainda n�o conseguiram chegar a nenhuma final e � evidente que a sa�da de felps n�o foi suficiente para corrigir os 'problemas internos' existentes na atual 12� melhor equipa do mundo. Caso isto se confirme, Wilton 'zews' Prado ser� obrigado a colmatar a aus�ncia da estrela brasileira no StarLadder Major 2019 em setembro, embora coldzera ainda alinhar� pela equipa de Gabriel 'FalleN' Toledo em mais dois torneios (BLAST Pro Series Los Angeles 2019 e IEM Chicago 2019) antes de deixar o roster ativo.",
            //                ListaCategorias = new List<Categorias>{categorias[4],categorias[0]},
            //                ListaComentarios= new List<Comentarios>{ }
            //            }
            //        };
            //        noticias.ForEach(aa => context.Noticias.AddOrUpdate(a => a.Data, aa));
            //        context.SaveChanges();

            //        //cria��o de coment�rios
            //        var comentarios = new List<Comentarios>
            //        {
            //            new Comentarios{ID=1,Descricao="Coment�rio de teste",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
            //            new Comentarios{ID=2,Descricao="Coment�rio de teste",Data=new DateTime(2019,6,28),UtilizadorFK=2,NoticiasFK=1},
            //            new Comentarios{ID=3,Descricao="Outro coment�rio",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=1},
            //            new Comentarios{ID=4,Descricao="Coment�rio novo",Data=new DateTime(2019,6,28),UtilizadorFK=1,NoticiasFK=2},
            //             new Comentarios{ID=5,Descricao="Outro coment�rio",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2},
            //            new Comentarios{ID=6,Descricao="Outro coment�rio",Data=new DateTime(2019,6,28),UtilizadorFK=3,NoticiasFK=2}


            //        };
            //        comentarios.ForEach(aa => context.Comentarios.AddOrUpdate(a => a.Descricao, aa));
            //        context.SaveChanges();
            //    }
        }
    }
}

