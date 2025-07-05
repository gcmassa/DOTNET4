// See https://aka.ms/new-console-template for more information


bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) // Operador OR || umas das condíções pode ser verdadeira para validar
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7) // Operador AND && as duas condições tem que ser verdadeiras para validar se uma delas falhar não valida
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde) // Operador NOT ! onde coloca o sinal de negação na frente da variável negando o valor recebido
{
    Console.WriteLine("Vou pedalar!!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}