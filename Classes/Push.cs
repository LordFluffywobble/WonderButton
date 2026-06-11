using System.Security.Cryptography.X509Certificates;

namespace WonderButton.Classes;

public class Pushed
{
    public bool pushed { get; set; } = false;
    public Pushed(bool initialStatus)
    {
        pushed = initialStatus;
    }
}

public class Lights : Pushed
{       
    public Lights(bool initialStatus = false) : base(initialStatus){}
}

public class FoodOrder : Pushed
{
    public FoodOrder(bool initialStatus = false) : base(initialStatus){}
}

// One little generic
public class NewMessage<T>
{
    public T? Message { get; set; }

    public void showMessage()
    {
        Console.WriteLine($"Button {Message}");
    }
}


// public class Box<T>  
// {  
//     public T Content { get; set; }  
  
//     public void ShowContent()  
//     {  
//         Console.WriteLine($"Content: {Content}");  
//     }  
// }  
  
// // Usage  
// var intBox = new Box<int>();  
// intBox.Content = 10;  
  
// var stringBox = new Box<string>();  
// stringBox.Content = "Secret";  