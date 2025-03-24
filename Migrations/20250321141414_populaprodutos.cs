using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class populaprodutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Bebidas (CategoriaId = 1)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Coca-Cola', 'Refrigerante de cola 350ml', 5.45, 'cocacola.jpg', 50, CURRENT_TIMESTAMP, 1);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Suco de Laranja', 'Suco natural de laranja 500ml', 7.90, 'suco_laranja.jpg', 30, CURRENT_TIMESTAMP, 1);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Água Mineral', 'Água mineral sem gás 500ml', 2.50, 'agua.jpg', 60, CURRENT_TIMESTAMP, 1);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Chá Gelado', 'Chá preto gelado com limão 450ml', 6.00, 'cha_gelado.jpg', 35, CURRENT_TIMESTAMP, 1);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Cerveja Pilsen', 'Cerveja clara 350ml', 8.50, 'cerveja.jpg', 40, CURRENT_TIMESTAMP, 1);");

            // Lanches (CategoriaId = 2)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Hambúrguer Clássico', 'Pão, carne, queijo e salada', 15.99, 'hamburguer.jpg', 25, CURRENT_TIMESTAMP, 2);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Sanduíche Natural', 'Pão integral, frango e salada', 9.90, 'sanduiche_natural.jpg', 30, CURRENT_TIMESTAMP, 2);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Wrap de Frango', 'Frango, alface e molho especial', 12.50, 'wrap_frango.jpg', 20, CURRENT_TIMESTAMP, 2);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Hot Dog Especial', 'Pão, salsicha, molho e batata palha', 12.50, 'hotdog.jpg', 20, CURRENT_TIMESTAMP, 2);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Cheeseburger', 'Pão, carne, queijo cheddar e molho especial', 14.99, 'cheeseburger.jpg', 22, CURRENT_TIMESTAMP, 2);");

            // Doces (CategoriaId = 3)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bolo de Chocolate', 'Bolo fofinho com cobertura de chocolate', 18.00, 'bolo_chocolate.jpg', 15, CURRENT_TIMESTAMP, 3);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Brigadeiro Gourmet', 'Doce de chocolate com leite condensado', 3.00, 'brigadeiro.jpg', 100, CURRENT_TIMESTAMP, 3);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Beijinho', 'Doce de coco com leite condensado', 2.50, 'beijinho.jpg', 80, CURRENT_TIMESTAMP, 3);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Brownie', 'Bolo de chocolate cremoso', 12.00, 'brownie.jpg', 20, CURRENT_TIMESTAMP, 3);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Torta de Morango', 'Torta recheada com creme e morangos', 20.00, 'torta_morango.jpg', 10, CURRENT_TIMESTAMP, 3);");

            // Salgados (CategoriaId = 4)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Coxinha de Frango', 'Massa crocante recheada com frango', 6.50, 'coxinha.jpg', 50, CURRENT_TIMESTAMP, 4);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Empada de Palmito', 'Empada recheada com palmito', 5.00, 'empada.jpg', 30, CURRENT_TIMESTAMP, 4);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Esfirra de Carne', 'Esfirra assada com recheio de carne', 4.50, 'esfirra.jpg', 40, CURRENT_TIMESTAMP, 4);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pastel de Queijo', 'Pastel frito recheado com queijo', 6.00, 'pastel.jpg', 25, CURRENT_TIMESTAMP, 4);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Quibe Frito', 'Quibe recheado com carne moída', 7.00, 'quibe.jpg', 20, CURRENT_TIMESTAMP, 4);");

            // Massas (CategoriaId = 5)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Lasanha à Bolonhesa', 'Lasanha recheada com carne moída e molho de tomate', 25.90, 'lasanha.jpg', 15, CURRENT_TIMESTAMP, 5);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Espaguete ao Pesto', 'Massa espaguete com molho pesto de manjericão', 20.00, 'espaguete_pesto.jpg', 18, CURRENT_TIMESTAMP, 5);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Ravioli de Ricota', 'Massa recheada com ricota e espinafre', 22.50, 'ravioli.jpg', 12, CURRENT_TIMESTAMP, 5);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Nhoque ao Sugo', 'Nhoque de batata com molho de tomate', 18.00, 'nhoque.jpg', 20, CURRENT_TIMESTAMP, 5);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Macarrão Carbonara', 'Espaguete com bacon, ovos e queijo parmesão', 24.90, 'carbonara.jpg', 14, CURRENT_TIMESTAMP, 5);");

            // Carnes (CategoriaId = 6)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Picanha Grelhada', 'Picanha suculenta grelhada no ponto', 45.00, 'picanha.jpg', 10, CURRENT_TIMESTAMP, 6);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Filé Mignon ao Molho Madeira', 'Filé mignon com molho madeira e champignon', 50.00, 'file_mignon.jpg', 8, CURRENT_TIMESTAMP, 6);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Costela Assada', 'Costela bovina assada lentamente', 42.50, 'costela.jpg', 12, CURRENT_TIMESTAMP, 6);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Frango Grelhado', 'Filé de frango grelhado com ervas', 19.90, 'frango.jpg', 20, CURRENT_TIMESTAMP, 6);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bife à Parmegiana', 'Bife empanado com queijo e molho de tomate', 27.00, 'bife_parmegiana.jpg', 15, CURRENT_TIMESTAMP, 6);");

            // Frutos do Mar (CategoriaId = 7)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Salmão Grelhado', 'Filé de salmão grelhado com molho de limão', 55.00, 'salmao.jpg', 10, CURRENT_TIMESTAMP, 7);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Camarão ao Alho e Óleo', 'Camarão salteado no alho e azeite', 60.00, 'camarao.jpg', 12, CURRENT_TIMESTAMP, 7);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Lula à Dorê', 'Anéis de lula empanados e fritos', 35.00, 'lula.jpg', 15, CURRENT_TIMESTAMP, 7);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bacalhau à Brás', 'Bacalhau desfiado com batatas e ovos', 50.00, 'bacalhau.jpg', 10, CURRENT_TIMESTAMP, 7);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Risoto de Frutos do Mar', 'Risoto cremoso com camarões, lula e polvo', 48.00, 'risoto.jpg', 12, CURRENT_TIMESTAMP, 7);");

            // Vegetariano (CategoriaId = 8)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Hambúrguer Vegetariano', 'Hambúrguer de grão-de-bico e lentilha', 18.00, 'hamburguer_veg.jpg', 20, CURRENT_TIMESTAMP, 8);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pizza de Vegetais', 'Pizza com abobrinha, berinjela e pimentão', 28.00, 'pizza_veg.jpg', 15, CURRENT_TIMESTAMP, 8);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Salada Grega', 'Salada com tomate, pepino, queijo feta e azeitonas', 15.50, 'salada_grega.jpg', 25, CURRENT_TIMESTAMP, 8);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Tofu Grelhado', 'Tofu temperado e grelhado', 20.00, 'tofu.jpg', 18, CURRENT_TIMESTAMP, 8);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Estrogonofe de Cogumelos', 'Estrogonofe feito com cogumelos frescos', 30.00, 'estrogonofe.jpg', 12, CURRENT_TIMESTAMP, 8);");

            // Vegano (CategoriaId = 9)
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Quibe Vegano', 'Quibe feito com trigo e legumes', 10.00, 'quibe_veg.jpg', 25, CURRENT_TIMESTAMP, 9);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Mousse de Chocolate Vegano', 'Mousse feito com chocolate e leite de amêndoas', 12.00, 'mousse_veg.jpg', 15, CURRENT_TIMESTAMP, 9);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Leite Vegetal', 'Bebida vegetal de amêndoas', 8.50, 'leite_veg.jpg', 20, CURRENT_TIMESTAMP, 9);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Bolo Vegano', 'Bolo sem ingredientes de origem animal', 15.00, 'bolo_vegano.jpg', 12, CURRENT_TIMESTAMP, 9);");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Lasanha Vegana', 'Lasanha com recheio de legumes', 22.00, 'lasanha_veg.jpg', 10, CURRENT_TIMESTAMP, 9);");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert");
        }
    }
}
