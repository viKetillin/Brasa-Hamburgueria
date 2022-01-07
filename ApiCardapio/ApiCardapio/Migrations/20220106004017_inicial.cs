using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCardapio.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescricaoCategoria = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryDescription = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Whatsapp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Franquia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franquia", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeIngrediente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameIngredient = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeFormaPagamento = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Troco = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Entrega = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PontoCarne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePontoCarne = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoCarne", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImagemProduto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeProduto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoProduto = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DiaFuncionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiaSemana = table.Column<int>(type: "int", nullable: false),
                    Aberto = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FranquiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaFuncionamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiaFuncionamento_Franquia_FranquiaId",
                        column: x => x.FranquiaId,
                        principalTable: "Franquia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    PagamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Pagamento_PagamentoId",
                        column: x => x.PagamentoId,
                        principalTable: "Pagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoFranquia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    FranquiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoFranquia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoFranquia_Franquia_FranquiaId",
                        column: x => x.FranquiaId,
                        principalTable: "Franquia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoFranquia_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoIngrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoIngrediente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoIngrediente_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoIngrediente_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HorarioFuncionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    HoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DiaFuncionamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioFuncionamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorarioFuncionamento_DiaFuncionamento_DiaFuncionamentoId",
                        column: x => x.DiaFuncionamentoId,
                        principalTable: "DiaFuncionamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true),
                    PontoCarneId = table.Column<int>(type: "int", nullable: true),
                    ProdutoFranquiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_PontoCarne_PontoCarneId",
                        column: x => x.PontoCarneId,
                        principalTable: "PontoCarne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_ProdutoFranquia_ProdutoFranquiaId",
                        column: x => x.ProdutoFranquiaId,
                        principalTable: "ProdutoFranquia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PedidoIngrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: true),
                    ProdutoPedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PedidoIngrediente_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoIngrediente_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoIngrediente_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PedidoIngrediente_ProdutoPedido_ProdutoPedidoId",
                        column: x => x.ProdutoPedidoId,
                        principalTable: "ProdutoPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "CategoryDescription", "DescricaoCategoria" },
                values: new object[,]
                {
                    { 1, null, "Hambúrgueres" },
                    { 2, null, "Adicionais" },
                    { 3, null, "Bebidas" },
                    { 4, null, "Entradas e Porções" },
                    { 5, null, "Molhos" },
                    { 6, null, "Sobremesas" }
                });

            migrationBuilder.InsertData(
                table: "Franquia",
                columns: new[] { "Id", "Cidade", "Endereco", "Logo", "Telefone", "UF" },
                values: new object[,]
                {
                    { 6, "Bauru", "R. Luís Bleriot, 8-33 - Vila Aviação", "~/imagens/LogoBrasaBranco.png", "(14) 99720-0798", "SP" },
                    { 5, "Jaú", "R. Cônego Anselmo Valvekens, 48 - Centro", "~/imagens/LogoBrasaBranco.png", "99815-0116", "SP" },
                    { 4, "Botucatu", "Av. Leonardo Vilas Boas, 641 - Vila Nova Botucatu", "~/imagens/LogoBrasaBranco.png", "(14) 99673-6679", "SP" },
                    { 3, "Lençóis Paulista", "Av. Nove de Julho, 791 - Centro", "~/imagens/LogoBrasaBranco.png", "(14) 99691-0647", "SP" },
                    { 2, "Pederneiras", "Av. Brasil, 410 - Jd Bandeirantes", "~/imagens/LogoBrasaBranco.png", "(14) 99667-3737", "SP" },
                    { 1, "Barra Bonita", "Av. Caio Simões, 306 - Vila Sao Jose", "~/imagens/LogoBrasaBranco.png", "(14) 99606-1938", "SP" }
                });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "NameIngredient", "NomeIngrediente", "Valor" },
                values: new object[,]
                {
                    { 80, null, "Alface", 0.0 },
                    { 81, null, "Tomate", 0.0 },
                    { 82, null, "Cebola", 0.0 },
                    { 83, null, "Queijo prato", 0.0 },
                    { 84, null, "Catupiry", 0.0 },
                    { 90, null, "Queijo prato", 0.0 },
                    { 86, null, "Hambúrger de 180 gramas", 0.0 },
                    { 87, null, "Catupiry empanado crispy", 0.0 },
                    { 88, null, "Geléia de abacaxi com pimenta", 0.0 },
                    { 89, null, "Bacon", 0.0 },
                    { 79, null, "Hambúrguer de soja crispy", 0.0 },
                    { 85, null, "Pão 100% vegano", 0.0 },
                    { 78, null, "Queijo prato", 0.0 },
                    { 72, null, "Crispy de parmesão", 0.0 },
                    { 76, null, "Rúcula", 0.0 },
                    { 75, null, "Bacon", 0.0 },
                    { 74, null, "Pesto de tomate com parmesão e manjericão", 0.0 },
                    { 73, null, "Queijo prato", 0.0 },
                    { 91, null, "Rúcula", 0.0 },
                    { 71, null, "Hambúrger a milanesa", 0.0 },
                    { 70, null, "Maionese verde caseira", 0.0 },
                    { 69, null, "Queijo prato", 0.0 },
                    { 68, null, "Cebola roxa", 0.0 },
                    { 67, null, "Tomate", 0.0 },
                    { 66, null, "Alface", 0.0 },
                    { 65, null, "Hambúrguer de 180g", 0.0 },
                    { 64, null, "Acompanha fritas e refri de 237 ml", 0.0 },
                    { 77, null, "Hambúrguer de 180 gramas", 0.0 },
                    { 92, null, "Tomate", 0.0 },
                    { 98, null, "Futuro Burger 100% Plantas", 0.0 },
                    { 94, null, "2 hambúrguers de 100g", 0.0 },
                    { 122, null, "Acompanha fritas e refri de 200 ml", 0.0 },
                    { 121, null, "Picles", 0.0 },
                    { 120, null, "Molho taste", 0.0 },
                    { 119, null, "Queijo prato", 0.0 },
                    { 118, null, "Alface", 0.0 },
                    { 117, null, "Hambúrguer de costela", 0.0 },
                    { 116, null, "Acompanha fritas e refri de 200 ml", 0.0 },
                    { 115, null, "Cebola caramelizada", 0.0 },
                    { 114, null, "Queijo cheddar", 0.0 },
                    { 113, null, "Rúcula", 0.0 },
                    { 112, null, "Hambúrguer de costela", 0.0 },
                    { 111, null, "Pão francês coberto de queijo", 0.0 },
                    { 110, null, "Tomate seco", 0.0 },
                    { 93, null, "Cebola roxa", 0.0 },
                    { 109, null, "Rúcula", 0.0 },
                    { 107, null, "Creme de gorgonzola", 0.0 },
                    { 106, null, "Hambúrguer de 180g de linguiça mista artesanal", 0.0 },
                    { 105, null, "Creme de queijo (Cheddar, prato e gorgonzola)", 0.0 },
                    { 104, null, "Tofu temperado", 0.0 },
                    { 103, null, "Champignon salteado no azeite", 0.0 },
                    { 102, null, "Cebola roxa", 0.0 },
                    { 101, null, "Tomate", 0.0 },
                    { 100, null, "Alface", 0.0 },
                    { 99, null, "Maionese verde vegana", 0.0 },
                    { 63, null, "Molho", 0.0 },
                    { 97, null, "Geléia de pimenta", 0.0 },
                    { 96, null, "Bacon", 0.0 },
                    { 95, null, "Queijo cheddar", 0.0 },
                    { 108, null, "Cebola cripsy", 0.0 },
                    { 62, null, "Queijo prato", 0.0 },
                    { 57, null, "Acompanha refri 237 ml", 0.0 },
                    { 60, null, "Tomate", 0.0 },
                    { 27, null, "Provolone empanado e frito", 0.0 },
                    { 26, null, "Ketchup de goiaba flambado na cachaça", 0.0 },
                    { 25, null, "Queijo prato", 0.0 },
                    { 24, null, "Tomate", 0.0 },
                    { 23, null, "Alface", 0.0 },
                    { 22, null, "Hambúrguer de 180g", 0.0 },
                    { 21, null, "Tomate", 0.0 },
                    { 20, null, "Cebola chapeada", 0.0 },
                    { 19, null, "Rúcula", 0.0 },
                    { 18, null, "Bacon", 0.0 },
                    { 17, null, "Gorgonzola", 0.0 },
                    { 16, null, "Hambúrguer de 180g", 0.0 },
                    { 15, null, "Tomate", 0.0 },
                    { 14, null, "Cebola", 0.0 },
                    { 13, null, "Rúcula", 0.0 },
                    { 12, null, "Queijo cheddar", 0.0 },
                    { 11, null, "Molho barbecue", 0.0 },
                    { 10, null, "Hambúrguer de 180g bacon", 0.0 },
                    { 9, null, "Couve crispy", 0.0 },
                    { 8, null, "Catupiry", 0.0 },
                    { 7, null, "Bacon", 0.0 },
                    { 6, null, "Hambúrguer de frango sem conservante", 0.0 },
                    { 5, null, "Tomate", 0.0 },
                    { 4, null, "Alface", 0.0 },
                    { 3, null, "Farofa de bacon", 0.0 },
                    { 2, null, "Creme cheddar artesanal", 0.0 },
                    { 1, null, "Hambúrguer de 200g", 0.0 },
                    { 28, null, "Hambúrguer de costela de 200g", 0.0 },
                    { 61, null, "Ramas", 0.0 },
                    { 29, null, "Rúcula", 0.0 },
                    { 31, null, "Queijo minas", 0.0 },
                    { 59, null, "Alface", 0.0 },
                    { 58, null, "Hambúrguer de 150g", 0.0 },
                    { 56, null, " maionese de bacon", 0.0 },
                    { 55, null, "Queijo cheddar", 0.0 },
                    { 54, null, "Cebola", 0.0 },
                    { 53, null, "Rúcula", 0.0 },
                    { 52, null, "Hambúrguer de 150g", 0.0 },
                    { 51, null, "Molho chipotle com especiarias e nachos", 0.0 },
                    { 50, null, "Queijo prato", 0.0 },
                    { 49, null, "Cebola", 0.0 },
                    { 48, null, "Tomate", 0.0 },
                    { 47, null, "Alface", 0.0 },
                    { 30, null, "Tomate", 0.0 },
                    { 46, null, "Hambúrguer de 180g", 0.0 },
                    { 44, null, "Catupiry", 0.0 },
                    { 32, null, "Molho lemon pepper com mel", 0.0 },
                    { 33, null, "Onion rings", 0.0 },
                    { 34, null, "Hamburguer de carne da Fazenda do Futuro", 0.0 },
                    { 35, null, "Pão é 100% vegano", 0.0 },
                    { 45, null, "Alho frito e bacon", 0.0 },
                    { 37, null, "Tomate", 0.0 },
                    { 36, null, "Alface", 0.0 },
                    { 39, null, "Queijo prato", 0.0 },
                    { 40, null, "Catupiry", 0.0 },
                    { 41, null, "Hamburguer de carne de 180g", 0.0 },
                    { 42, null, "Alface", 0.0 },
                    { 43, null, "Tomate", 0.0 },
                    { 38, null, "Cebola", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "PontoCarne",
                columns: new[] { "Id", "NomePontoCarne" },
                values: new object[,]
                {
                    { 2, "Ao ponto" },
                    { 1, "Mal passada" },
                    { 3, "Bem passada" }
                });

            migrationBuilder.InsertData(
                table: "DiaFuncionamento",
                columns: new[] { "Id", "Aberto", "DiaSemana", "FranquiaId" },
                values: new object[,]
                {
                    { 42, true, 0, 6 },
                    { 18, true, 4, 3 },
                    { 17, true, 3, 3 },
                    { 16, false, 2, 3 },
                    { 15, false, 1, 3 },
                    { 14, true, 0, 2 },
                    { 13, true, 6, 2 },
                    { 12, true, 5, 2 },
                    { 11, true, 4, 2 },
                    { 19, true, 5, 3 },
                    { 10, true, 3, 2 },
                    { 8, false, 1, 2 },
                    { 7, true, 0, 1 },
                    { 6, true, 6, 1 },
                    { 5, true, 5, 1 },
                    { 4, true, 4, 1 },
                    { 3, true, 3, 1 },
                    { 2, false, 2, 1 },
                    { 1, false, 1, 1 },
                    { 9, false, 2, 2 },
                    { 20, true, 6, 3 },
                    { 41, true, 6, 6 },
                    { 22, false, 1, 4 },
                    { 21, true, 0, 3 },
                    { 40, true, 5, 6 },
                    { 39, true, 4, 6 },
                    { 38, true, 3, 6 },
                    { 37, false, 2, 6 },
                    { 35, true, 0, 5 },
                    { 34, true, 6, 5 },
                    { 33, true, 5, 5 },
                    { 32, true, 4, 5 },
                    { 36, false, 1, 6 },
                    { 30, false, 2, 5 },
                    { 29, false, 1, 5 },
                    { 28, true, 0, 4 },
                    { 27, true, 6, 4 },
                    { 26, true, 5, 4 },
                    { 25, true, 4, 4 },
                    { 24, true, 3, 4 },
                    { 23, false, 2, 4 },
                    { 31, true, 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "DescricaoProduto", "ImagemProduto", "NomeProduto", "ProductDescription" },
                values: new object[,]
                {
                    { 52, 4, "Meia porção de fritas e 8 aneis de cebola.", null, "FRITAS E ANEIS DE CEBOLA", null },
                    { 53, 4, "Porção de 4 palitos e 6 nuggets de frango.", null, "PALITO DE MUSSARELA E NUGGETS", null },
                    { 54, 4, "Porção de 15 anéis de cebola.", null, "ANEIS DE CEBOLA", null },
                    { 74, 4, "Porção de 9 bolinhos de gorgonzola.", null, "BOLINHO DE GORGONZOLA", null },
                    { 72, 4, "350g fritas.", null, "FRITAS", null },
                    { 73, 4, "Porção de 9 bolinhos de bacalhau.", null, "BOLINHO DE BACALHAU", null },
                    { 75, 4, "Porção de 9 travesseiros de muçarela.", null, "TRAVESSEIROS DE MUÇARELA", null },
                    { 51, 4, "350g fritas e bacon.", null, "FRITAS COM BACON", null },
                    { 55, 4, "Porção de 10 bolinhos de costela.", null, "BOLINHO DE COSTELA", null },
                    { 143, 3, null, null, "DOSES  - GIN TANQUERAY", null },
                    { 133, 3, "Vodka, xarope de açucar e espuma de gengibre.", null, "COQUETÉIS - MOSCOW MULE", null },
                    { 141, 3, null, null, "DOSES  - WHISKY RED LABEL", null },
                    { 140, 3, null, null, "DOSES  - CAMPARI", null },
                    { 139, 3, "Gin, Campari, Vermute Rosso e twist de laranja.", null, "CLÁSSICOS  - NEGRONI", null },
                    { 138, 3, "Tequila, limão, um lance de curaçau e borda com sal.", null, "CLÁSSICOS  - MARGARITA", null },
                    { 137, 3, "Whisky, limão maceradp com açucar e borda com sal.", null, "CLÁSSICOS  - WHISKY SOUR", null },
                    { 136, 3, "Rum, hortelã macerado com açucar, suco de limão e água com gás.", null, "CLÁSSICOS  - MOJITO", null },
                    { 135, 3, "Frisante rosé, uva, morango e kiwi.", null, "COQUETÉIS - MOSCATEL COM FRUTAS", null },
                    { 134, 3, "Vinho com morango, abacaxi ou maracujá e leite condensado.", null, "COQUETÉIS - ESPANHOLA", null },
                    { 78, 4, "350g fritas.", null, "BATATA RÚSTICA", null },
                    { 132, 3, "Vodka, xarope de pêssego, suco de laranja e grenadine.", null, "COQUETÉIS - SEX ON THE BEACH", null },
                    { 131, 3, "um, suco de abacaxi, leite de côco e leite condensado.", null, "COQUETÉIS - PIÑA COLADA", null },
                    { 142, 3, null, null, "DOSES  - VODKA ABSOLUT", null },
                    { 91, 4, null, null, "FRITAS COM CREME CHEDDAR", null },
                    { 101, 4, null, null, "BATATA DE CARINHA E NUGGETS COM MOLHO ROSÉ", null },
                    { 93, 4, null, null, "FRITAS COM CREME GORGONZOLA", null },
                    { 90, 6, "Brownie de chocolate, sorvete de creme e calda de chocolate.", null, "BRASA BROWNIE", null },
                    { 89, 6, "Ganache de chocolate meio amargo, sorvete  de leite ninho trufado e farofa de bolacha negresco.", null, "TAÇA NEGRESCO", null },
                    { 88, 6, "2 bolas de sorvete, cobertura de chocolate, canudo biju waffer e confetes.", null, "SORVEKIDS", null },
                    { 79, 6, null, null, "MILK SHAKE", null },
                    { 130, 3, "Suco de abacaxi, suco de maracuja, leite condensado e cobertura de morango.", null, "COQUETÉIS SEM ÁLCOOL - PIPELINE", null },
                    { 63, 6, "8 MINI churros acompanhado de doce de leite ou nutella", null, "MINI CHURROS", null },
                    { 62, 5, null, null, "GELÉIA DE PIMENTA", null },
                    { 61, 5, null, null, "CHEDDAR (FATIA)", null },
                    { 60, 5, null, null, "MAIONESE VERDE", null },
                    { 59, 5, null, null, "QUEIJO PRATO (FATIA)", null },
                    { 92, 4, null, null, "FRITAS COM CATUPUTY", null },
                    { 58, 5, null, null, "CATUPIRY ORIGINAL", null },
                    { 56, 5, null, null, "CREME CHEDDAR", null },
                    { 103, 4, "Coxinha, bolinho de gorognzola, mini quibe.", null, "MIX DE SALGADINHO ARTESANAL", null },
                    { 102, 4, null, null, "TÁBUA DE FRIOS", null },
                    { 100, 4, null, null, "BATATA RÚSTICA COM ERVAS FINAS", null },
                    { 99, 4, null, null, "CROQUETE DE CARNE NA CAMA DE CREAM CHEESE ", null },
                    { 98, 4, null, null, "FRANGO ARTESANAL NO PALITO COM MAIONESE VERDE", null },
                    { 97, 4, null, null, "MUSSARELA DE BÚFALA CRISPY COM GELÉIA DE PIMENTA", null },
                    { 96, 4, null, null, "BOLINHO DE COSTELA SERVIDO COM GELÉIA DE ABACAXI COM PIMENTA", null },
                    { 95, 4, null, null, "TRAVESSEIROS DE QUEIJO COM MOLHO BARBECUE", null },
                    { 94, 4, "Rúcula, alface, tomate, cebola roxa, palmito, parmesão ralado e crouton.", null, "SALADA MIX", null },
                    { 57, 5, null, null, "CREME DE GORGONZOLA", null },
                    { 64, 6, "Banana flambada na cachaça com sorvete e suspiro", null, "BRASA SPLIT", null },
                    { 129, 3, "Suco de uva, suco de abacaxi e leite condensado.", null, "COQUETÉIS SEM ÁLCOOL - SPANISH", null },
                    { 127, 3, "Suco de laranja, suco de abacaxi, soda limonada e um lance de groselha.", null, "COQUETÉIS SEM ÁLCOOL - CAIPIRINHA TEEN", null },
                    { 22, 2, null, null, "MAIONESE VERDE", null },
                    { 23, 2, null, null, "SALADA OU CEBOLA ROXA", null },
                    { 24, 2, null, null, "CATUPIRY ORIGINAL", null },
                    { 25, 2, null, null, "GELÉIA DE PIMENTA", null },
                    { 26, 2, null, null, "QUEIJO PRATO (2 FATIAS)", null },
                    { 27, 2, null, null, "QUEIJO CHEDDAR (2 FATIAS)", null },
                    { 28, 2, null, null, "BACON", null },
                    { 29, 2, null, null, "ANEL DE CEBOLA (4)", null },
                    { 30, 2, null, null, "PROVOLONE CRISPY", null },
                    { 31, 2, null, null, "KETCHUP DE GOIABADA", null },
                    { 32, 2, null, null, "CREME GORGONZOLA", null },
                    { 33, 2, null, null, "MOLHO BARBECUE", null },
                    { 34, 2, null, null, "PICLES", null },
                    { 35, 2, null, null, "OVO", null },
                    { 66, 2, null, null, "GELÉIA DE ABACAXI", null },
                    { 67, 2, null, null, "MAIONESE DE BACON", null },
                    { 68, 2, null, null, "CATUPIRY CRISPY", null },
                    { 80, 2, null, null, "HAMBÚRGUER 100G", null },
                    { 81, 2, null, null, "HAMBÚRGUER COSTELA 200G", null },
                    { 21, 2, null, null, "CREME CHEDDAR", null },
                    { 82, 2, null, null, "HAMBÚRGUER FRANGO", null },
                    { 20, 2, null, null, "HAMBÚRGUER 180G", null },
                    { 77, 1, "Hambúrguer de costela, alface, queijo prato, molho taste e picles. Acompanha fritas e refri de 200 ml.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/44ed955360fc4e8287820cae43e47479.png", "COMBO TASTE", null },
                    { 2, 1, "Hambúrguer de Frango sem conservante, bacon, catupiry original, couve crispy.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/d048fb80037a41b285255a7aaa472967.png", "BRASA CHICKEN CRISPY", null },
                    { 3, 1, "Hambúrguer de 180g, bacon, molho barbecue, queijo cheddar, rúcula, cebola e tomate.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/2673656e9d7d454c80cc52b32482085e.png", "BARBECUE", null },
                    { 4, 1, "Hambúrguer de 180g, bacon, gorgonzola, rúcula, cebola chapeada e tomate fresco.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/6b676f1af13e4a1199c8905e9badc4b7.png", "BRASA GORGONZOLA", null },
                    { 5, 1, "Hambúrguer de 180g, alface, tomate, queijo prato, ketchup de goiaba flambado na cachaça, provolone empanado e frito", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/3fcc9822405b489883223c3f218b854c.png", "BRASA PROVOLONE", null },
                    { 6, 1, "Hambúrguer de costela de 200g, rúcula, tomate, queijo minas, molho lemon pepper com mel e onion rings.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/56baea49fb7e49e6a354eaec36809d2d.png", "BRASA RIBS", null },
                    { 7, 1, "Hamburguer de carne da Fazenda do Futuro, pão é 100% vegano, alface, tomate, cebola, queijo prato e catupiry.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9ee0660e169a40ef8057c8fda197ba35.png", "BRASA FUTURO", null },
                    { 8, 1, "Hamburguer de carne de 180g, alface, tomate, catupiry, alho frito e bacon.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/da607e7b4dd94ddea962e7a69834e305.png", "BRASAPIRY", null },
                    { 9, 1, "Hambúrguer de 180g, alface, tomate, cebola, queijo prato, molho chipotle com especiarias e nachos.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/220ee267043f47c0bb0bffe7892b8f72.png", "BRASEIRO", null },
                    { 10, 1, "Hambúrguer de 150g, rúcula, cebola, queijo cheddar,  maionese de bacon. Acompanha refri 237 ml.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9adcc0e66c204cc8ad68a1626808d9ea.png", "COMBO CHEDDAR", null },
                    { 11, 1, "Hambúrguer de 150g, alface, tomate, ramas, queijo prato, molho! Acompanha fritas e refri de 237 ml.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/2466c36ec52742e3a2a53dcc671eba96.png", "COMBO ROSE", null },
                    { 12, 1, "Hambúrguer de 180g, alface, tomate, cebola roxa, queijo prato e maionese verde caseira.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/472f4dd5cf3646e4b8e60ec7259fa6aa.png", "DE BOA", null },
                    { 13, 1, "Hambúrger a milanesa, crispy de parmesão, queijo prato, pesto de tomate com parmesão e manjericão,bacon e rúcula.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/c4c4bd4620b048f08a5e5330bf9d5da1.png", "BRASA ESPECIAL", null },
                    { 14, 1, "Hambúrguer de 180 gramas, queijo prato.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/9640153ac30c4d7d9d2d8cb37aa5a630.png", "KIDS", null },
                    { 15, 1, "Hambúrguer de soja crispy, alface, tomate, cebola, queijo prato, catupiry e pão 100% vegano.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/631a0a50f74e493cb6e59e49f65fbcb5.png", "VEGETARIANO", null },
                    { 16, 1, "Hambúrger de 180 gramas, catupiry empanado crispy, geléia de abacaxi com pimenta, bacon, queijo prato, rúcula, tomate e cebola roxa.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/b481b6dcb40d4ac68831a49bad35360f.png", "BRASA CALIFÓRNIA", null },
                    { 17, 1, "2 hambúrguers de 100g, queijo cheddar, bacon e geléia de pimenta.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/c8f4943997624b90b9c5a73d77a18c89.png", "SMASH BRASA", null },
                    { 18, 1, "Futuro Burger 100% Plantas, maionese verde vegana, alface, tomate, cebola roxa, champignon salteado no azeite e tofu temperado.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/934f0175a0f84b95b4dc4a6f1b6cf7be.png", "BRASA VEGANO", null },
                    { 65, 1, "Hambúrguer de 180g de linguiça mista artesanal, creme de gorgonzola, cebola cripsy, rúcula , tomate seco no pão francês coberto de queijo.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/55e990368f1549d182adffe488fe50ec.png", "BRASA JAÚ", null },
                    { 76, 1, "Hambúrguer de costela, rúcula, queijo cheddar e cebola caramelizada. Acompanha fritas e refri de 200 ml.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/ceada4a56c8f42488d6bf37ab620e269.png", "COMBO CARAMELIZADO", null },
                    { 19, 2, "Creme de queijo (Cheddar, prato e gorgonzola).", null, "BRASA BOWL", null },
                    { 83, 2, null, null, "ALHO FRITO", null },
                    { 84, 2, null, null, "MOLHO ROSE", null },
                    { 85, 2, null, null, "BATATA EXTRA", null },
                    { 108, 3, null, null, "SUCO POLPA 400 ML - MORANGO", null },
                    { 109, 3, null, null, "SUCO POLPA 400 ML - MARACUJÁ", null },
                    { 110, 3, "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.", null, "CAIPIRINHA - VELHO BARREIRO", null },
                    { 111, 3, "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.", null, "CAIPIROSKA - SAGATIBA", null },
                    { 112, 3, "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.", null, "CAIPIROSKA - SMIRNOFF", null },
                    { 113, 3, "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.", null, "CAIPIROSKA - ABSOLUT", null },
                    { 114, 3, "Sabores: Limão c/ manjericão, kiwi, morango, maracujá, abacaxi c/ pimenta, banana ou rúcula.", null, "SAQUERINHAS - SAQUÊ", null },
                    { 115, 3, null, null, "CERVEJA LONG NECK EISENBAHN PILSEN", null },
                    { 116, 3, null, null, "CERVEJA LONG NECK EISENBAHN IPA", null },
                    { 117, 3, null, null, "CERVEJA 600 ML BADEN BADEN GOLDEN", null },
                    { 118, 3, null, null, "CERVEJA 600 ML BADEN BADEN WITBIER", null },
                    { 119, 3, "Limão siciliano, manjericão, suco de groselha e aqua mix.", null, "PINK 1 - LEMONADE (500 ML)", null },
                    { 120, 3, "Laranja com frutas vermelhas e aqua mix.", null, "PINK 2 - LEMONADE (500 ML)", null },
                    { 121, 3, "Limão siciliano, abacaxi, suco de groselha e aqua mix.", null, "PINK 3 - LEMONADE (500 ML)", null },
                    { 122, 3, "Red Bull tropical ou Red Bull melância.", null, "GIN TÔNICA TROPICAL", null },
                    { 123, 3, "Tônica e maça verde.", null, "GIN MAÇA VERDE", null },
                    { 124, 3, "Escolha 3 opcões: Blueberry, Cardamomo, Zimbro, Anis Estrelado, Canela.", null, "GIN ESPECIARIAS", null },
                    { 125, 3, "Geléia de abacaxi com pimenta e canela.", null, "GIN COM FRUTAS", null },
                    { 126, 3, null, null, "GIN COM FRUTAS VERMELHAS", null },
                    { 107, 3, null, null, "SUCO POLPA 400 ML - ABACAXI C/ HORTELÃ", null },
                    { 106, 3, null, null, "SUCO NATURAL 400 ML - LIMÃO", null },
                    { 105, 3, null, null, "SUCO NATURAL 400 ML - LARANJA", null },
                    { 104, 3, null, null, "RED BULL (Original, Tropical ou Melancia)", null },
                    { 86, 2, null, null, "NACHOS", null },
                    { 87, 2, null, null, "FAROFA DE BACON", null },
                    { 36, 3, null, "https://www.seijisushi.com.br/galerias/produtos/1000/10032016_090358_222_cerveja_heineken_long_neck_355_ml.jpg", "CERVEJA LONG NECK HEINEKEN", null },
                    { 37, 3, null, "https://www.budweiser.com.br/sites/g/files/wnfebl2801/files/Budweiser/Cervejas/990ml-min.png", "CERVEJA LONG NECK BUDWEISER", null },
                    { 38, 3, null, "https://www.freepnglogos.com/uploads/corona-png-logo/corona-bottle-transparent-png-logo-27.png", "CERVEJA LONG NECK CORONA", null },
                    { 39, 3, null, "https://www.eisenbahn.com.br/assets/images/pilsen-bottle.png", "CERVEJA LONG NECK EISENBAHN", null },
                    { 40, 3, null, null, "ÁGUA COM GÁS", null },
                    { 41, 3, null, null, "ÁGUA SEM GÁS", null },
                    { 42, 3, null, null, "CERVEJA 600 ML ORIGINAL", null },
                    { 128, 3, "Suco de laranja, suco de pêssego e um lance de groselha.", null, "COQUETÉIS SEM ÁLCOOL - KISS ON THE BEACH", null },
                    { 43, 3, null, null, "CERVEJA 600 ML COLORADO APPIA", null },
                    { 45, 3, null, null, "REFRIGERANTE - COCA-COLA", null },
                    { 46, 3, null, null, "REFRIGERANTE - FANTA", null },
                    { 47, 3, null, null, "REFRIGERANTE - SODA/SPRITE", null },
                    { 48, 3, null, null, "REFRIGERANTE - TONICA", null },
                    { 49, 3, null, null, "REFRIGERANTE - GUARANÁ SCHWEEPS", null },
                    { 50, 3, null, null, "SUCO DE LARANJA", null },
                    { 69, 3, null, null, "SUCO DE LARANJA VIAGEM 300ML", null },
                    { 70, 3, null, null, "H2O LIMÃO / LIMONETO", null },
                    { 71, 3, null, null, "CHOPP 300 ML (BROTAS BEER PILSEN)", null },
                    { 44, 3, null, null, "REFRIGERANTE - GUARANÁ ANTARTICA", null },
                    { 1, 1, "Hambúrguer de 200g, creme cheddar artesanal, farofa de bacon, alface e tomate.", "https://yata-apix-12c626c1-c4e5-440f-9a8a-6cb1537cb8fa.lss.locawebcorp.com.br/8f7e76090120440bb61f4d5fb0107f3a.png", "Brasão", null }
                });

            migrationBuilder.InsertData(
                table: "HorarioFuncionamento",
                columns: new[] { "Id", "DiaFuncionamentoId", "HoraFim", "HoraInicio" },
                values: new object[,]
                {
                    { 42, 42, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, null, null },
                    { 15, 15, null, null },
                    { 14, 14, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, null, null },
                    { 7, 7, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, null, null },
                    { 1, 1, null, null },
                    { 9, 9, null, null },
                    { 20, 20, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 41, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 22, null, null },
                    { 21, 21, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 40, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 39, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 37, null, null },
                    { 36, 36, null, null },
                    { 35, 35, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 34, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 33, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 32, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 38, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 30, null, null },
                    { 29, 29, null, null },
                    { 28, 28, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 27, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 26, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 25, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 24, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 31, new DateTime(2021, 8, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 23, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProdutoFranquia",
                columns: new[] { "Id", "FranquiaId", "ProdutoId", "Valor" },
                values: new object[,]
                {
                    { 345, 6, 44, 5.0 },
                    { 45, 1, 45, 5.0 },
                    { 150, 3, 45, 5.0 },
                    { 273, 5, 45, 5.0 },
                    { 346, 6, 45, 5.0 },
                    { 347, 6, 46, 5.0 },
                    { 151, 3, 46, 5.0 },
                    { 274, 5, 46, 5.0 },
                    { 47, 1, 47, 5.0 },
                    { 152, 3, 47, 5.0 },
                    { 272, 5, 44, 5.0 },
                    { 46, 1, 46, 5.0 },
                    { 149, 3, 44, 5.0 },
                    { 269, 5, 41, 4.0 },
                    { 344, 6, 43, 18.0 },
                    { 271, 5, 43, 18.0 },
                    { 43, 1, 43, 18.0 },
                    { 343, 6, 42, 12.0 },
                    { 270, 5, 42, 12.0 },
                    { 42, 1, 42, 12.0 },
                    { 342, 6, 41, 4.0 },
                    { 275, 5, 47, 5.0 },
                    { 148, 3, 41, 3.5 },
                    { 41, 1, 41, 3.0 },
                    { 341, 6, 40, 4.0 },
                    { 268, 5, 40, 4.0 },
                    { 147, 3, 40, 4.0 },
                    { 44, 1, 44, 5.0 },
                    { 348, 6, 47, 5.0 },
                    { 278, 5, 50, 6.5 },
                    { 153, 3, 48, 5.0 },
                    { 402, 6, 116, 10.0 },
                    { 401, 6, 115, 10.0 },
                    { 400, 6, 114, 21.899999999999999 },
                    { 399, 6, 113, 25.899999999999999 },
                    { 398, 6, 112, 21.899999999999999 },
                    { 397, 6, 111, 22.899999999999999 },
                    { 396, 6, 110, 48.899999999999999 },
                    { 395, 6, 109, 6.5 },
                    { 394, 6, 108, 6.5 },
                    { 393, 6, 107, 6.5 },
                    { 392, 6, 106, 48.899999999999999 },
                    { 391, 6, 105, 6.5 },
                    { 390, 6, 104, 12.0 },
                    { 48, 1, 48, 5.0 },
                    { 364, 6, 71, 7.9000000000000004 },
                    { 363, 6, 70, 6.5 },
                    { 297, 5, 70, 5.0 },
                    { 174, 3, 70, 5.0 },
                    { 296, 5, 69, 4.0 },
                    { 173, 3, 69, 5.0 },
                    { 40, 1, 40, 3.5 },
                    { 155, 3, 50, 6.5 },
                    { 50, 1, 50, 6.5 },
                    { 277, 5, 49, 5.0 },
                    { 154, 3, 49, 5.0 },
                    { 49, 1, 49, 5.0 },
                    { 349, 6, 48, 5.0 },
                    { 276, 5, 48, 5.0 },
                    { 298, 5, 71, 7.9000000000000004 },
                    { 267, 5, 39, 10.0 },
                    { 36, 1, 36, 9.0 },
                    { 340, 6, 38, 10.0 },
                    { 145, 3, 34, 3.5 },
                    { 97, 2, 34, 3.5 },
                    { 34, 1, 34, 3.5 },
                    { 335, 6, 33, 3.0 },
                    { 261, 5, 33, 2.5 },
                    { 212, 4, 33, 3.0 },
                    { 144, 3, 33, 2.5 },
                    { 96, 2, 33, 2.5 },
                    { 33, 1, 33, 2.5 },
                    { 334, 6, 32, 6.0 },
                    { 260, 5, 32, 6.0 },
                    { 211, 4, 32, 6.0 },
                    { 143, 3, 32, 6.0 },
                    { 213, 4, 34, 3.5 },
                    { 95, 2, 32, 5.0 },
                    { 333, 6, 31, 3.5 },
                    { 259, 5, 31, 4.0 },
                    { 210, 4, 31, 4.0 },
                    { 142, 3, 31, 4.0 },
                    { 94, 2, 31, 4.0 },
                    { 31, 1, 31, 4.0 },
                    { 332, 6, 30, 7.0 },
                    { 258, 5, 30, 6.0 },
                    { 209, 4, 30, 7.0 },
                    { 141, 3, 30, 6.0 },
                    { 93, 2, 30, 6.0 },
                    { 30, 1, 30, 6.0 },
                    { 331, 6, 29, 3.0 },
                    { 32, 1, 32, 6.0 },
                    { 262, 5, 34, 3.5 },
                    { 336, 6, 34, 3.5 },
                    { 35, 1, 35, 2.5 },
                    { 266, 5, 38, 9.0 },
                    { 38, 1, 38, 9.0 },
                    { 339, 6, 37, 10.0 },
                    { 265, 5, 37, 8.0 },
                    { 37, 1, 37, 8.0 },
                    { 338, 6, 36, 10.0 },
                    { 264, 5, 36, 8.0 },
                    { 403, 6, 117, 18.0 },
                    { 373, 6, 87, 2.5 },
                    { 372, 6, 86, 2.5 },
                    { 371, 6, 85, 5.0 },
                    { 370, 6, 84, 3.0 },
                    { 369, 6, 83, 2.0 },
                    { 368, 6, 82, 7.0 },
                    { 367, 6, 81, 11.0 },
                    { 366, 6, 80, 7.0 },
                    { 362, 6, 68, 9.0 },
                    { 295, 5, 68, 8.0 },
                    { 172, 3, 68, 8.0 },
                    { 361, 6, 67, 3.5 },
                    { 294, 5, 67, 3.5 },
                    { 171, 3, 67, 3.5 },
                    { 293, 5, 66, 3.5 },
                    { 170, 3, 66, 3.5 },
                    { 337, 6, 35, 2.0 },
                    { 263, 5, 35, 2.5 },
                    { 214, 4, 35, 3.5 },
                    { 146, 3, 35, 2.5 },
                    { 98, 2, 35, 2.5 },
                    { 39, 1, 39, 8.0 },
                    { 404, 6, 118, 18.0 },
                    { 414, 6, 128, 13.9 },
                    { 406, 6, 120, 13.9 },
                    { 287, 5, 59, 3.0 },
                    { 223, 4, 59, 3.0 },
                    { 164, 3, 59, 3.0 },
                    { 107, 2, 59, 3.0 },
                    { 59, 1, 59, 3.0 },
                    { 354, 6, 58, 5.0 },
                    { 286, 5, 58, 5.0 },
                    { 222, 4, 58, 5.0 },
                    { 163, 3, 58, 5.0 },
                    { 106, 2, 58, 5.0 },
                    { 58, 1, 58, 5.0 },
                    { 353, 6, 57, 7.0 },
                    { 285, 5, 57, 6.0 },
                    { 355, 6, 59, 3.0 },
                    { 221, 4, 57, 7.0 },
                    { 105, 2, 57, 7.0 },
                    { 57, 1, 57, 7.0 },
                    { 352, 6, 56, 6.0 },
                    { 284, 5, 56, 4.5 },
                    { 220, 4, 56, 6.0 },
                    { 161, 3, 56, 4.5 },
                    { 104, 2, 56, 6.0 },
                    { 56, 1, 56, 6.0 },
                    { 389, 6, 103, 24.0 },
                    { 388, 6, 102, 35.0 },
                    { 387, 6, 101, 20.0 },
                    { 386, 6, 100, 15.0 },
                    { 385, 6, 99, 20.0 },
                    { 162, 3, 57, 6.0 },
                    { 384, 6, 98, 15.0 },
                    { 60, 1, 60, 3.0 },
                    { 165, 3, 60, 3.5 },
                    { 376, 6, 90, 16.0 },
                    { 375, 6, 89, 16.0 },
                    { 374, 6, 88, 11.0 },
                    { 179, 3, 79, 15.0 },
                    { 360, 6, 64, 16.0 },
                    { 228, 4, 64, 14.0 },
                    { 169, 3, 64, 15.0 },
                    { 359, 6, 63, 13.0 },
                    { 291, 5, 63, 13.0 },
                    { 227, 4, 63, 13.0 },
                    { 168, 3, 63, 13.0 },
                    { 111, 2, 63, 13.0 },
                    { 63, 1, 63, 13.0 },
                    { 108, 2, 60, 3.0 },
                    { 358, 6, 62, 3.0 },
                    { 226, 4, 62, 3.0 },
                    { 167, 3, 62, 3.5 },
                    { 110, 2, 62, 3.0 },
                    { 62, 1, 62, 3.0 },
                    { 357, 6, 61, 3.0 },
                    { 289, 5, 61, 3.0 },
                    { 225, 4, 61, 3.0 },
                    { 166, 3, 61, 3.0 },
                    { 109, 2, 61, 3.0 },
                    { 61, 1, 61, 3.0 },
                    { 356, 6, 60, 3.0 },
                    { 288, 5, 60, 3.5 },
                    { 224, 4, 60, 3.0 },
                    { 290, 5, 62, 3.5 },
                    { 405, 6, 119, 13.9 },
                    { 383, 6, 97, 18.0 },
                    { 381, 6, 95, 18.0 },
                    { 350, 6, 51, 28.0 },
                    { 279, 5, 51, 26.0 },
                    { 215, 4, 51, 27.0 },
                    { 156, 3, 51, 26.0 },
                    { 99, 2, 51, 25.0 },
                    { 51, 1, 51, 22.0 },
                    { 429, 6, 143, 18.899999999999999 },
                    { 428, 6, 142, 16.899999999999999 },
                    { 427, 6, 141, 16.899999999999999 },
                    { 426, 6, 140, 11.9 },
                    { 257, 5, 29, 3.0 },
                    { 424, 6, 138, 23.899999999999999 },
                    { 423, 6, 137, 23.899999999999999 },
                    { 52, 1, 52, 22.0 },
                    { 422, 6, 136, 23.899999999999999 },
                    { 420, 6, 134, 21.899999999999999 },
                    { 419, 6, 133, 23.899999999999999 },
                    { 418, 6, 132, 28.899999999999999 },
                    { 417, 6, 131, 25.899999999999999 },
                    { 416, 6, 130, 15.9 },
                    { 415, 6, 129, 15.9 },
                    { 413, 6, 127, 13.9 },
                    { 412, 6, 126, 33.899999999999999 },
                    { 411, 6, 125, 33.899999999999999 },
                    { 410, 6, 124, 31.899999999999999 },
                    { 409, 6, 123, 28.899999999999999 },
                    { 408, 6, 122, 28.899999999999999 },
                    { 407, 6, 121, 13.9 },
                    { 421, 6, 135, 28.899999999999999 },
                    { 382, 6, 96, 19.0 },
                    { 100, 2, 52, 23.0 },
                    { 216, 4, 52, 23.0 },
                    { 380, 6, 94, 15.9 },
                    { 379, 6, 93, 29.0 },
                    { 378, 6, 92, 28.0 },
                    { 377, 6, 91, 28.0 },
                    { 178, 3, 78, 23.0 },
                    { 302, 5, 75, 18.0 },
                    { 301, 5, 74, 18.0 },
                    { 300, 5, 73, 18.0 },
                    { 365, 6, 72, 22.0 },
                    { 299, 5, 72, 22.0 },
                    { 175, 3, 72, 22.0 },
                    { 283, 5, 55, 18.0 },
                    { 219, 4, 55, 19.0 },
                    { 157, 3, 52, 23.0 },
                    { 160, 3, 55, 16.0 },
                    { 55, 1, 55, 15.0 },
                    { 282, 5, 54, 20.0 },
                    { 218, 4, 54, 20.0 },
                    { 159, 3, 54, 19.0 },
                    { 102, 2, 54, 19.0 },
                    { 54, 1, 54, 22.0 },
                    { 281, 5, 53, 24.0 },
                    { 217, 4, 53, 24.0 },
                    { 158, 3, 53, 24.0 },
                    { 101, 2, 53, 22.0 },
                    { 53, 1, 53, 22.0 },
                    { 351, 6, 52, 22.0 },
                    { 280, 5, 52, 24.0 },
                    { 103, 2, 55, 16.0 },
                    { 425, 6, 139, 28.899999999999999 },
                    { 208, 4, 29, 4.0 },
                    { 92, 2, 29, 3.0 },
                    { 13, 1, 13, 28.0 },
                    { 314, 6, 12, 26.0 },
                    { 240, 5, 12, 24.0 },
                    { 191, 4, 12, 25.0 },
                    { 123, 3, 12, 23.0 },
                    { 75, 2, 12, 23.0 },
                    { 12, 1, 12, 22.0 },
                    { 313, 6, 11, 23.899999999999999 },
                    { 239, 5, 11, 20.989999999999998 },
                    { 190, 4, 11, 20.899999999999999 },
                    { 122, 3, 11, 18.989999999999998 },
                    { 74, 2, 11, 19.989999999999998 },
                    { 11, 1, 11, 18.989999999999998 },
                    { 312, 6, 10, 23.899999999999999 },
                    { 238, 5, 10, 20.989999999999998 },
                    { 189, 4, 10, 20.899999999999999 },
                    { 121, 3, 10, 18.989999999999998 },
                    { 73, 2, 10, 19.989999999999998 },
                    { 10, 1, 10, 18.989999999999998 },
                    { 311, 6, 9, 27.0 },
                    { 237, 5, 9, 26.0 },
                    { 76, 2, 13, 29.0 },
                    { 124, 3, 13, 29.0 },
                    { 192, 4, 13, 30.0 },
                    { 241, 5, 13, 30.0 },
                    { 128, 3, 17, 25.0 },
                    { 80, 2, 17, 26.0 },
                    { 17, 1, 17, 25.0 },
                    { 318, 6, 16, 32.0 },
                    { 244, 5, 16, 30.0 },
                    { 195, 4, 16, 32.0 },
                    { 127, 3, 16, 29.0 },
                    { 79, 2, 16, 30.0 },
                    { 16, 1, 16, 29.0 },
                    { 317, 6, 15, 29.0 },
                    { 188, 4, 9, 26.0 },
                    { 243, 5, 15, 27.0 },
                    { 126, 3, 15, 25.0 },
                    { 78, 2, 15, 25.0 },
                    { 15, 1, 15, 24.0 },
                    { 316, 6, 14, 21.0 },
                    { 242, 5, 14, 19.0 },
                    { 193, 4, 14, 19.0 },
                    { 125, 3, 14, 18.0 },
                    { 77, 2, 14, 19.0 },
                    { 14, 1, 14, 18.0 },
                    { 140, 3, 29, 3.0 },
                    { 194, 4, 15, 26.0 },
                    { 196, 4, 17, 26.0 },
                    { 120, 3, 9, 25.0 },
                    { 9, 1, 9, 25.0 },
                    { 183, 4, 4, 29.0 },
                    { 115, 3, 4, 26.0 },
                    { 67, 2, 4, 28.0 },
                    { 4, 1, 4, 27.0 },
                    { 305, 6, 3, 29.0 },
                    { 231, 5, 3, 27.0 },
                    { 182, 4, 3, 27.0 },
                    { 114, 3, 3, 26.0 },
                    { 66, 2, 3, 27.0 },
                    { 3, 1, 3, 26.0 },
                    { 304, 6, 2, 25.0 },
                    { 230, 5, 2, 23.0 },
                    { 181, 4, 2, 24.0 },
                    { 113, 3, 2, 23.0 },
                    { 65, 2, 2, 23.0 },
                    { 2, 1, 2, 22.0 },
                    { 303, 6, 1, 30.0 },
                    { 229, 5, 1, 26.0 },
                    { 180, 4, 1, 27.0 },
                    { 112, 3, 1, 25.0 },
                    { 64, 2, 1, 26.0 },
                    { 232, 5, 4, 28.0 },
                    { 306, 6, 4, 30.0 },
                    { 5, 1, 5, 27.0 },
                    { 68, 2, 5, 28.0 },
                    { 310, 6, 8, 29.0 },
                    { 236, 5, 8, 27.0 },
                    { 187, 4, 8, 27.0 },
                    { 119, 3, 8, 25.0 },
                    { 71, 2, 8, 26.0 },
                    { 8, 1, 8, 25.0 },
                    { 309, 6, 7, 30.0 },
                    { 235, 5, 7, 27.0 },
                    { 186, 4, 7, 27.0 },
                    { 118, 3, 7, 26.0 },
                    { 72, 2, 9, 26.0 },
                    { 70, 2, 7, 27.0 },
                    { 308, 6, 6, 30.0 },
                    { 234, 5, 6, 28.0 },
                    { 185, 4, 6, 28.0 },
                    { 117, 3, 6, 27.0 },
                    { 69, 2, 6, 28.0 },
                    { 6, 1, 6, 27.0 },
                    { 307, 6, 5, 30.0 },
                    { 233, 5, 5, 29.0 },
                    { 184, 4, 5, 29.0 },
                    { 116, 3, 5, 27.0 },
                    { 7, 1, 7, 26.0 },
                    { 245, 5, 17, 26.0 },
                    { 315, 6, 13, 31.0 },
                    { 248, 5, 20, 10.0 },
                    { 251, 5, 23, 2.0 },
                    { 202, 4, 23, 2.0 },
                    { 134, 3, 23, 2.0 },
                    { 86, 2, 23, 2.0 },
                    { 23, 1, 23, 2.0 },
                    { 324, 6, 22, 3.5 },
                    { 250, 5, 22, 3.5 },
                    { 201, 4, 22, 3.5 },
                    { 133, 3, 22, 3.5 },
                    { 85, 2, 22, 3.5 },
                    { 22, 1, 22, 3.5 },
                    { 323, 6, 21, 5.0 },
                    { 249, 5, 21, 4.5 },
                    { 200, 4, 21, 5.0 },
                    { 132, 3, 21, 4.5 },
                    { 84, 2, 21, 4.5 },
                    { 21, 1, 21, 4.5 },
                    { 322, 6, 20, 10.0 },
                    { 319, 6, 17, 29.0 },
                    { 199, 4, 20, 11.0 },
                    { 131, 3, 20, 10.0 },
                    { 83, 2, 20, 10.0 },
                    { 20, 1, 20, 10.0 },
                    { 321, 6, 19, 15.0 },
                    { 247, 5, 19, 13.0 },
                    { 198, 4, 19, 13.0 },
                    { 130, 3, 19, 13.0 },
                    { 325, 6, 23, 2.0 },
                    { 24, 1, 24, 5.0 },
                    { 87, 2, 24, 5.0 },
                    { 135, 3, 24, 5.0 },
                    { 29, 1, 29, 3.0 },
                    { 330, 6, 28, 4.0 },
                    { 256, 5, 28, 4.0 },
                    { 207, 4, 28, 4.0 },
                    { 139, 3, 28, 4.0 },
                    { 91, 2, 28, 4.0 },
                    { 28, 1, 28, 4.0 },
                    { 329, 6, 27, 3.0 },
                    { 255, 5, 27, 3.0 },
                    { 206, 4, 27, 3.5 },
                    { 138, 3, 27, 3.0 },
                    { 90, 2, 27, 3.0 },
                    { 27, 1, 27, 3.0 },
                    { 82, 2, 19, 13.0 },
                    { 328, 6, 26, 3.0 },
                    { 205, 4, 26, 3.5 },
                    { 137, 3, 26, 3.0 },
                    { 89, 2, 26, 3.0 },
                    { 26, 1, 26, 3.0 },
                    { 327, 6, 25, 3.5 },
                    { 253, 5, 25, 3.5 },
                    { 204, 4, 25, 3.5 },
                    { 136, 3, 25, 3.5 },
                    { 88, 2, 25, 3.5 },
                    { 25, 1, 25, 3.5 },
                    { 326, 6, 24, 5.0 },
                    { 252, 5, 24, 5.0 },
                    { 203, 4, 24, 5.0 },
                    { 254, 5, 26, 3.0 },
                    { 19, 1, 19, 13.0 },
                    { 1, 1, 1, 25.0 },
                    { 320, 6, 18, 31.0 },
                    { 292, 5, 65, 28.0 },
                    { 18, 1, 18, 30.0 },
                    { 81, 2, 18, 31.0 },
                    { 177, 3, 77, 21.989999999999998 },
                    { 176, 3, 76, 21.989999999999998 },
                    { 129, 3, 18, 30.0 },
                    { 197, 4, 18, 32.0 },
                    { 246, 5, 18, 30.0 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoIngrediente",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[,]
                {
                    { 19, 19, 4, null },
                    { 64, 64, 11, null },
                    { 18, 18, 4, null },
                    { 17, 17, 4, null },
                    { 16, 16, 4, null },
                    { 80, 80, 15, null },
                    { 81, 81, 15, null },
                    { 20, 20, 4, null },
                    { 21, 21, 4, null },
                    { 98, 98, 18, null },
                    { 82, 82, 15, null },
                    { 104, 104, 18, null },
                    { 77, 77, 14, null },
                    { 78, 78, 14, null },
                    { 103, 103, 18, null },
                    { 27, 27, 5, null },
                    { 26, 26, 5, null },
                    { 79, 79, 15, null },
                    { 25, 25, 5, null },
                    { 23, 23, 5, null },
                    { 22, 22, 5, null },
                    { 102, 102, 18, null },
                    { 101, 101, 18, null },
                    { 100, 100, 18, null },
                    { 99, 99, 18, null },
                    { 24, 24, 5, null },
                    { 83, 83, 15, null },
                    { 14, 14, 3, null },
                    { 85, 85, 15, null },
                    { 95, 95, 17, null },
                    { 96, 96, 17, null },
                    { 97, 97, 17, null },
                    { 93, 93, 16, null },
                    { 92, 92, 16, null },
                    { 1, 1, 1, null },
                    { 2, 2, 1, null },
                    { 3, 3, 1, null },
                    { 4, 4, 1, null },
                    { 5, 5, 1, null },
                    { 91, 91, 16, null },
                    { 90, 90, 16, null },
                    { 84, 84, 15, null },
                    { 89, 89, 16, null },
                    { 87, 87, 16, null },
                    { 86, 86, 16, null },
                    { 6, 6, 2, null },
                    { 7, 7, 2, null },
                    { 8, 8, 2, null },
                    { 9, 9, 2, null },
                    { 10, 10, 3, null },
                    { 11, 11, 3, null },
                    { 12, 12, 3, null },
                    { 13, 13, 3, null }
                });

            migrationBuilder.InsertData(
                table: "ProdutoIngrediente",
                columns: new[] { "Id", "IngredienteId", "ProdutoId", "Quantidade" },
                values: new object[,]
                {
                    { 106, 106, 65, null },
                    { 15, 15, 3, null },
                    { 88, 88, 16, null },
                    { 28, 28, 6, null },
                    { 29, 29, 6, null },
                    { 30, 30, 6, null },
                    { 47, 47, 9, null },
                    { 48, 48, 9, null },
                    { 49, 49, 9, null },
                    { 50, 50, 9, null },
                    { 51, 51, 9, null },
                    { 67, 67, 12, null },
                    { 66, 66, 12, null },
                    { 105, 105, 19, null },
                    { 65, 65, 12, null },
                    { 115, 115, 76, null },
                    { 116, 116, 76, null },
                    { 52, 52, 10, null },
                    { 53, 53, 10, null },
                    { 46, 46, 9, null },
                    { 54, 54, 10, null },
                    { 56, 56, 10, null },
                    { 57, 57, 10, null },
                    { 117, 117, 77, null },
                    { 118, 118, 77, null },
                    { 122, 122, 77, null },
                    { 121, 121, 77, null },
                    { 120, 120, 77, null },
                    { 58, 58, 11, null },
                    { 59, 59, 11, null },
                    { 60, 60, 11, null },
                    { 61, 61, 11, null },
                    { 62, 62, 11, null },
                    { 63, 63, 11, null },
                    { 55, 55, 10, null },
                    { 68, 68, 12, null },
                    { 69, 69, 12, null },
                    { 70, 70, 12, null },
                    { 31, 31, 6, null },
                    { 32, 32, 6, null },
                    { 33, 33, 6, null },
                    { 107, 107, 65, null },
                    { 108, 108, 65, null },
                    { 109, 109, 65, null },
                    { 76, 76, 13, null },
                    { 75, 75, 13, null },
                    { 74, 74, 13, null },
                    { 34, 34, 7, null },
                    { 35, 35, 7, null },
                    { 36, 36, 7, null },
                    { 37, 37, 7, null },
                    { 38, 38, 7, null },
                    { 39, 39, 7, null },
                    { 40, 40, 7, null },
                    { 73, 73, 13, null },
                    { 72, 72, 13, null },
                    { 71, 71, 13, null },
                    { 110, 110, 65, null },
                    { 111, 111, 65, null },
                    { 41, 41, 8, null },
                    { 42, 42, 8, null },
                    { 43, 43, 8, null },
                    { 44, 44, 8, null },
                    { 45, 45, 8, null },
                    { 112, 112, 76, null },
                    { 113, 113, 76, null },
                    { 114, 114, 76, null },
                    { 119, 119, 77, null },
                    { 94, 94, 17, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaFuncionamento_FranquiaId",
                table: "DiaFuncionamento",
                column: "FranquiaId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioFuncionamento_DiaFuncionamentoId",
                table: "HorarioFuncionamento",
                column: "DiaFuncionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PagamentoId",
                table: "Pedido",
                column: "PagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoIngrediente_IngredienteId",
                table: "PedidoIngrediente",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoIngrediente_PedidoId",
                table: "PedidoIngrediente",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoIngrediente_ProdutoId",
                table: "PedidoIngrediente",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoIngrediente_ProdutoPedidoId",
                table: "PedidoIngrediente",
                column: "ProdutoPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFranquia_FranquiaId",
                table: "ProdutoFranquia",
                column: "FranquiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFranquia_ProdutoId",
                table: "ProdutoFranquia",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoIngrediente_IngredienteId",
                table: "ProdutoIngrediente",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoIngrediente_ProdutoId",
                table: "ProdutoIngrediente",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_PedidoId",
                table: "ProdutoPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_PontoCarneId",
                table: "ProdutoPedido",
                column: "PontoCarneId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPedido_ProdutoFranquiaId",
                table: "ProdutoPedido",
                column: "ProdutoFranquiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorarioFuncionamento");

            migrationBuilder.DropTable(
                name: "PedidoIngrediente");

            migrationBuilder.DropTable(
                name: "ProdutoIngrediente");

            migrationBuilder.DropTable(
                name: "DiaFuncionamento");

            migrationBuilder.DropTable(
                name: "ProdutoPedido");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "PontoCarne");

            migrationBuilder.DropTable(
                name: "ProdutoFranquia");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Franquia");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
