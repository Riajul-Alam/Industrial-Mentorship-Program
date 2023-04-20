using System;

class MyButton
{
    // Define an event named Click, which is of type EventHandler
    // EventHandler is a built-in delegate type that takes two parameters:
    // the sender of the event (object) and any event-specific arguments (EventArgs)
    public event EventHandler Click;// Define a method to simulate a button click
    public void OnClick()
    {
        // Raise the Click event, passing 'this' as the sender and EventArgs.Empty as the arguments
        Click?.Invoke(this, EventArgs.Empty);
    }
}

class MainApp
{
    static void Main()
    {
        MyButton button = new MyButton();// Create a new instance of MyButton

        // Subscribe to the Click event by adding a new event handler
        button.Click += HandleButtonClick;

        button.OnClick();// Simulate a button click by calling the OnClick method
        // Unsubscribe from the Click event by removing the event handler
        button.Click -= HandleButtonClick;
    }
    // Define a method to handle the Click event
    static void HandleButtonClick(object sender, EventArgs e)
    {
        // Cast the sender parameter to MyButton to access its properties and methods
        MyButton button = (MyButton)sender;
        // Write a message to the console to indicate that the button has been clicked
        Console.WriteLine("Button clicked!");
    }
}




