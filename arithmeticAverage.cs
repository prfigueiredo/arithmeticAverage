using System;

class arithmeticAverage
{
    static void Main() {
        Console.WriteLine("Digite a 1ª nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 2ª nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a nota da prova final:");
        double final = Convert.ToDouble(Console.ReadLine());
        
        double media = (nota1 + nota2 + final) / 3;
        
        if(media>=6){
        Console.WriteLine("Aluno aprovado com nota" + " " + media);
        }else{
            Console.WriteLine("Aluno reprovado com nota" + " " + media);
        }
    }
        
        
}