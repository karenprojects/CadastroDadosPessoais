//Solicite ao usuário que digite seu nome
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

//Solicite que o usuário digite seu sobrenome
Console.WriteLine("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

//Solicite ao usuário que digite sua idade
Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

//Imprime o nome completo e idade do usuário 
Console.WriteLine("Nome completo: " + nome + " " + sobrenome + " e sua idade é: " + idade + " anos ");

