using Biblioteca;
using Xunit;

namespace teste
{
	public class Teste
	{
		[Fact]
		public void Teste1()
		{
			// Arrange
			var num1 = 2.9;
			var num2 = 3.1;
			var valorEsperado = 6;

			// Act
			var soma = Calculos.Somar(num1, num2);

			// Assert
			Assert.Equal(valorEsperado, soma);
		}
	}
}