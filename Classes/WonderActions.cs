using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace WonderButton.Classes;

public class WonderActions
{
    internal void PushAction()
    {
        NewMessage<string>  stringMessage       = new();
        NewMessage<int>     intMessage          = new();
        DateTime            time                = DateTime.Now;
        TimeSpan            lunchSWindow        = new(11, 00, 00);
        TimeSpan            lunchCWindow        = new(12, 00, 00);
        TimeSpan            turnOnLights        = new(08, 00, 00);
        TimeSpan            turnOffLights       = new(15, 00, 00);
        Console.WriteLine($"The time is: {time}"                );

        bool lightsOn       = time.TimeOfDay >= turnOnLights && time.TimeOfDay <= turnOffLights;
        bool isLunch        = time.TimeOfDay >= lunchSWindow && time.TimeOfDay <= lunchCWindow;
        
        stringMessage.Message = "Ordering food for ";
        intMessage.Message = 10;


        if      (lightsOn)              { Console.WriteLine("Turning on the Lights" ); }
        else                            { Console.WriteLine("Turning off the lights"); }
        
        if      (isLunch & lightsOn)    { Console.WriteLine($"{stringMessage.Message} {intMessage.Message} people"); }

        Console.WriteLine   ( $"{lightsOn}" );
        // stringMessage.showMessage();
    }   
}