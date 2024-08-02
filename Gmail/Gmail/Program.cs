using Gmail;

class Program
{
    static void Main(string[] args)
    {
        string email;
        bool isValid;

        do
        {
            Console.Write("Digite um email para validação: ");
            email = Console.ReadLine();

            isValid = Email.ValidarEmail(email);

            if (isValid)
            {
                Console.WriteLine("O email é válido.");
            }
            else
            {
                Console.WriteLine("O email é inválido. Tente novamente.");
            }
        } while (!isValid);
    }
}