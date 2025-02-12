/* Random Game -> The player should guess wich number is between 1 and 100,
when the player try a number, the system says if is lower, higher or is the correct number.
Good Luck!
*/

void main(){
    Random random = new Random();
    int number = random.Next(1, 101);
    bool correctAnswer = false;

    Console.WriteLine(@"
    
    ");

    while(correctAnswer != true){
    int guess = getATry();

    if(guess > number) {
            Console.WriteLine("\nPalpite Errado ! O número sorteado é menor que seu palpite!\n");
        }

    if(guess < number) {
            Console.WriteLine("\nPalpite Errado ! O número sorteado é maior que seu palpite!\n");
        }

    if(guess == number){
        Console.WriteLine("\nPalpite Correto!! Parabéns por adivinhar o número sorteado!\n");
        Console.WriteLine("\nDigite qualquer tecla para sair...\n");
        Console.ReadKey();
        correctAnswer = true;
    }

    }
}  

int getATry(){
    int guess = 0;

    try{
        Console.Write("Digite um número entre 1 e 100: ");
        guess = int.Parse(Console.ReadLine()!);
        if(guess < 0 || guess > 100) {
        throw new Exception();
        }
    }catch(Exception e){
        e.GetBaseException();
        Console.WriteLine("Palpite inválido!!");
        guess = getATry();
    }

    return guess;
}

main();