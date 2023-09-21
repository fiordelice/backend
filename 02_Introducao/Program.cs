//Somente declaramos a variável como inteira e não atribuimos valor 
int num1;

//Estou declarando uma variável do tipo inteira e atribuindo o valor 5 
int num2 = 5; 

//Declarando uma variável do tipo string 
string nomeAluno;

//Variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//Variável do tipo valor com casas decimais - para valores mais precisos 
double altura = 1.80;

//Variável do tipo decimal - mais usada para o valor monetário
decimal valor = 1.80M;

int idade = 16;
string nome = "Gabriella";
Console.WriteLine($"Meu nome é {nome} e tenho {idade}");

Console.WriteLine("Em qual cidade voce nasceu?");
//Recebendo uma informação so usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine ($"Voce nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");