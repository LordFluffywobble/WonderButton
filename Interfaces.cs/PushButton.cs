namespace WonderButton.Interfaces;

internal interface IPushButton
    { 
        ConsoleKey PushButton();    //Using ConsoleKey to decide the return type so i can compare it too the Key pressed in the If statement
    }
