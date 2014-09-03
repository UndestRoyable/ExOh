using System;

class ExOH
{
    static bool ExOh(string exOh)
    {
        byte oSum = 0;
        byte xSum = 0;
        bool answer = false;

        foreach (var symbol in exOh)
        {
            if (symbol == 'o')
            {
                oSum += 1;
            }
            else
            {
                xSum += 1;
            }
        }
        if (oSum == xSum)
        {
            answer = true;
            
        }
        

        return answer;
    }
    static void Main()
    {
        string exOh = Console.ReadLine();

        bool finalAnswer = ExOh(exOh);

        Console.WriteLine(finalAnswer);
        
    }
}

