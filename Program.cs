using WonderButton.Classes;

namespace WonderButton;

//ONE BUTTON DOES IT ALL!!! Turning on the lights, ordering food and turning off the lights
class Program
{
    static void Main()
    {
        Console.WriteLine("Press the big button");

        WonderActions newAction = new();
        ButtonPushed     pushed = new();
        
        if (pushed.PushButton() == ConsoleKey.Spacebar)
        {
            newAction.PushAction();
        }       
    }
} 

