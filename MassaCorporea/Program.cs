internal class Program
{
    private static void Main(string[] args)
    {
        float peso, altura, imc;
        char sexo;

        Console.WriteLine("Informe o sexo F/M: ");
        sexo = char.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso: ");
        peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o altura: ");
        altura = float.Parse(Console.ReadLine());

        imc = peso/(altura*altura); 
        if(sexo == 'M')
        {
            if(imc < 20.7)
            {
                Console.WriteLine("Abaixo do peso!");
            }else 
                if(imc < 26.5)
                {
                    Console.WriteLine("Peso normal!");
                }else 
                    if (imc < 27.9)
                    {
                        Console.WriteLine("Pouco acima do peso!");
                    }else 
                         if (imc < 31.2)
                          {
                             Console.WriteLine("Acima do peso!");
                          }
                          else
                             {
                                 Console.WriteLine("Obesidade!");
                             }
        }
        if (sexo == 'F')
        {
            if (imc < 19.1)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else
                if (imc < 25.9)
                {
                Console.WriteLine("Peso normal!");
                }
                else
                    if (imc < 27.4)
                    {
                         Console.WriteLine("Pouco acima do peso!");
                    }
                    else
                        if (imc < 32.4)
                        {
                             Console.WriteLine("Acima do peso!");
                        }
                         else
                             {
                                Console.WriteLine("Obesidade!");
                             }
        }
    }
}