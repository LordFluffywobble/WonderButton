using System.Security.Cryptography.X509Certificates;
using WonderButton.Classes;

namespace WonderButton;


class Program
{
    static void Main()
    {
        Console.WriteLine("Press the big button");

        WonderActions newAction = new();
        ButtonPushed pushed = new();
        
        if (pushed.PushButton() == ConsoleKey.Spacebar)
        {
            newAction.PushAction();
        }       
    }
} 

