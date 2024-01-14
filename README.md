# xUnit - Teste

## App / Biblioteca

```sh
mkdir xUnit_teste
cd xUnit_teste
dotnet new sln xUnit_teste
```

![](./vs.svg) Aplicativo do Console

```sh
dotnet new console -f net6.0 -n app
dotnet sln add app
```

ou

![](./vs.svg) Biblioteca de Classes

```sh
dotnet new classlib -f net6.0 -n biblioteca
dotnet sln add biblioteca
```

## Biblioteca/DLL de Cálculo

```sh
cd app
touch Calculos.cs
```

📝 biblioteca\Calculos.cs

```csharp
namespace Biblioteca
{
	public static class Calculos
	{
		public static double Somar(double numero1, double numero2)
		{
			return (numero1 + numero2);
		}
		public static double Subtrair(double numero1, double numero2)
		{
			return (numero1 - numero2);
		}
		public static double Multiplicar(double numero1, double numero2)
		{
			return (numero1 * numero2);
		}
		public static double Dividir(double numero1, double numero2)
		{
			return (numero1 / numero2);
		}
		public static bool IsNumeroPar(int numero)
		{
			return numero % 2 == 0;
		}
	}
}

```

## Vinculando a biblioteca no ambiente de teste

![](./vs.svg) Projeto de Teste do xUnit

```sh
dotnet new xunit -n teste
dotnet sln add teste
```

Clique com ![](./bt_right.svg) na solução ➔ Adicionar ➔ Referência de Projeto

✅ biblioteca

```sh
dotnet add api reference biblioteca
```

## Ambiente de teste

📝 teste\Teste.cs

```csharp
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
```

## Para testar

![](./vs.svg) Menu superior ➔ Teste ➔ Gerenciador de testes
