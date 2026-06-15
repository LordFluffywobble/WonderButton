namespace WonderButton.Classes;

// One little generic
public class NewMessage<T>
{
    public T? Message { get; set; }     //Can be nullable

    public void showMessage()
    {
        Console.WriteLine($"{Message}");
    }
}
