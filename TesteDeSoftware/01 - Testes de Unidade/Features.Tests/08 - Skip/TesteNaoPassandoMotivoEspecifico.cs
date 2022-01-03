using Xunit;

namespace Features.Tests
{
    public class TesteNaoPassandoMotivoEspecifico
    {
        // Skip quer dizer que ele vai pular, ele fica somente um alerta no teste, mas não falha
        [Fact(DisplayName = "Novo Cliente 2.0", Skip = "Nova versão 2.0 quebrando")]        
        [Trait("Categoria", "Escapando dos Testes")]
        public void Teste_NaoEstaPassando_VersaoNovaNaoCompativel()
        {
            Assert.True(false);
        }
    }
}