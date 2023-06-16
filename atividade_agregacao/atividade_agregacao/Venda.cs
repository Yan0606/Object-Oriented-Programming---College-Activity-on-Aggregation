class Venda
{
    private Comprador comprador;

    private Vendedor vendedor;

    private List<Produto> vetProd;


    public Venda(Comprador comprador, Vendedor vendedor, List<Produto> vetProd)
    {
        this.comprador = comprador;
        this.vendedor = vendedor;
        this.vetProd = vetProd;
    }

    public void RealizarVenda(int codigoProduto)
    {
        Produto produto = vetProd.Find(p => p.Cod == codigoProduto);

        if (produto != null)
        {
            double valorComissao = produto.Preco * vendedor.Comissao;
            comprador.Verba -= produto.Preco;
            Console.WriteLine("Venda realizada: " + produto.Nome);
            Console.WriteLine("Valor da comissão: R$ " + valorComissao);
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        }
    }
}