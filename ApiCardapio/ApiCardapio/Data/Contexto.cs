using ApiCardapio.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiCardapio.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();
        //}

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DiaFuncionamento> DiasFuncionamento { get; set; }
        public DbSet<Franquia> Franquias { get; set; }
        public DbSet<HorarioFuncionamento> HorariosFuncionamento { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoIngrediente> PedidosIngredientes { get; set; }
        public DbSet<PontoCarne> PontosCarne { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoPedido> ProdutosPedidos { get; set; }
        public DbSet<ProdutoFranquia> ProdutoFranquias { get; set; }
        public DbSet<ProdutoIngrediente> ProdutoIngredientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Categoria
            modelBuilder.Entity<Categoria>().HasData(

            new Categoria()
            {
                Id = 1,
                DescricaoCategoria = "Hambúrgueres",
                CategoryDescription = null
            },
            new Categoria()
            {
                Id = 2,
                DescricaoCategoria = "Adicionais",
                CategoryDescription = null
            },
            new Categoria()
            {
                Id = 3,
                DescricaoCategoria = "Bebidas",
                CategoryDescription = null
            },
            new Categoria()
            {
                Id = 4,
                DescricaoCategoria = "Entradas e Porções",
                CategoryDescription = null
            },
            new Categoria()
            {
                Id = 5,
                DescricaoCategoria = "Molhos",
                CategoryDescription = null
            },
            new Categoria()
            {
                Id = 6,
                DescricaoCategoria = "Sobremesas",
                CategoryDescription = null
            });

            #endregion Categoria

            #region Dia Funcionamento
            modelBuilder.Entity<DiaFuncionamento>().HasData(
                new DiaFuncionamento()
                {
                    Id = 1,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 2,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 3,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 4,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 5,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 6,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 7,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 1,
                },
                new DiaFuncionamento()
                {
                    Id = 8,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 9,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 10,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 11,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 12,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 13,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 14,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 2,
                },
                new DiaFuncionamento()
                {
                    Id = 15,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 16,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 17,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 18,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 19,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 20,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 21,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 3,
                },
                new DiaFuncionamento()
                {
                    Id = 22,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 23,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 24,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 25,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 26,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 27,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 28,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 4,
                },
                new DiaFuncionamento()
                {
                    Id = 29,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 30,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 31,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 32,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 33,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 34,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 35,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 5,
                },
                new DiaFuncionamento()
                {
                    Id = 36,
                    DiaSemana = DayOfWeek.Monday,
                    Aberto = false,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 37,
                    DiaSemana = DayOfWeek.Tuesday,
                    Aberto = false,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 38,
                    DiaSemana = DayOfWeek.Wednesday,
                    Aberto = true,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 39,
                    DiaSemana = DayOfWeek.Thursday,
                    Aberto = true,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 40,
                    DiaSemana = DayOfWeek.Friday,
                    Aberto = true,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 41,
                    DiaSemana = DayOfWeek.Saturday,
                    Aberto = true,
                    FranquiaId = 6,
                },
                new DiaFuncionamento()
                {
                    Id = 42,
                    DiaSemana = DayOfWeek.Sunday,
                    Aberto = true,
                    FranquiaId = 6,
                }
                );

            #endregion DiaFuncionamento

            #region Franquia
            modelBuilder.Entity<Franquia>().HasData(

            new Franquia()
            {
                Id = 1,
                UF = "SP",
                Cidade = "Barra Bonita",
                Endereco = "Av. Caio Simões, 306 - Vila Sao Jose",
                Telefone = "(14) 99606-1938",
                Logo = "~/imagens/LogoBrasaBranco.png",
            },
            new Franquia()
            {
                Id = 2,
                UF = "SP",
                Cidade = "Pederneiras",
                Endereco = "Av. Brasil, 410 - Jd Bandeirantes",
                Telefone = "(14) 99667-3737",
                Logo = "~/imagens/LogoBrasaBranco.png",
            },
            new Franquia()
            {
                Id = 3,
                UF = "SP",
                Cidade = "Lençóis Paulista",
                Endereco = "Av. Nove de Julho, 791 - Centro",
                Telefone = "(14) 99691-0647",
                Logo = "~/imagens/LogoBrasaBranco.png",
            },
            new Franquia()
            {
                Id = 4,
                UF = "SP",
                Cidade = "Botucatu",
                Endereco = "Av. Leonardo Vilas Boas, 641 - Vila Nova Botucatu",
                Telefone = "(14) 99673-6679",
                Logo = "~/imagens/LogoBrasaBranco.png"
            },
            new Franquia()
            {
                Id = 5,
                UF = "SP",
                Cidade = "Jaú",
                Endereco = "R. Cônego Anselmo Valvekens, 48 - Centro",
                Telefone = "99815-0116",
                Logo = "~/imagens/LogoBrasaBranco.png"

            }, new Franquia()
            {
                Id = 6,
                UF = "SP",
                Endereco = "R. Luís Bleriot, 8-33 - Vila Aviação",
                Cidade = "Bauru",
                Telefone = "(14) 99720-0798",
                Logo = "~/imagens/LogoBrasaBranco.png",

            });

            #endregion Franquia

            #region Horario Funcionamento
            modelBuilder.Entity<HorarioFuncionamento>().HasData(

            new HorarioFuncionamento()
            {
                Id = 1,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 1
            },
             new HorarioFuncionamento()
             {
                 Id = 2,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 2
             },
              new HorarioFuncionamento()
              {
                  Id = 3,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 3
              },
              new HorarioFuncionamento()
              {
                  Id = 4,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 4
              },
              new HorarioFuncionamento()
              {
                  Id = 5,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 5
              },
              new HorarioFuncionamento()
              {
                  Id = 6,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 6
              },
              new HorarioFuncionamento()
              {
                  Id = 7,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 7
              },

            new HorarioFuncionamento()
            {
                Id = 8,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 8
            },
             new HorarioFuncionamento()
             {
                 Id = 9,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 9
             },
              new HorarioFuncionamento()
              {
                  Id = 10,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 10
              },
              new HorarioFuncionamento()
              {
                  Id = 11,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 11
              },
              new HorarioFuncionamento()
              {
                  Id = 12,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 12
              },
              new HorarioFuncionamento()
              {
                  Id = 13,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 13
              },
              new HorarioFuncionamento()
              {
                  Id = 14,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 14
              },
            new HorarioFuncionamento()
            {
                Id = 15,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 15
            },
             new HorarioFuncionamento()
             {
                 Id = 16,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 16
             },
              new HorarioFuncionamento()
              {
                  Id = 17,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 17
              },
              new HorarioFuncionamento()
              {
                  Id = 18,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 18
              },
              new HorarioFuncionamento()
              {
                  Id = 19,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 19
              },
              new HorarioFuncionamento()
              {
                  Id = 20,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 20
              },
              new HorarioFuncionamento()
              {
                  Id = 21,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 21
              },
            new HorarioFuncionamento()
            {
                Id = 22,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 22
            },
             new HorarioFuncionamento()
             {
                 Id = 23,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 23
             },
              new HorarioFuncionamento()
              {
                  Id = 24,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 24
              },
              new HorarioFuncionamento()
              {
                  Id = 25,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 25
              },
              new HorarioFuncionamento()
              {
                  Id = 26,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 26
              },
              new HorarioFuncionamento()
              {
                  Id = 27,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 27
              },
              new HorarioFuncionamento()
              {
                  Id = 28,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 28
              },
            new HorarioFuncionamento()
            {
                Id = 29,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 29
            },
             new HorarioFuncionamento()
             {
                 Id = 30,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 30
             },
              new HorarioFuncionamento()
              {
                  Id = 31,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 31
              },
              new HorarioFuncionamento()
              {
                  Id = 32,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 32
              },
              new HorarioFuncionamento()
              {
                  Id = 33,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 33
              },
              new HorarioFuncionamento()
              {
                  Id = 34,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 34
              },
              new HorarioFuncionamento()
              {
                  Id = 35,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 35
              },
            new HorarioFuncionamento()
            {
                Id = 36,
                HoraInicio = null,
                HoraFim = null,
                DiaFuncionamentoId = 36
            },
             new HorarioFuncionamento()
             {
                 Id = 37,
                 HoraInicio = null,
                 HoraFim = null,
                 DiaFuncionamentoId = 37
             },
              new HorarioFuncionamento()
              {
                  Id = 38,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 38
              },
              new HorarioFuncionamento()
              {
                  Id = 39,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 39
              },
              new HorarioFuncionamento()
              {
                  Id = 40,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 40
              },
              new HorarioFuncionamento()
              {
                  Id = 41,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 41
              },
              new HorarioFuncionamento()
              {
                  Id = 42,
                  HoraInicio = new DateTime(2021, 08, 26, 18, 30, 00),
                  HoraFim = new DateTime(2021, 08, 26, 22, 30, 00),
                  DiaFuncionamentoId = 42
              }
              );

            #endregion HorarioFuncionamento

            #region Ingrediente
            modelBuilder.Entity<Ingrediente>().HasData(
            new Ingrediente()
            {
                Id = 1,
                NomeIngrediente = "Hambúrguer de 200g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 2,
                NomeIngrediente = "Creme cheddar artesanal",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 3,
                NomeIngrediente = "Farofa de bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 4,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 5,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 6,
                NomeIngrediente = "Hambúrguer de frango sem conservante",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 7,
                NomeIngrediente = "Bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 8,
                NomeIngrediente = "Catupiry",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 9,
                NomeIngrediente = "Couve crispy",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 10,
                NomeIngrediente = "Hambúrguer de 180g bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 11,
                NomeIngrediente = "Molho barbecue",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 12,
                NomeIngrediente = "Queijo cheddar",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 13,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 14,
                NomeIngrediente = "Cebola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 15,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 16,
                NomeIngrediente = "Hambúrguer de 180g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 17,
                NomeIngrediente = "Gorgonzola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 18,
                NomeIngrediente = "Bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 19,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 20,
                NomeIngrediente = "Cebola chapeada",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 21,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 22,
                NomeIngrediente = "Hambúrguer de 180g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 23,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 24,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 25,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 26,
                NomeIngrediente = "Ketchup de goiaba flambado na cachaça",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 27,
                NomeIngrediente = "Provolone empanado e frito",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 28,
                NomeIngrediente = "Hambúrguer de costela de 200g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 29,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 30,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 31,
                NomeIngrediente = "Queijo minas",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 32,
                NomeIngrediente = "Molho lemon pepper com mel",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 33,
                NomeIngrediente = "Onion rings",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 34,
                NomeIngrediente = "Hamburguer de carne da Fazenda do Futuro",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 35,
                NomeIngrediente = "Pão é 100% vegano",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 36,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 37,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 38,
                NomeIngrediente = "Cebola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 39,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 40,
                NomeIngrediente = "Catupiry",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 41,
                NomeIngrediente = "Hamburguer de carne de 180g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 42,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 43,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 44,
                NomeIngrediente = "Catupiry",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 45,
                NomeIngrediente = "Alho frito e bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 46,
                NomeIngrediente = "Hambúrguer de 180g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 47,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 48,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 49,
                NomeIngrediente = "Cebola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 50,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 51,
                NomeIngrediente = "Molho chipotle com especiarias e nachos",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 52,
                NomeIngrediente = "Hambúrguer de 150g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 53,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 54,
                NomeIngrediente = "Cebola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 55,
                NomeIngrediente = "Queijo cheddar",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 56,
                NomeIngrediente = " maionese de bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 57,
                NomeIngrediente = "Acompanha refri 237 ml",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 58,
                NomeIngrediente = "Hambúrguer de 150g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 59,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 60,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 61,
                NomeIngrediente = "Ramas",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 62,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 63,
                NomeIngrediente = "Molho",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 64,
                NomeIngrediente = "Acompanha fritas e refri de 237 ml",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 65,
                NomeIngrediente = "Hambúrguer de 180g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 66,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 67,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 68,
                NomeIngrediente = "Cebola roxa",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 69,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 70,
                NomeIngrediente = "Maionese verde caseira",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 71,
                NomeIngrediente = "Hambúrger a milanesa",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 72,
                NomeIngrediente = "Crispy de parmesão",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 73,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 74,
                NomeIngrediente = "Pesto de tomate com parmesão e manjericão",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 75,
                NomeIngrediente = "Bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 76,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 77,
                NomeIngrediente = "Hambúrguer de 180 gramas",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 78,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 79,
                NomeIngrediente = "Hambúrguer de soja crispy",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 80,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 81,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 82,
                NomeIngrediente = "Cebola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 83,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 84,
                NomeIngrediente = "Catupiry",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 85,
                NomeIngrediente = "Pão 100% vegano",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 86,
                NomeIngrediente = "Hambúrger de 180 gramas",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 87,
                NomeIngrediente = "Catupiry empanado crispy",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 88,
                NomeIngrediente = "Geléia de abacaxi com pimenta",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 89,
                NomeIngrediente = "Bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 90,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 91,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 92,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 93,
                NomeIngrediente = "Cebola roxa",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 94,
                NomeIngrediente = "2 hambúrguers de 100g",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 95,
                NomeIngrediente = "Queijo cheddar",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 96,
                NomeIngrediente = "Bacon",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 97,
                NomeIngrediente = "Geléia de pimenta",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 98,
                NomeIngrediente = "Futuro Burger 100% Plantas",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 99,
                NomeIngrediente = "Maionese verde vegana",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 100,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 101,
                NomeIngrediente = "Tomate",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 102,
                NomeIngrediente = "Cebola roxa",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 103,
                NomeIngrediente = "Champignon salteado no azeite",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 104,
                NomeIngrediente = "Tofu temperado",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 105,
                NomeIngrediente = "Creme de queijo (Cheddar, prato e gorgonzola)",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 106,
                NomeIngrediente = "Hambúrguer de 180g de linguiça mista artesanal",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 107,
                NomeIngrediente = "Creme de gorgonzola",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 108,
                NomeIngrediente = "Cebola cripsy",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 109,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 110,
                NomeIngrediente = "Tomate seco",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 111,
                NomeIngrediente = "Pão francês coberto de queijo",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 112,
                NomeIngrediente = "Hambúrguer de costela",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 113,
                NomeIngrediente = "Rúcula",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 114,
                NomeIngrediente = "Queijo cheddar",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 115,
                NomeIngrediente = "Cebola caramelizada",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 116,
                NomeIngrediente = "Acompanha fritas e refri de 200 ml",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 117,
                NomeIngrediente = "Hambúrguer de costela",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 118,
                NomeIngrediente = "Alface",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 119,
                NomeIngrediente = "Queijo prato",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 120,
                NomeIngrediente = "Molho taste",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 121,
                NomeIngrediente = "Picles",
                NameIngredient = null
            },
            new Ingrediente()
            {
                Id = 122,
                NomeIngrediente = "Acompanha fritas e refri de 200 ml",
                NameIngredient = null
            }
            );
            #endregion Ingrediente

            #region Ponto carne
            modelBuilder.Entity<PontoCarne>().HasData(

            new PontoCarne()
            {
                Id = 1,
                NomePontoCarne = "Mal passada"
            },
            new PontoCarne()
            {
                Id = 2,
                NomePontoCarne = "Ao ponto"
            },
            new PontoCarne()
            {
                Id = 3,
                NomePontoCarne = "Bem passada"
            }
            );
            #endregion Ponto carne

            #region Produto
            modelBuilder.Entity<Produto>().HasData(

            new Produto()
            {
                Id = 1,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/8f7e76090120440bb61f4d5fb0107f3a.png",
                NomeProduto = "Brasão",
                DescricaoProduto = "Hambúrguer de 200g, creme cheddar artesanal, farofa de bacon, alface e tomate.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 2,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/d048fb80037a41b285255a7aaa472967.png",
                NomeProduto = "BRASA CHICKEN CRISPY",
                DescricaoProduto = "Hambúrguer de Frango sem conservante, bacon, catupiry original, couve crispy.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 3,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/2673656e9d7d454c80cc52b32482085e.png",
                NomeProduto = "BARBECUE",
                DescricaoProduto = "Hambúrguer de 180g, bacon, molho barbecue, queijo cheddar, rúcula, cebola e tomate.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 4,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/6b676f1af13e4a1199c8905e9badc4b7.png",
                NomeProduto = "BRASA GORGONZOLA",
                DescricaoProduto = "Hambúrguer de 180g, bacon, gorgonzola, rúcula, cebola chapeada e tomate fresco.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 5,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/3fcc9822405b489883223c3f218b854c.png",
                NomeProduto = "BRASA PROVOLONE",
                DescricaoProduto = "Hambúrguer de 180g, alface, tomate, queijo prato, ketchup de goiaba flambado na cachaça, provolone empanado e frito",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 6,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/56baea49fb7e49e6a354eaec36809d2d.png",
                NomeProduto = "BRASA RIBS",
                DescricaoProduto = "Hambúrguer de costela de 200g, rúcula, tomate, queijo minas, molho lemon pepper com mel e onion rings.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 7,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9ee0660e169a40ef8057c8fda197ba35.png",
                NomeProduto = "BRASA FUTURO",
                DescricaoProduto = "Hamburguer de carne da Fazenda do Futuro, pão é 100% vegano, alface, tomate, cebola, queijo prato e catupiry.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 8,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/da607e7b4dd94ddea962e7a69834e305.png",
                NomeProduto = "BRASAPIRY",
                DescricaoProduto = "Hamburguer de carne de 180g, alface, tomate, catupiry, alho frito e bacon.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 9,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/220ee267043f47c0bb0bffe7892b8f72.png",
                NomeProduto = "BRASEIRO",
                DescricaoProduto = "Hambúrguer de 180g, alface, tomate, cebola, queijo prato, molho chipotle com especiarias e nachos.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 10,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9adcc0e66c204cc8ad68a1626808d9ea.png",
                NomeProduto = "COMBO CHEDDAR",
                DescricaoProduto = "Hambúrguer de 150g, rúcula, cebola, queijo cheddar,  maionese de bacon. Acompanha refri 237 ml.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 11,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/2466c36ec52742e3a2a53dcc671eba96.png",
                NomeProduto = "COMBO ROSE",
                DescricaoProduto = "Hambúrguer de 150g, alface, tomate, ramas, queijo prato, molho! Acompanha fritas e refri de 237 ml.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 12,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/472f4dd5cf3646e4b8e60ec7259fa6aa.png",
                NomeProduto = "DE BOA",
                DescricaoProduto = "Hambúrguer de 180g, alface, tomate, cebola roxa, queijo prato e maionese verde caseira.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 13,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/c4c4bd4620b048f08a5e5330bf9d5da1.png",
                NomeProduto = "BRASA ESPECIAL",
                DescricaoProduto = "Hambúrger a milanesa, crispy de parmesão, queijo prato, pesto de tomate com parmesão e manjericão,bacon e rúcula.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 14,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9640153ac30c4d7d9d2d8cb37aa5a630.png",
                NomeProduto = "KIDS",
                DescricaoProduto = "Hambúrguer de 180 gramas, queijo prato.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 15,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/631a0a50f74e493cb6e59e49f65fbcb5.png",
                NomeProduto = "VEGETARIANO",
                DescricaoProduto = "Hambúrguer de soja crispy, alface, tomate, cebola, queijo prato, catupiry e pão 100% vegano.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 16,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/b481b6dcb40d4ac68831a49bad35360f.png",
                NomeProduto = "BRASA CALIFÓRNIA",
                DescricaoProduto = "Hambúrger de 180 gramas, catupiry empanado crispy, geléia de abacaxi com pimenta, bacon, queijo prato, rúcula, tomate e cebola roxa.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 17,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/c8f4943997624b90b9c5a73d77a18c89.png",
                NomeProduto = "SMASH BRASA",
                DescricaoProduto = "2 hambúrguers de 100g, queijo cheddar, bacon e geléia de pimenta.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 18,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/934f0175a0f84b95b4dc4a6f1b6cf7be.png",
                NomeProduto = "BRASA VEGANO",
                DescricaoProduto = "Futuro Burger 100% Plantas, maionese verde vegana, alface, tomate, cebola roxa, champignon salteado no azeite e tofu temperado.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 19,
                ImagemProduto = null,
                NomeProduto = "BRASA BOWL",
                DescricaoProduto = "Creme de queijo (Cheddar, prato e gorgonzola).",
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 20,
                ImagemProduto = null,
                NomeProduto = "HAMBÚRGUER 180G",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 21,
                ImagemProduto = null,
                NomeProduto = "CREME CHEDDAR",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 22,
                ImagemProduto = null,
                NomeProduto = "MAIONESE VERDE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 23,
                ImagemProduto = null,
                NomeProduto = "SALADA OU CEBOLA ROXA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 24,
                ImagemProduto = null,
                NomeProduto = "CATUPIRY ORIGINAL",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 25,
                ImagemProduto = null,
                NomeProduto = "GELÉIA DE PIMENTA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 26,
                ImagemProduto = null,
                NomeProduto = "QUEIJO PRATO (2 FATIAS)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 27,
                ImagemProduto = null,
                NomeProduto = "QUEIJO CHEDDAR (2 FATIAS)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 28,
                ImagemProduto = null,
                NomeProduto = "BACON",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 29,
                ImagemProduto = null,
                NomeProduto = "ANEL DE CEBOLA (4)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 30,
                ImagemProduto = null,
                NomeProduto = "PROVOLONE CRISPY",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 31,
                ImagemProduto = null,
                NomeProduto = "KETCHUP DE GOIABADA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 32,
                ImagemProduto = null,
                NomeProduto = "CREME GORGONZOLA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 33,
                ImagemProduto = null,
                NomeProduto = "MOLHO BARBECUE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 34,
                ImagemProduto = null,
                NomeProduto = "PICLES",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 35,
                ImagemProduto = null,
                NomeProduto = "OVO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 36,
                ImagemProduto = "https://www.seijisushi.com.br/galerias/produtos/1000/10032016_090358_222_cerveja_heineken_long_neck_355_ml.jpg",
                NomeProduto = "CERVEJA LONG NECK HEINEKEN",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 37,
                ImagemProduto = "https://www.budweiser.com.br/sites/g/files/wnfebl2801/files/Budweiser/Cervejas/990ml-min.png",
                NomeProduto = "CERVEJA LONG NECK BUDWEISER",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 38,
                ImagemProduto = "https://www.freepnglogos.com/uploads/corona-png-logo/corona-bottle-transparent-png-logo-27.png",
                NomeProduto = "CERVEJA LONG NECK CORONA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 39,
                ImagemProduto = "https://www.eisenbahn.com.br/assets/images/pilsen-bottle.png",
                NomeProduto = "CERVEJA LONG NECK EISENBAHN",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 40,
                ImagemProduto = null,
                NomeProduto = "ÁGUA COM GÁS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 41,
                ImagemProduto = null,
                NomeProduto = "ÁGUA SEM GÁS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 42,
                ImagemProduto = null,
                NomeProduto = "CERVEJA 600 ML ORIGINAL",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 43,
                ImagemProduto = null,
                NomeProduto = "CERVEJA 600 ML COLORADO APPIA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 44,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - GUARANÁ ANTARTICA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 45,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - COCA-COLA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 46,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - FANTA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 47,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - SODA/SPRITE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 48,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - TONICA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 49,
                ImagemProduto = null,
                NomeProduto = "REFRIGERANTE - GUARANÁ SCHWEEPS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 50,
                ImagemProduto = null,
                NomeProduto = "SUCO DE LARANJA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 51,
                ImagemProduto = null,
                NomeProduto = "FRITAS COM BACON",
                DescricaoProduto = "350g fritas e bacon.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 52,
                ImagemProduto = null,
                NomeProduto = "FRITAS E ANEIS DE CEBOLA",
                DescricaoProduto = "Meia porção de fritas e 8 aneis de cebola.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 53,
                ImagemProduto = null,
                NomeProduto = "PALITO DE MUSSARELA E NUGGETS",
                DescricaoProduto = "Porção de 4 palitos e 6 nuggets de frango.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 54,
                ImagemProduto = null,
                NomeProduto = "ANEIS DE CEBOLA",
                DescricaoProduto = "Porção de 15 anéis de cebola.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 55,
                ImagemProduto = null,
                NomeProduto = "BOLINHO DE COSTELA",
                DescricaoProduto = "Porção de 10 bolinhos de costela.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 56,
                ImagemProduto = null,
                NomeProduto = "CREME CHEDDAR",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 57,
                ImagemProduto = null,
                NomeProduto = "CREME DE GORGONZOLA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 58,
                ImagemProduto = null,
                NomeProduto = "CATUPIRY ORIGINAL",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 59,
                ImagemProduto = null,
                NomeProduto = "QUEIJO PRATO (FATIA)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 60,
                ImagemProduto = null,
                NomeProduto = "MAIONESE VERDE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 61,
                ImagemProduto = null,
                NomeProduto = "CHEDDAR (FATIA)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 62,
                ImagemProduto = null,
                NomeProduto = "GELÉIA DE PIMENTA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 5
            },
            new Produto()
            {
                Id = 63,
                ImagemProduto = null,
                NomeProduto = "MINI CHURROS",
                DescricaoProduto = "8 MINI churros acompanhado de doce de leite ou nutella",
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 64,
                ImagemProduto = null,
                NomeProduto = "BRASA SPLIT",
                DescricaoProduto = "Banana flambada na cachaça com sorvete e suspiro",
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 65,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/55e990368f1549d182adffe488fe50ec.png",
                NomeProduto = "BRASA JAÚ",
                DescricaoProduto = "Hambúrguer de 180g de linguiça mista artesanal, creme de gorgonzola, cebola cripsy, rúcula , tomate seco no pão francês coberto de queijo.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 66,
                ImagemProduto = null,
                NomeProduto = "GELÉIA DE ABACAXI",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 67,
                ImagemProduto = null,
                NomeProduto = "MAIONESE DE BACON",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 68,
                ImagemProduto = null,
                NomeProduto = "CATUPIRY CRISPY",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 69,
                ImagemProduto = null,
                NomeProduto = "SUCO DE LARANJA VIAGEM 300ML",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 70,
                ImagemProduto = null,
                NomeProduto = "H2O LIMÃO / LIMONETO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 71,
                ImagemProduto = null,
                NomeProduto = "CHOPP 300 ML (BROTAS BEER PILSEN)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 72,
                ImagemProduto = null,
                NomeProduto = "FRITAS",
                DescricaoProduto = "350g fritas.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 73,
                ImagemProduto = null,
                NomeProduto = "BOLINHO DE BACALHAU",
                DescricaoProduto = "Porção de 9 bolinhos de bacalhau.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 74,
                ImagemProduto = null,
                NomeProduto = "BOLINHO DE GORGONZOLA",
                DescricaoProduto = "Porção de 9 bolinhos de gorgonzola.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 75,
                ImagemProduto = null,
                NomeProduto = "TRAVESSEIROS DE MUÇARELA",
                DescricaoProduto = "Porção de 9 travesseiros de muçarela.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 76,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/ceada4a56c8f42488d6bf37ab620e269.png",
                NomeProduto = "COMBO CARAMELIZADO",
                DescricaoProduto = "Hambúrguer de costela, rúcula, queijo cheddar e cebola caramelizada. Acompanha fritas e refri de 200 ml.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 77,
                ImagemProduto = "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/44ed955360fc4e8287820cae43e47479.png",
                NomeProduto = "COMBO TASTE",
                DescricaoProduto = "Hambúrguer de costela, alface, queijo prato, molho taste e picles. Acompanha fritas e refri de 200 ml.",
                ProductDescription = null,
                CategoriaId = 1
            },
            new Produto()
            {
                Id = 78,
                ImagemProduto = null,
                NomeProduto = "BATATA RÚSTICA",
                DescricaoProduto = "350g fritas.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 79,
                ImagemProduto = null,
                NomeProduto = "MILK SHAKE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 80,
                ImagemProduto = null,
                NomeProduto = "HAMBÚRGUER 100G",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 81,
                ImagemProduto = null,
                NomeProduto = "HAMBÚRGUER COSTELA 200G",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 82,
                ImagemProduto = null,
                NomeProduto = "HAMBÚRGUER FRANGO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 83,
                ImagemProduto = null,
                NomeProduto = "ALHO FRITO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 84,
                ImagemProduto = null,
                NomeProduto = "MOLHO ROSE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 85,
                ImagemProduto = null,
                NomeProduto = "BATATA EXTRA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 86,
                ImagemProduto = null,
                NomeProduto = "NACHOS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 87,
                ImagemProduto = null,
                NomeProduto = "FAROFA DE BACON",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 2
            },
            new Produto()
            {
                Id = 88,
                ImagemProduto = null,
                NomeProduto = "SORVEKIDS",
                DescricaoProduto = "2 bolas de sorvete, cobertura de chocolate, canudo biju waffer e confetes.",
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 89,
                ImagemProduto = null,
                NomeProduto = "TAÇA NEGRESCO",
                DescricaoProduto = "Ganache de chocolate meio amargo, sorvete  de leite ninho trufado e farofa de bolacha negresco.",
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 90,
                ImagemProduto = null,
                NomeProduto = "BRASA BROWNIE",
                DescricaoProduto = "Brownie de chocolate, sorvete de creme e calda de chocolate.",
                ProductDescription = null,
                CategoriaId = 6
            },
            new Produto()
            {
                Id = 91,
                ImagemProduto = null,
                NomeProduto = "FRITAS COM CREME CHEDDAR",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 92,
                ImagemProduto = null,
                NomeProduto = "FRITAS COM CATUPUTY",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 93,
                ImagemProduto = null,
                NomeProduto = "FRITAS COM CREME GORGONZOLA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 94,
                ImagemProduto = null,
                NomeProduto = "SALADA MIX",
                DescricaoProduto = "Rúcula, alface, tomate, cebola roxa, palmito, parmesão ralado e crouton.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 95,
                ImagemProduto = null,
                NomeProduto = "TRAVESSEIROS DE QUEIJO COM MOLHO BARBECUE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 96,
                ImagemProduto = null,
                NomeProduto = "BOLINHO DE COSTELA SERVIDO COM GELÉIA DE ABACAXI COM PIMENTA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 97,
                ImagemProduto = null,
                NomeProduto = "MUSSARELA DE BÚFALA CRISPY COM GELÉIA DE PIMENTA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 98,
                ImagemProduto = null,
                NomeProduto = "FRANGO ARTESANAL NO PALITO COM MAIONESE VERDE",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 99,
                ImagemProduto = null,
                NomeProduto = "CROQUETE DE CARNE NA CAMA DE CREAM CHEESE ",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 100,
                ImagemProduto = null,
                NomeProduto = "BATATA RÚSTICA COM ERVAS FINAS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 101,
                ImagemProduto = null,
                NomeProduto = "BATATA DE CARINHA E NUGGETS COM MOLHO ROSÉ",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 102,
                ImagemProduto = null,
                NomeProduto = "TÁBUA DE FRIOS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 103,
                ImagemProduto = null,
                NomeProduto = "MIX DE SALGADINHO ARTESANAL",
                DescricaoProduto = "Coxinha, bolinho de gorognzola, mini quibe.",
                ProductDescription = null,
                CategoriaId = 4
            },
            new Produto()
            {
                Id = 104,
                ImagemProduto = null,
                NomeProduto = "RED BULL (Original, Tropical ou Melancia)",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 105,
                ImagemProduto = null,
                NomeProduto = "SUCO NATURAL 400 ML - LARANJA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 106,
                ImagemProduto = null,
                NomeProduto = "SUCO NATURAL 400 ML - LIMÃO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 107,
                ImagemProduto = null,
                NomeProduto = "SUCO POLPA 400 ML - ABACAXI C/ HORTELÃ",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 108,
                ImagemProduto = null,
                NomeProduto = "SUCO POLPA 400 ML - MORANGO",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 109,
                ImagemProduto = null,
                NomeProduto = "SUCO POLPA 400 ML - MARACUJÁ",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 110,
                ImagemProduto = null,
                NomeProduto = "CAIPIRINHA - VELHO BARREIRO",
                DescricaoProduto = "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 111,
                ImagemProduto = null,
                NomeProduto = "CAIPIROSKA - SAGATIBA",
                DescricaoProduto = "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 112,
                ImagemProduto = null,
                NomeProduto = "CAIPIROSKA - SMIRNOFF",
                DescricaoProduto = "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 113,
                ImagemProduto = null,
                NomeProduto = "CAIPIROSKA - ABSOLUT",
                DescricaoProduto = "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 114,
                ImagemProduto = null,
                NomeProduto = "SAQUERINHAS - SAQUÊ",
                DescricaoProduto = "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 115,
                ImagemProduto = null,
                NomeProduto = "CERVEJA LONG NECK EISENBAHN PILSEN",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 116,
                ImagemProduto = null,
                NomeProduto = "CERVEJA LONG NECK EISENBAHN IPA",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 117,
                ImagemProduto = null,
                NomeProduto = "CERVEJA 600 ML BADEN BADEN GOLDEN",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 118,
                ImagemProduto = null,
                NomeProduto = "CERVEJA 600 ML BADEN BADEN WITBIER",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 119,
                ImagemProduto = null,
                NomeProduto = "PINK 1 - LEMONADE (500 ML)",
                DescricaoProduto = "Limão siciliano, manjericão, suco de groselha e aqua mix.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 120,
                ImagemProduto = null,
                NomeProduto = "PINK 2 - LEMONADE (500 ML)",
                DescricaoProduto = "Laranja com frutas vermelhas e aqua mix.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 121,
                ImagemProduto = null,
                NomeProduto = "PINK 3 - LEMONADE (500 ML)",
                DescricaoProduto = "Limão siciliano, abacaxi, suco de groselha e aqua mix.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 122,
                ImagemProduto = null,
                NomeProduto = "GIN TÔNICA TROPICAL",
                DescricaoProduto = "Red Bull tropical ou Red Bull melância.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 123,
                ImagemProduto = null,
                NomeProduto = "GIN MAÇA VERDE",
                DescricaoProduto = "Tônica e maça verde.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 124,
                ImagemProduto = null,
                NomeProduto = "GIN ESPECIARIAS",
                DescricaoProduto = "Escolha 3 opcões: Blueberry, Cardamomo, Zimbro, Anis Estrelado, Canela.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 125,
                ImagemProduto = null,
                NomeProduto = "GIN COM FRUTAS",
                DescricaoProduto = "Geléia de abacaxi com pimenta e canela.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 126,
                ImagemProduto = null,
                NomeProduto = "GIN COM FRUTAS VERMELHAS",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 127,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS SEM ÁLCOOL - CAIPIRINHA TEEN",
                DescricaoProduto = "Suco de laranja, suco de abacaxi, soda limonada e um lance de groselha.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 128,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS SEM ÁLCOOL - KISS ON THE BEACH",
                DescricaoProduto = "Suco de laranja, suco de pêssego e um lance de groselha.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 129,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS SEM ÁLCOOL - SPANISH",
                DescricaoProduto = "Suco de uva, suco de abacaxi e leite condensado.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 130,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS SEM ÁLCOOL - PIPELINE",
                DescricaoProduto = "Suco de abacaxi, suco de maracuja, leite condensado e cobertura de morango.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 131,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS - PIÑA COLADA",
                DescricaoProduto = "um, suco de abacaxi, leite de côco e leite condensado.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 132,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS - SEX ON THE BEACH",
                DescricaoProduto = "Vodka, xarope de pêssego, suco de laranja e grenadine.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 133,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS - MOSCOW MULE",
                DescricaoProduto = "Vodka, xarope de açucar e espuma de gengibre.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 134,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS - ESPANHOLA",
                DescricaoProduto = "Vinho com morango, abacaxi ou maracujá e leite condensado.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 135,
                ImagemProduto = null,
                NomeProduto = "COQUETÉIS - MOSCATEL COM FRUTAS",
                DescricaoProduto = "Frisante rosé, uva, morango e kiwi.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 136,
                ImagemProduto = null,
                NomeProduto = "CLÁSSICOS  - MOJITO",
                DescricaoProduto = "Rum, hortelã macerado com açucar, suco de limão e água com gás.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 137,
                ImagemProduto = null,
                NomeProduto = "CLÁSSICOS  - WHISKY SOUR",
                DescricaoProduto = "Whisky, limão maceradp com açucar e borda com sal.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 138,
                ImagemProduto = null,
                NomeProduto = "CLÁSSICOS  - MARGARITA",
                DescricaoProduto = "Tequila, limão, um lance de curaçau e borda com sal.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 139,
                ImagemProduto = null,
                NomeProduto = "CLÁSSICOS  - NEGRONI",
                DescricaoProduto = "Gin, Campari, Vermute Rosso e twist de laranja.",
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 140,
                ImagemProduto = null,
                NomeProduto = "DOSES  - CAMPARI",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 141,
                ImagemProduto = null,
                NomeProduto = "DOSES  - WHISKY RED LABEL",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 142,
                ImagemProduto = null,
                NomeProduto = "DOSES  - VODKA ABSOLUT",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            },
            new Produto()
            {
                Id = 143,
                ImagemProduto = null,
                NomeProduto = "DOSES  - GIN TANQUERAY",
                DescricaoProduto = null,
                ProductDescription = null,
                CategoriaId = 3
            }
            );
            #endregion Produto

            #region Produto Franquia
            modelBuilder.Entity<ProdutoFranquia>().HasData(
            new ProdutoFranquia()
            {
                Id = 1,
                Valor = 25,
                FranquiaId = 1,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 2,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 3,
                Valor = 26,
                FranquiaId = 1,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 4,
                Valor = 27,
                FranquiaId = 1,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 5,
                Valor = 27,
                FranquiaId = 1,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 6,
                Valor = 27,
                FranquiaId = 1,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 7,
                Valor = 26,
                FranquiaId = 1,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 8,
                Valor = 25,
                FranquiaId = 1,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 9,
                Valor = 25,
                FranquiaId = 1,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 10,
                Valor = 18.99,
                FranquiaId = 1,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 11,
                Valor = 18.99,
                FranquiaId = 1,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 12,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 13,
                Valor = 28,
                FranquiaId = 1,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 14,
                Valor = 18,
                FranquiaId = 1,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 15,
                Valor = 24,
                FranquiaId = 1,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 16,
                Valor = 29,
                FranquiaId = 1,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 17,
                Valor = 25,
                FranquiaId = 1,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 18,
                Valor = 30,
                FranquiaId = 1,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 19,
                Valor = 13,
                FranquiaId = 1,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 20,
                Valor = 10,
                FranquiaId = 1,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 21,
                Valor = 4.5,
                FranquiaId = 1,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 22,
                Valor = 3.5,
                FranquiaId = 1,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 23,
                Valor = 2,
                FranquiaId = 1,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 24,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 25,
                Valor = 3.5,
                FranquiaId = 1,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 26,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 27,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 28,
                Valor = 4,
                FranquiaId = 1,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 29,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 30,
                Valor = 6,
                FranquiaId = 1,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 31,
                Valor = 4,
                FranquiaId = 1,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 32,
                Valor = 6,
                FranquiaId = 1,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 33,
                Valor = 2.5,
                FranquiaId = 1,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 34,
                Valor = 3.5,
                FranquiaId = 1,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 35,
                Valor = 2.5,
                FranquiaId = 1,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 36,
                Valor = 9,
                FranquiaId = 1,
                ProdutoId = 36
            },
            new ProdutoFranquia()
            {
                Id = 37,
                Valor = 8,
                FranquiaId = 1,
                ProdutoId = 37
            },
            new ProdutoFranquia()
            {
                Id = 38,
                Valor = 9,
                FranquiaId = 1,
                ProdutoId = 38
            },
            new ProdutoFranquia()
            {
                Id = 39,
                Valor = 8,
                FranquiaId = 1,
                ProdutoId = 39
            },
            new ProdutoFranquia()
            {
                Id = 40,
                Valor = 3.5,
                FranquiaId = 1,
                ProdutoId = 40
            },
            new ProdutoFranquia()
            {
                Id = 41,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 41
            },
            new ProdutoFranquia()
            {
                Id = 42,
                Valor = 12,
                FranquiaId = 1,
                ProdutoId = 42
            },
            new ProdutoFranquia()
            {
                Id = 43,
                Valor = 18,
                FranquiaId = 1,
                ProdutoId = 43
            },
            new ProdutoFranquia()
            {
                Id = 44,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 44
            },
            new ProdutoFranquia()
            {
                Id = 45,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 45
            },
            new ProdutoFranquia()
            {
                Id = 46,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 46
            },
            new ProdutoFranquia()
            {
                Id = 47,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 47
            },
            new ProdutoFranquia()
            {
                Id = 48,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 48
            },
            new ProdutoFranquia()
            {
                Id = 49,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 49
            },
            new ProdutoFranquia()
            {
                Id = 50,
                Valor = 6.5,
                FranquiaId = 1,
                ProdutoId = 50
            },
            new ProdutoFranquia()
            {
                Id = 51,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 52,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 53,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 53
            },
            new ProdutoFranquia()
            {
                Id = 54,
                Valor = 22,
                FranquiaId = 1,
                ProdutoId = 54
            },
            new ProdutoFranquia()
            {
                Id = 55,
                Valor = 15,
                FranquiaId = 1,
                ProdutoId = 55
            },
            new ProdutoFranquia()
            {
                Id = 56,
                Valor = 6,
                FranquiaId = 1,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 57,
                Valor = 7,
                FranquiaId = 1,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 58,
                Valor = 5,
                FranquiaId = 1,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 59,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 60,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 61,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 62,
                Valor = 3,
                FranquiaId = 1,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 63,
                Valor = 13,
                FranquiaId = 1,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 64,
                Valor = 26,
                FranquiaId = 2,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 65,
                Valor = 23,
                FranquiaId = 2,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 66,
                Valor = 27,
                FranquiaId = 2,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 67,
                Valor = 28,
                FranquiaId = 2,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 68,
                Valor = 28,
                FranquiaId = 2,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 69,
                Valor = 28,
                FranquiaId = 2,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 70,
                Valor = 27,
                FranquiaId = 2,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 71,
                Valor = 26,
                FranquiaId = 2,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 72,
                Valor = 26,
                FranquiaId = 2,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 73,
                Valor = 19.99,
                FranquiaId = 2,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 74,
                Valor = 19.99,
                FranquiaId = 2,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 75,
                Valor = 23,
                FranquiaId = 2,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 76,
                Valor = 29,
                FranquiaId = 2,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 77,
                Valor = 19,
                FranquiaId = 2,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 78,
                Valor = 25,
                FranquiaId = 2,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 79,
                Valor = 30,
                FranquiaId = 2,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 80,
                Valor = 26,
                FranquiaId = 2,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 81,
                Valor = 31,
                FranquiaId = 2,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 82,
                Valor = 13,
                FranquiaId = 2,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 83,
                Valor = 10,
                FranquiaId = 2,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 84,
                Valor = 4.5,
                FranquiaId = 2,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 85,
                Valor = 3.5,
                FranquiaId = 2,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 86,
                Valor = 2,
                FranquiaId = 2,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 87,
                Valor = 5,
                FranquiaId = 2,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 88,
                Valor = 3.5,
                FranquiaId = 2,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 89,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 90,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 91,
                Valor = 4,
                FranquiaId = 2,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 92,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 93,
                Valor = 6,
                FranquiaId = 2,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 94,
                Valor = 4,
                FranquiaId = 2,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 95,
                Valor = 5,
                FranquiaId = 2,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 96,
                Valor = 2.5,
                FranquiaId = 2,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 97,
                Valor = 3.5,
                FranquiaId = 2,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 98,
                Valor = 2.5,
                FranquiaId = 2,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 99,
                Valor = 25,
                FranquiaId = 2,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 100,
                Valor = 23,
                FranquiaId = 2,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 101,
                Valor = 22,
                FranquiaId = 2,
                ProdutoId = 53
            },
            new ProdutoFranquia()
            {
                Id = 102,
                Valor = 19,
                FranquiaId = 2,
                ProdutoId = 54
            },
            new ProdutoFranquia()
            {
                Id = 103,
                Valor = 16,
                FranquiaId = 2,
                ProdutoId = 55
            },
            new ProdutoFranquia()
            {
                Id = 104,
                Valor = 6,
                FranquiaId = 2,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 105,
                Valor = 7,
                FranquiaId = 2,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 106,
                Valor = 5,
                FranquiaId = 2,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 107,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 108,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 109,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 110,
                Valor = 3,
                FranquiaId = 2,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 111,
                Valor = 13,
                FranquiaId = 2,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 112,
                Valor = 25,
                FranquiaId = 3,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 113,
                Valor = 23,
                FranquiaId = 3,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 114,
                Valor = 26,
                FranquiaId = 3,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 115,
                Valor = 26,
                FranquiaId = 3,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 116,
                Valor = 27,
                FranquiaId = 3,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 117,
                Valor = 27,
                FranquiaId = 3,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 118,
                Valor = 26,
                FranquiaId = 3,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 119,
                Valor = 25,
                FranquiaId = 3,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 120,
                Valor = 25,
                FranquiaId = 3,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 121,
                Valor = 18.99,
                FranquiaId = 3,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 122,
                Valor = 18.99,
                FranquiaId = 3,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 123,
                Valor = 23,
                FranquiaId = 3,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 124,
                Valor = 29,
                FranquiaId = 3,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 125,
                Valor = 18,
                FranquiaId = 3,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 126,
                Valor = 25,
                FranquiaId = 3,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 127,
                Valor = 29,
                FranquiaId = 3,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 128,
                Valor = 25,
                FranquiaId = 3,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 129,
                Valor = 30,
                FranquiaId = 3,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 130,
                Valor = 13,
                FranquiaId = 3,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 131,
                Valor = 10,
                FranquiaId = 3,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 132,
                Valor = 4.5,
                FranquiaId = 3,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 133,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 134,
                Valor = 2,
                FranquiaId = 3,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 135,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 136,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 137,
                Valor = 3,
                FranquiaId = 3,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 138,
                Valor = 3,
                FranquiaId = 3,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 139,
                Valor = 4,
                FranquiaId = 3,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 140,
                Valor = 3,
                FranquiaId = 3,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 141,
                Valor = 6,
                FranquiaId = 3,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 142,
                Valor = 4,
                FranquiaId = 3,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 143,
                Valor = 6,
                FranquiaId = 3,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 144,
                Valor = 2.5,
                FranquiaId = 3,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 145,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 146,
                Valor = 2.5,
                FranquiaId = 3,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 147,
                Valor = 4,
                FranquiaId = 3,
                ProdutoId = 40
            },
            new ProdutoFranquia()
            {
                Id = 148,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 41
            },
            new ProdutoFranquia()
            {
                Id = 149,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 44
            },
            new ProdutoFranquia()
            {
                Id = 150,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 45
            },
            new ProdutoFranquia()
            {
                Id = 151,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 46
            },
            new ProdutoFranquia()
            {
                Id = 152,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 47
            },
            new ProdutoFranquia()
            {
                Id = 153,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 48
            },
            new ProdutoFranquia()
            {
                Id = 154,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 49
            },
            new ProdutoFranquia()
            {
                Id = 155,
                Valor = 6.5,
                FranquiaId = 3,
                ProdutoId = 50
            },
            new ProdutoFranquia()
            {
                Id = 156,
                Valor = 26,
                FranquiaId = 3,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 157,
                Valor = 23,
                FranquiaId = 3,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 158,
                Valor = 24,
                FranquiaId = 3,
                ProdutoId = 53
            },
            new ProdutoFranquia()
            {
                Id = 159,
                Valor = 19,
                FranquiaId = 3,
                ProdutoId = 54
            },
            new ProdutoFranquia()
            {
                Id = 160,
                Valor = 16,
                FranquiaId = 3,
                ProdutoId = 55
            },
            new ProdutoFranquia()
            {
                Id = 161,
                Valor = 4.5,
                FranquiaId = 3,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 162,
                Valor = 6,
                FranquiaId = 3,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 163,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 164,
                Valor = 3,
                FranquiaId = 3,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 165,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 166,
                Valor = 3,
                FranquiaId = 3,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 167,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 168,
                Valor = 13,
                FranquiaId = 3,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 169,
                Valor = 15,
                FranquiaId = 3,
                ProdutoId = 64
            },
            new ProdutoFranquia()
            {
                Id = 170,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 66
            },
            new ProdutoFranquia()
            {
                Id = 171,
                Valor = 3.5,
                FranquiaId = 3,
                ProdutoId = 67
            },
            new ProdutoFranquia()
            {
                Id = 172,
                Valor = 8,
                FranquiaId = 3,
                ProdutoId = 68
            },
            new ProdutoFranquia()
            {
                Id = 173,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 69
            },
            new ProdutoFranquia()
            {
                Id = 174,
                Valor = 5,
                FranquiaId = 3,
                ProdutoId = 70
            },
            new ProdutoFranquia()
            {
                Id = 175,
                Valor = 22,
                FranquiaId = 3,
                ProdutoId = 72
            },
            new ProdutoFranquia()
            {
                Id = 176,
                Valor = 21.99,
                FranquiaId = 3,
                ProdutoId = 76
            },
            new ProdutoFranquia()
            {
                Id = 177,
                Valor = 21.99,
                FranquiaId = 3,
                ProdutoId = 77
            },
            new ProdutoFranquia()
            {
                Id = 178,
                Valor = 23,
                FranquiaId = 3,
                ProdutoId = 78
            },
            new ProdutoFranquia()
            {
                Id = 179,
                Valor = 15,
                FranquiaId = 3,
                ProdutoId = 79
            },
            new ProdutoFranquia()
            {
                Id = 180,
                Valor = 27,
                FranquiaId = 4,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 181,
                Valor = 24,
                FranquiaId = 4,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 182,
                Valor = 27,
                FranquiaId = 4,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 183,
                Valor = 29,
                FranquiaId = 4,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 184,
                Valor = 29,
                FranquiaId = 4,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 185,
                Valor = 28,
                FranquiaId = 4,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 186,
                Valor = 27,
                FranquiaId = 4,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 187,
                Valor = 27,
                FranquiaId = 4,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 188,
                Valor = 26,
                FranquiaId = 4,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 189,
                Valor = 20.9,
                FranquiaId = 4,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 190,
                Valor = 20.9,
                FranquiaId = 4,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 191,
                Valor = 25,
                FranquiaId = 4,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 192,
                Valor = 30,
                FranquiaId = 4,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 193,
                Valor = 19,
                FranquiaId = 4,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 194,
                Valor = 26,
                FranquiaId = 4,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 195,
                Valor = 32,
                FranquiaId = 4,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 196,
                Valor = 26,
                FranquiaId = 4,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 197,
                Valor = 32,
                FranquiaId = 4,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 198,
                Valor = 13,
                FranquiaId = 4,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 199,
                Valor = 11,
                FranquiaId = 4,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 200,
                Valor = 5,
                FranquiaId = 4,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 201,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 202,
                Valor = 2,
                FranquiaId = 4,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 203,
                Valor = 5,
                FranquiaId = 4,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 204,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 205,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 206,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 207,
                Valor = 4,
                FranquiaId = 4,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 208,
                Valor = 4,
                FranquiaId = 4,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 209,
                Valor = 7,
                FranquiaId = 4,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 210,
                Valor = 4,
                FranquiaId = 4,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 211,
                Valor = 6,
                FranquiaId = 4,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 212,
                Valor = 3,
                FranquiaId = 4,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 213,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 214,
                Valor = 3.5,
                FranquiaId = 4,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 215,
                Valor = 27,
                FranquiaId = 4,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 216,
                Valor = 23,
                FranquiaId = 4,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 217,
                Valor = 24,
                FranquiaId = 4,
                ProdutoId = 53
            },
            new ProdutoFranquia()
            {
                Id = 218,
                Valor = 20,
                FranquiaId = 4,
                ProdutoId = 54
            },
            new ProdutoFranquia()
            {
                Id = 219,
                Valor = 19,
                FranquiaId = 4,
                ProdutoId = 55
            },
            new ProdutoFranquia()
            {
                Id = 220,
                Valor = 6,
                FranquiaId = 4,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 221,
                Valor = 7,
                FranquiaId = 4,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 222,
                Valor = 5,
                FranquiaId = 4,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 223,
                Valor = 3,
                FranquiaId = 4,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 224,
                Valor = 3,
                FranquiaId = 4,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 225,
                Valor = 3,
                FranquiaId = 4,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 226,
                Valor = 3,
                FranquiaId = 4,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 227,
                Valor = 13,
                FranquiaId = 4,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 228,
                Valor = 14,
                FranquiaId = 4,
                ProdutoId = 64
            },
            new ProdutoFranquia()
            {
                Id = 229,
                Valor = 26,
                FranquiaId = 5,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 230,
                Valor = 23,
                FranquiaId = 5,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 231,
                Valor = 27,
                FranquiaId = 5,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 232,
                Valor = 28,
                FranquiaId = 5,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 233,
                Valor = 29,
                FranquiaId = 5,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 234,
                Valor = 28,
                FranquiaId = 5,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 235,
                Valor = 27,
                FranquiaId = 5,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 236,
                Valor = 27,
                FranquiaId = 5,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 237,
                Valor = 26,
                FranquiaId = 5,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 238,
                Valor = 20.99,
                FranquiaId = 5,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 239,
                Valor = 20.99,
                FranquiaId = 5,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 240,
                Valor = 24,
                FranquiaId = 5,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 241,
                Valor = 30,
                FranquiaId = 5,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 242,
                Valor = 19,
                FranquiaId = 5,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 243,
                Valor = 27,
                FranquiaId = 5,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 244,
                Valor = 30,
                FranquiaId = 5,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 245,
                Valor = 26,
                FranquiaId = 5,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 246,
                Valor = 30,
                FranquiaId = 5,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 247,
                Valor = 13,
                FranquiaId = 5,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 248,
                Valor = 10,
                FranquiaId = 5,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 249,
                Valor = 4.5,
                FranquiaId = 5,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 250,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 251,
                Valor = 2,
                FranquiaId = 5,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 252,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 253,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 254,
                Valor = 3,
                FranquiaId = 5,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 255,
                Valor = 3,
                FranquiaId = 5,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 256,
                Valor = 4,
                FranquiaId = 5,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 257,
                Valor = 3,
                FranquiaId = 5,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 258,
                Valor = 6,
                FranquiaId = 5,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 259,
                Valor = 4,
                FranquiaId = 5,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 260,
                Valor = 6,
                FranquiaId = 5,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 261,
                Valor = 2.5,
                FranquiaId = 5,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 262,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 263,
                Valor = 2.5,
                FranquiaId = 5,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 264,
                Valor = 8,
                FranquiaId = 5,
                ProdutoId = 36
            },
            new ProdutoFranquia()
            {
                Id = 265,
                Valor = 8,
                FranquiaId = 5,
                ProdutoId = 37
            },
            new ProdutoFranquia()
            {
                Id = 266,
                Valor = 9,
                FranquiaId = 5,
                ProdutoId = 38
            },
            new ProdutoFranquia()
            {
                Id = 267,
                Valor = 10,
                FranquiaId = 5,
                ProdutoId = 39
            },
            new ProdutoFranquia()
            {
                Id = 268,
                Valor = 4,
                FranquiaId = 5,
                ProdutoId = 40
            },
            new ProdutoFranquia()
            {
                Id = 269,
                Valor = 4,
                FranquiaId = 5,
                ProdutoId = 41
            },
            new ProdutoFranquia()
            {
                Id = 270,
                Valor = 12,
                FranquiaId = 5,
                ProdutoId = 42
            },
            new ProdutoFranquia()
            {
                Id = 271,
                Valor = 18,
                FranquiaId = 5,
                ProdutoId = 43
            },
            new ProdutoFranquia()
            {
                Id = 272,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 44
            },
            new ProdutoFranquia()
            {
                Id = 273,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 45
            },
            new ProdutoFranquia()
            {
                Id = 274,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 46
            },
            new ProdutoFranquia()
            {
                Id = 275,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 47
            },
            new ProdutoFranquia()
            {
                Id = 276,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 48
            },
            new ProdutoFranquia()
            {
                Id = 277,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 49
            },
            new ProdutoFranquia()
            {
                Id = 278,
                Valor = 6.5,
                FranquiaId = 5,
                ProdutoId = 50
            },
            new ProdutoFranquia()
            {
                Id = 279,
                Valor = 26,
                FranquiaId = 5,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 280,
                Valor = 24,
                FranquiaId = 5,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 281,
                Valor = 24,
                FranquiaId = 5,
                ProdutoId = 53
            },
            new ProdutoFranquia()
            {
                Id = 282,
                Valor = 20,
                FranquiaId = 5,
                ProdutoId = 54
            },
            new ProdutoFranquia()
            {
                Id = 283,
                Valor = 18,
                FranquiaId = 5,
                ProdutoId = 55
            },
            new ProdutoFranquia()
            {
                Id = 284,
                Valor = 4.5,
                FranquiaId = 5,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 285,
                Valor = 6,
                FranquiaId = 5,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 286,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 287,
                Valor = 3,
                FranquiaId = 5,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 288,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 289,
                Valor = 3,
                FranquiaId = 5,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 290,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 291,
                Valor = 13,
                FranquiaId = 5,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 292,
                Valor = 28,
                FranquiaId = 5,
                ProdutoId = 65
            },
            new ProdutoFranquia()
            {
                Id = 293,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 66
            },
            new ProdutoFranquia()
            {
                Id = 294,
                Valor = 3.5,
                FranquiaId = 5,
                ProdutoId = 67
            },
            new ProdutoFranquia()
            {
                Id = 295,
                Valor = 8,
                FranquiaId = 5,
                ProdutoId = 68
            },
            new ProdutoFranquia()
            {
                Id = 296,
                Valor = 4,
                FranquiaId = 5,
                ProdutoId = 69
            },
            new ProdutoFranquia()
            {
                Id = 297,
                Valor = 5,
                FranquiaId = 5,
                ProdutoId = 70
            },
            new ProdutoFranquia()
            {
                Id = 298,
                Valor = 7.9,
                FranquiaId = 5,
                ProdutoId = 71
            },
            new ProdutoFranquia()
            {
                Id = 299,
                Valor = 22,
                FranquiaId = 5,
                ProdutoId = 72
            },
            new ProdutoFranquia()
            {
                Id = 300,
                Valor = 18,
                FranquiaId = 5,
                ProdutoId = 73
            },
            new ProdutoFranquia()
            {
                Id = 301,
                Valor = 18,
                FranquiaId = 5,
                ProdutoId = 74
            },
            new ProdutoFranquia()
            {
                Id = 302,
                Valor = 18,
                FranquiaId = 5,
                ProdutoId = 75
            },
            new ProdutoFranquia()
            {
                Id = 303,
                Valor = 30,
                FranquiaId = 6,
                ProdutoId = 1
            },
            new ProdutoFranquia()
            {
                Id = 304,
                Valor = 25,
                FranquiaId = 6,
                ProdutoId = 2
            },
            new ProdutoFranquia()
            {
                Id = 305,
                Valor = 29,
                FranquiaId = 6,
                ProdutoId = 3
            },
            new ProdutoFranquia()
            {
                Id = 306,
                Valor = 30,
                FranquiaId = 6,
                ProdutoId = 4
            },
            new ProdutoFranquia()
            {
                Id = 307,
                Valor = 30,
                FranquiaId = 6,
                ProdutoId = 5
            },
            new ProdutoFranquia()
            {
                Id = 308,
                Valor = 30,
                FranquiaId = 6,
                ProdutoId = 6
            },
            new ProdutoFranquia()
            {
                Id = 309,
                Valor = 30,
                FranquiaId = 6,
                ProdutoId = 7
            },
            new ProdutoFranquia()
            {
                Id = 310,
                Valor = 29,
                FranquiaId = 6,
                ProdutoId = 8
            },
            new ProdutoFranquia()
            {
                Id = 311,
                Valor = 27,
                FranquiaId = 6,
                ProdutoId = 9
            },
            new ProdutoFranquia()
            {
                Id = 312,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 10
            },
            new ProdutoFranquia()
            {
                Id = 313,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 11
            },
            new ProdutoFranquia()
            {
                Id = 314,
                Valor = 26,
                FranquiaId = 6,
                ProdutoId = 12
            },
            new ProdutoFranquia()
            {
                Id = 315,
                Valor = 31,
                FranquiaId = 6,
                ProdutoId = 13
            },
            new ProdutoFranquia()
            {
                Id = 316,
                Valor = 21,
                FranquiaId = 6,
                ProdutoId = 14
            },
            new ProdutoFranquia()
            {
                Id = 317,
                Valor = 29,
                FranquiaId = 6,
                ProdutoId = 15
            },
            new ProdutoFranquia()
            {
                Id = 318,
                Valor = 32,
                FranquiaId = 6,
                ProdutoId = 16
            },
            new ProdutoFranquia()
            {
                Id = 319,
                Valor = 29,
                FranquiaId = 6,
                ProdutoId = 17
            },
            new ProdutoFranquia()
            {
                Id = 320,
                Valor = 31,
                FranquiaId = 6,
                ProdutoId = 18
            },
            new ProdutoFranquia()
            {
                Id = 321,
                Valor = 15,
                FranquiaId = 6,
                ProdutoId = 19
            },
            new ProdutoFranquia()
            {
                Id = 322,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 20
            },
            new ProdutoFranquia()
            {
                Id = 323,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 21
            },
            new ProdutoFranquia()
            {
                Id = 324,
                Valor = 3.5,
                FranquiaId = 6,
                ProdutoId = 22
            },
            new ProdutoFranquia()
            {
                Id = 325,
                Valor = 2,
                FranquiaId = 6,
                ProdutoId = 23
            },
            new ProdutoFranquia()
            {
                Id = 326,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 24
            },
            new ProdutoFranquia()
            {
                Id = 327,
                Valor = 3.5,
                FranquiaId = 6,
                ProdutoId = 25
            },
            new ProdutoFranquia()
            {
                Id = 328,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 26
            },
            new ProdutoFranquia()
            {
                Id = 329,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 27
            },
            new ProdutoFranquia()
            {
                Id = 330,
                Valor = 4,
                FranquiaId = 6,
                ProdutoId = 28
            },
            new ProdutoFranquia()
            {
                Id = 331,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 29
            },
            new ProdutoFranquia()
            {
                Id = 332,
                Valor = 7,
                FranquiaId = 6,
                ProdutoId = 30
            },
            new ProdutoFranquia()
            {
                Id = 333,
                Valor = 3.5,
                FranquiaId = 6,
                ProdutoId = 31
            },
            new ProdutoFranquia()
            {
                Id = 334,
                Valor = 6,
                FranquiaId = 6,
                ProdutoId = 32
            },
            new ProdutoFranquia()
            {
                Id = 335,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 33
            },
            new ProdutoFranquia()
            {
                Id = 336,
                Valor = 3.5,
                FranquiaId = 6,
                ProdutoId = 34
            },
            new ProdutoFranquia()
            {
                Id = 337,
                Valor = 2,
                FranquiaId = 6,
                ProdutoId = 35
            },
            new ProdutoFranquia()
            {
                Id = 338,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 36
            },
            new ProdutoFranquia()
            {
                Id = 339,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 37
            },
            new ProdutoFranquia()
            {
                Id = 340,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 38
            },
            new ProdutoFranquia()
            {
                Id = 341,
                Valor = 4,
                FranquiaId = 6,
                ProdutoId = 40
            },
            new ProdutoFranquia()
            {
                Id = 342,
                Valor = 4,
                FranquiaId = 6,
                ProdutoId = 41
            },
            new ProdutoFranquia()
            {
                Id = 343,
                Valor = 12,
                FranquiaId = 6,
                ProdutoId = 42
            },
            new ProdutoFranquia()
            {
                Id = 344,
                Valor = 18,
                FranquiaId = 6,
                ProdutoId = 43
            },
            new ProdutoFranquia()
            {
                Id = 345,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 44
            },
            new ProdutoFranquia()
            {
                Id = 346,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 45
            },
            new ProdutoFranquia()
            {
                Id = 347,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 46
            },
            new ProdutoFranquia()
            {
                Id = 348,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 47
            },
            new ProdutoFranquia()
            {
                Id = 349,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 48
            },
            new ProdutoFranquia()
            {
                Id = 350,
                Valor = 28,
                FranquiaId = 6,
                ProdutoId = 51
            },
            new ProdutoFranquia()
            {
                Id = 351,
                Valor = 22,
                FranquiaId = 6,
                ProdutoId = 52
            },
            new ProdutoFranquia()
            {
                Id = 352,
                Valor = 6,
                FranquiaId = 6,
                ProdutoId = 56
            },
            new ProdutoFranquia()
            {
                Id = 353,
                Valor = 7,
                FranquiaId = 6,
                ProdutoId = 57
            },
            new ProdutoFranquia()
            {
                Id = 354,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 58
            },
            new ProdutoFranquia()
            {
                Id = 355,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 59
            },
            new ProdutoFranquia()
            {
                Id = 356,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 60
            },
            new ProdutoFranquia()
            {
                Id = 357,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 61
            },
            new ProdutoFranquia()
            {
                Id = 358,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 62
            },
            new ProdutoFranquia()
            {
                Id = 359,
                Valor = 13,
                FranquiaId = 6,
                ProdutoId = 63
            },
            new ProdutoFranquia()
            {
                Id = 360,
                Valor = 16,
                FranquiaId = 6,
                ProdutoId = 64
            },
            new ProdutoFranquia()
            {
                Id = 361,
                Valor = 3.5,
                FranquiaId = 6,
                ProdutoId = 67
            },
            new ProdutoFranquia()
            {
                Id = 362,
                Valor = 9,
                FranquiaId = 6,
                ProdutoId = 68
            },
            new ProdutoFranquia()
            {
                Id = 363,
                Valor = 6.5,
                FranquiaId = 6,
                ProdutoId = 70
            },
            new ProdutoFranquia()
            {
                Id = 364,
                Valor = 7.9,
                FranquiaId = 6,
                ProdutoId = 71
            },
            new ProdutoFranquia()
            {
                Id = 365,
                Valor = 22,
                FranquiaId = 6,
                ProdutoId = 72
            },
            new ProdutoFranquia()
            {
                Id = 366,
                Valor = 7,
                FranquiaId = 6,
                ProdutoId = 80
            },
            new ProdutoFranquia()
            {
                Id = 367,
                Valor = 11,
                FranquiaId = 6,
                ProdutoId = 81
            },
            new ProdutoFranquia()
            {
                Id = 368,
                Valor = 7,
                FranquiaId = 6,
                ProdutoId = 82
            },
            new ProdutoFranquia()
            {
                Id = 369,
                Valor = 2,
                FranquiaId = 6,
                ProdutoId = 83
            },
            new ProdutoFranquia()
            {
                Id = 370,
                Valor = 3,
                FranquiaId = 6,
                ProdutoId = 84
            },
            new ProdutoFranquia()
            {
                Id = 371,
                Valor = 5,
                FranquiaId = 6,
                ProdutoId = 85
            },
            new ProdutoFranquia()
            {
                Id = 372,
                Valor = 2.5,
                FranquiaId = 6,
                ProdutoId = 86
            },
            new ProdutoFranquia()
            {
                Id = 373,
                Valor = 2.5,
                FranquiaId = 6,
                ProdutoId = 87
            },
            new ProdutoFranquia()
            {
                Id = 374,
                Valor = 11,
                FranquiaId = 6,
                ProdutoId = 88
            },
            new ProdutoFranquia()
            {
                Id = 375,
                Valor = 16,
                FranquiaId = 6,
                ProdutoId = 89
            },
            new ProdutoFranquia()
            {
                Id = 376,
                Valor = 16,
                FranquiaId = 6,
                ProdutoId = 90
            },
            new ProdutoFranquia()
            {
                Id = 377,
                Valor = 28,
                FranquiaId = 6,
                ProdutoId = 91
            },
            new ProdutoFranquia()
            {
                Id = 378,
                Valor = 28,
                FranquiaId = 6,
                ProdutoId = 92
            },
            new ProdutoFranquia()
            {
                Id = 379,
                Valor = 29,
                FranquiaId = 6,
                ProdutoId = 93
            },
            new ProdutoFranquia()
            {
                Id = 380,
                Valor = 15.9,
                FranquiaId = 6,
                ProdutoId = 94
            },
            new ProdutoFranquia()
            {
                Id = 381,
                Valor = 18,
                FranquiaId = 6,
                ProdutoId = 95
            },
            new ProdutoFranquia()
            {
                Id = 382,
                Valor = 19,
                FranquiaId = 6,
                ProdutoId = 96
            },
            new ProdutoFranquia()
            {
                Id = 383,
                Valor = 18,
                FranquiaId = 6,
                ProdutoId = 97
            },
            new ProdutoFranquia()
            {
                Id = 384,
                Valor = 15,
                FranquiaId = 6,
                ProdutoId = 98
            },
            new ProdutoFranquia()
            {
                Id = 385,
                Valor = 20,
                FranquiaId = 6,
                ProdutoId = 99
            },
            new ProdutoFranquia()
            {
                Id = 386,
                Valor = 15,
                FranquiaId = 6,
                ProdutoId = 100
            },
            new ProdutoFranquia()
            {
                Id = 387,
                Valor = 20,
                FranquiaId = 6,
                ProdutoId = 101
            },
            new ProdutoFranquia()
            {
                Id = 388,
                Valor = 35,
                FranquiaId = 6,
                ProdutoId = 102
            },
            new ProdutoFranquia()
            {
                Id = 389,
                Valor = 24,
                FranquiaId = 6,
                ProdutoId = 103
            },
            new ProdutoFranquia()
            {
                Id = 390,
                Valor = 12,
                FranquiaId = 6,
                ProdutoId = 104
            },
            new ProdutoFranquia()
            {
                Id = 391,
                Valor = 6.5,
                FranquiaId = 6,
                ProdutoId = 105
            },
            new ProdutoFranquia()
            {
                Id = 392,
                Valor = 48.9,
                FranquiaId = 6,
                ProdutoId = 106
            },
            new ProdutoFranquia()
            {
                Id = 393,
                Valor = 6.5,
                FranquiaId = 6,
                ProdutoId = 107
            },
            new ProdutoFranquia()
            {
                Id = 394,
                Valor = 6.5,
                FranquiaId = 6,
                ProdutoId = 108
            },
            new ProdutoFranquia()
            {
                Id = 395,
                Valor = 6.5,
                FranquiaId = 6,
                ProdutoId = 109
            },
            new ProdutoFranquia()
            {
                Id = 396,
                Valor = 48.9,
                FranquiaId = 6,
                ProdutoId = 110
            },
            new ProdutoFranquia()
            {
                Id = 397,
                Valor = 22.9,
                FranquiaId = 6,
                ProdutoId = 111
            },
            new ProdutoFranquia()
            {
                Id = 398,
                Valor = 21.9,
                FranquiaId = 6,
                ProdutoId = 112
            },
            new ProdutoFranquia()
            {
                Id = 399,
                Valor = 25.9,
                FranquiaId = 6,
                ProdutoId = 113
            },
            new ProdutoFranquia()
            {
                Id = 400,
                Valor = 21.9,
                FranquiaId = 6,
                ProdutoId = 114
            },
            new ProdutoFranquia()
            {
                Id = 401,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 115
            },
            new ProdutoFranquia()
            {
                Id = 402,
                Valor = 10,
                FranquiaId = 6,
                ProdutoId = 116
            },
            new ProdutoFranquia()
            {
                Id = 403,
                Valor = 18,
                FranquiaId = 6,
                ProdutoId = 117
            },
            new ProdutoFranquia()
            {
                Id = 404,
                Valor = 18,
                FranquiaId = 6,
                ProdutoId = 118
            },
            new ProdutoFranquia()
            {
                Id = 405,
                Valor = 13.9,
                FranquiaId = 6,
                ProdutoId = 119
            },
            new ProdutoFranquia()
            {
                Id = 406,
                Valor = 13.9,
                FranquiaId = 6,
                ProdutoId = 120
            },
            new ProdutoFranquia()
            {
                Id = 407,
                Valor = 13.9,
                FranquiaId = 6,
                ProdutoId = 121
            },
            new ProdutoFranquia()
            {
                Id = 408,
                Valor = 28.9,
                FranquiaId = 6,
                ProdutoId = 122
            },
            new ProdutoFranquia()
            {
                Id = 409,
                Valor = 28.9,
                FranquiaId = 6,
                ProdutoId = 123
            },
            new ProdutoFranquia()
            {
                Id = 410,
                Valor = 31.9,
                FranquiaId = 6,
                ProdutoId = 124
            },
            new ProdutoFranquia()
            {
                Id = 411,
                Valor = 33.9,
                FranquiaId = 6,
                ProdutoId = 125
            },
            new ProdutoFranquia()
            {
                Id = 412,
                Valor = 33.9,
                FranquiaId = 6,
                ProdutoId = 126
            },
            new ProdutoFranquia()
            {
                Id = 413,
                Valor = 13.9,
                FranquiaId = 6,
                ProdutoId = 127
            },
            new ProdutoFranquia()
            {
                Id = 414,
                Valor = 13.9,
                FranquiaId = 6,
                ProdutoId = 128
            },
            new ProdutoFranquia()
            {
                Id = 415,
                Valor = 15.9,
                FranquiaId = 6,
                ProdutoId = 129
            },
            new ProdutoFranquia()
            {
                Id = 416,
                Valor = 15.9,
                FranquiaId = 6,
                ProdutoId = 130
            },
            new ProdutoFranquia()
            {
                Id = 417,
                Valor = 25.9,
                FranquiaId = 6,
                ProdutoId = 131
            },
            new ProdutoFranquia()
            {
                Id = 418,
                Valor = 28.9,
                FranquiaId = 6,
                ProdutoId = 132
            },
            new ProdutoFranquia()
            {
                Id = 419,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 133
            },
            new ProdutoFranquia()
            {
                Id = 420,
                Valor = 21.9,
                FranquiaId = 6,
                ProdutoId = 134
            },
            new ProdutoFranquia()
            {
                Id = 421,
                Valor = 28.9,
                FranquiaId = 6,
                ProdutoId = 135
            },
            new ProdutoFranquia()
            {
                Id = 422,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 136
            },
            new ProdutoFranquia()
            {
                Id = 423,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 137
            },
            new ProdutoFranquia()
            {
                Id = 424,
                Valor = 23.9,
                FranquiaId = 6,
                ProdutoId = 138
            },
            new ProdutoFranquia()
            {
                Id = 425,
                Valor = 28.9,
                FranquiaId = 6,
                ProdutoId = 139
            },
            new ProdutoFranquia()
            {
                Id = 426,
                Valor = 11.9,
                FranquiaId = 6,
                ProdutoId = 140
            },
            new ProdutoFranquia()
            {
                Id = 427,
                Valor = 16.9,
                FranquiaId = 6,
                ProdutoId = 141
            },
            new ProdutoFranquia()
            {
                Id = 428,
                Valor = 16.9,
                FranquiaId = 6,
                ProdutoId = 142
            },
            new ProdutoFranquia()
            {
                Id = 429,
                Valor = 18.9,
                FranquiaId = 6,
                ProdutoId = 143
            }
            );

            #endregion ProdutoFranquia

            #region Produto Ingrediente
            modelBuilder.Entity<ProdutoIngrediente>().HasData(
                  new ProdutoIngrediente()
                  {
                      Id = 1,
                      IngredienteId = 1,
                      ProdutoId = 1
                  },
            new ProdutoIngrediente()
            {
                Id = 2,
                IngredienteId = 2,
                ProdutoId = 1
            },
            new ProdutoIngrediente()
            {
                Id = 3,
                IngredienteId = 3,
                ProdutoId = 1
            },
            new ProdutoIngrediente()
            {
                Id = 4,
                IngredienteId = 4,
                ProdutoId = 1
            },
            new ProdutoIngrediente()
            {
                Id = 5,
                IngredienteId = 5,
                ProdutoId = 1
            },
            new ProdutoIngrediente()
            {
                Id = 6,
                IngredienteId = 6,
                ProdutoId = 2
            },
            new ProdutoIngrediente()
            {
                Id = 7,
                IngredienteId = 7,
                ProdutoId = 2
            },
            new ProdutoIngrediente()
            {
                Id = 8,
                IngredienteId = 8,
                ProdutoId = 2
            },
            new ProdutoIngrediente()
            {
                Id = 9,
                IngredienteId = 9,
                ProdutoId = 2
            },
            new ProdutoIngrediente()
            {
                Id = 10,
                IngredienteId = 10,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 11,
                IngredienteId = 11,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 12,
                IngredienteId = 12,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 13,
                IngredienteId = 13,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 14,
                IngredienteId = 14,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 15,
                IngredienteId = 15,
                ProdutoId = 3
            },
            new ProdutoIngrediente()
            {
                Id = 16,
                IngredienteId = 16,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 17,
                IngredienteId = 17,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 18,
                IngredienteId = 18,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 19,
                IngredienteId = 19,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 20,
                IngredienteId = 20,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 21,
                IngredienteId = 21,
                ProdutoId = 4
            },
            new ProdutoIngrediente()
            {
                Id = 22,
                IngredienteId = 22,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 23,
                IngredienteId = 23,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 24,
                IngredienteId = 24,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 25,
                IngredienteId = 25,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 26,
                IngredienteId = 26,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 27,
                IngredienteId = 27,
                ProdutoId = 5
            },
            new ProdutoIngrediente()
            {
                Id = 28,
                IngredienteId = 28,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 29,
                IngredienteId = 29,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 30,
                IngredienteId = 30,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 31,
                IngredienteId = 31,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 32,
                IngredienteId = 32,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 33,
                IngredienteId = 33,
                ProdutoId = 6
            },
            new ProdutoIngrediente()
            {
                Id = 34,
                IngredienteId = 34,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 35,
                IngredienteId = 35,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 36,
                IngredienteId = 36,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 37,
                IngredienteId = 37,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 38,
                IngredienteId = 38,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 39,
                IngredienteId = 39,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 40,
                IngredienteId = 40,
                ProdutoId = 7
            },
            new ProdutoIngrediente()
            {
                Id = 41,
                IngredienteId = 41,
                ProdutoId = 8
            },
            new ProdutoIngrediente()
            {
                Id = 42,
                IngredienteId = 42,
                ProdutoId = 8
            },
            new ProdutoIngrediente()
            {
                Id = 43,
                IngredienteId = 43,
                ProdutoId = 8
            },
            new ProdutoIngrediente()
            {
                Id = 44,
                IngredienteId = 44,
                ProdutoId = 8
            },
            new ProdutoIngrediente()
            {
                Id = 45,
                IngredienteId = 45,
                ProdutoId = 8
            },
            new ProdutoIngrediente()
            {
                Id = 46,
                IngredienteId = 46,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 47,
                IngredienteId = 47,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 48,
                IngredienteId = 48,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 49,
                IngredienteId = 49,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 50,
                IngredienteId = 50,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 51,
                IngredienteId = 51,
                ProdutoId = 9
            },
            new ProdutoIngrediente()
            {
                Id = 52,
                IngredienteId = 52,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 53,
                IngredienteId = 53,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 54,
                IngredienteId = 54,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 55,
                IngredienteId = 55,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 56,
                IngredienteId = 56,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 57,
                IngredienteId = 57,
                ProdutoId = 10
            },
            new ProdutoIngrediente()
            {
                Id = 58,
                IngredienteId = 58,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 59,
                IngredienteId = 59,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 60,
                IngredienteId = 60,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 61,
                IngredienteId = 61,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 62,
                IngredienteId = 62,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 63,
                IngredienteId = 63,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 64,
                IngredienteId = 64,
                ProdutoId = 11
            },
            new ProdutoIngrediente()
            {
                Id = 65,
                IngredienteId = 65,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 66,
                IngredienteId = 66,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 67,
                IngredienteId = 67,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 68,
                IngredienteId = 68,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 69,
                IngredienteId = 69,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 70,
                IngredienteId = 70,
                ProdutoId = 12
            },
            new ProdutoIngrediente()
            {
                Id = 71,
                IngredienteId = 71,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 72,
                IngredienteId = 72,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 73,
                IngredienteId = 73,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 74,
                IngredienteId = 74,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 75,
                IngredienteId = 75,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 76,
                IngredienteId = 76,
                ProdutoId = 13
            },
            new ProdutoIngrediente()
            {
                Id = 77,
                IngredienteId = 77,
                ProdutoId = 14
            },
            new ProdutoIngrediente()
            {
                Id = 78,
                IngredienteId = 78,
                ProdutoId = 14
            },
            new ProdutoIngrediente()
            {
                Id = 79,
                IngredienteId = 79,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 80,
                IngredienteId = 80,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 81,
                IngredienteId = 81,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 82,
                IngredienteId = 82,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 83,
                IngredienteId = 83,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 84,
                IngredienteId = 84,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 85,
                IngredienteId = 85,
                ProdutoId = 15
            },
            new ProdutoIngrediente()
            {
                Id = 86,
                IngredienteId = 86,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 87,
                IngredienteId = 87,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 88,
                IngredienteId = 88,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 89,
                IngredienteId = 89,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 90,
                IngredienteId = 90,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 91,
                IngredienteId = 91,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 92,
                IngredienteId = 92,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 93,
                IngredienteId = 93,
                ProdutoId = 16
            },
            new ProdutoIngrediente()
            {
                Id = 94,
                IngredienteId = 94,
                ProdutoId = 17
            },
            new ProdutoIngrediente()
            {
                Id = 95,
                IngredienteId = 95,
                ProdutoId = 17
            },
            new ProdutoIngrediente()
            {
                Id = 96,
                IngredienteId = 96,
                ProdutoId = 17
            },
            new ProdutoIngrediente()
            {
                Id = 97,
                IngredienteId = 97,
                ProdutoId = 17
            },
            new ProdutoIngrediente()
            {
                Id = 98,
                IngredienteId = 98,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 99,
                IngredienteId = 99,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 100,
                IngredienteId = 100,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 101,
                IngredienteId = 101,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 102,
                IngredienteId = 102,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 103,
                IngredienteId = 103,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 104,
                IngredienteId = 104,
                ProdutoId = 18
            },
            new ProdutoIngrediente()
            {
                Id = 105,
                IngredienteId = 105,
                ProdutoId = 19
            },
            new ProdutoIngrediente()
            {
                Id = 106,
                IngredienteId = 106,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 107,
                IngredienteId = 107,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 108,
                IngredienteId = 108,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 109,
                IngredienteId = 109,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 110,
                IngredienteId = 110,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 111,
                IngredienteId = 111,
                ProdutoId = 65
            },
            new ProdutoIngrediente()
            {
                Id = 112,
                IngredienteId = 112,
                ProdutoId = 76
            },
            new ProdutoIngrediente()
            {
                Id = 113,
                IngredienteId = 113,
                ProdutoId = 76
            },
            new ProdutoIngrediente()
            {
                Id = 114,
                IngredienteId = 114,
                ProdutoId = 76
            },
            new ProdutoIngrediente()
            {
                Id = 115,
                IngredienteId = 115,
                ProdutoId = 76
            },
            new ProdutoIngrediente()
            {
                Id = 116,
                IngredienteId = 116,
                ProdutoId = 76
            },
            new ProdutoIngrediente()
            {
                Id = 117,
                IngredienteId = 117,
                ProdutoId = 77
            },
            new ProdutoIngrediente()
            {
                Id = 118,
                IngredienteId = 118,
                ProdutoId = 77
            },
            new ProdutoIngrediente()
            {
                Id = 119,
                IngredienteId = 119,
                ProdutoId = 77
            },
            new ProdutoIngrediente()
            {
                Id = 120,
                IngredienteId = 120,
                ProdutoId = 77
            },
            new ProdutoIngrediente()
            {
                Id = 121,
                IngredienteId = 121,
                ProdutoId = 77
            },
            new ProdutoIngrediente()
            {
                Id = 122,
                IngredienteId = 122,
                ProdutoId = 77
            }

            );
            #endregion Produto Ingrediente

            modelBuilder.Entity<PedidoIngrediente>().HasNoKey();
        }
    }
}