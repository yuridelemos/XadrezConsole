using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
            //'a' = internamente é um número inteiro. Se for 'a' - 'a' = 0, se for o B é o código do B menos o código do A e assim por diante
        }
        public override string ToString()
        {
            return "" + coluna + linha; //"" força converter para string    
        }
    }
}
