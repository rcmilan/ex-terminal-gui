using ex_terminal_gui;
using Terminal.Gui;

Application.Init();

Application.Run<ExampleWindow>();

Application.Shutdown();

Console.WriteLine($@"Username: {ExampleWindow.UserName}");
