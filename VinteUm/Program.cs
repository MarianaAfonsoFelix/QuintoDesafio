Console.WriteLine("Olar, bora jogar Vinte e Um (Blackjack) ? :) ");

Console.WriteLine("\nQual o seu nome?");
var nomeParticipante = Console.ReadLine();


bool sequenciaJogo = true;

var pontuacao = 0;
var numeroSorteado = GerarCarta();

while(sequenciaJogo)
{
    pontuacao = pontuacao + numeroSorteado;
    Console.WriteLine("\nO número sorteado foi:");
    Console.WriteLine(numeroSorteado);
    Console.WriteLine("Sua quantidade da soma dos números sorteados:");
    Console.WriteLine(pontuacao);

    if(VerificarMesa())
    {
        Console.WriteLine("\nDeseja tentar mais uma vez?");
        Console.WriteLine("1. Continuar Sorteando número!");
        Console.WriteLine("2. Parar de Sortear número!");
    }
    else
    {
        pontuacao = 0;
        Console.WriteLine(nomeParticipante +"PERDEUUUUUUUU!");
        Console.WriteLine("\nDeseja tentar mais uma vez?");
        Console.WriteLine("1. Continuar Jogando");
        Console.WriteLine("0. Digite qualquer tecla para sair!");
    }
    var resultadoEscolha = Console.ReadLine();

    if(resultadoEscolha == "0")
    {
        sequenciaJogo = false;
    }
    else if(resultadoEscolha == "2")
    {
        if (VerificarMesa())
        {
            pontuacao = 0;
            numeroSorteado = 0;
            Console.WriteLine(nomeParticipante +"\n Ganhoooooou!");
        }
        else
        {
            pontuacao = 0;
            numeroSorteado = 0;
            Console.WriteLine("\nPERDEUUUUUUUU!");
        }

    }

    numeroSorteado = GerarCarta();

}

bool VerificarMesa()
{
    if(pontuacao < 21)
        return true;
    else
        return false;
}

int GerarCarta()
{
    Random random = new Random();
    return random.Next(1, 10);
}