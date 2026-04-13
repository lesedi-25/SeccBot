using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class SeccBot
{
    private string userName;
    private ResponseManager responseManager = new ResponseManager();

    public void StartChat()
    {
        DisplayLogo();

        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
            userName = "User";

        Console.WriteLine($"\nHello {userName}, I am SeccBot 🤖.");
        Console.WriteLine("Ask me about cybersecurity (type 'exit' to quit).\n");

        while (true)
        {
            Console.Write($"{userName}: ");
            string input = Console.ReadLine()?.ToLower();

            // 🔹 Input validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("SecBot: Please type something.");
                continue;
            }

            // 🔹 Exit condition
            if (input == "exit")
            {
                Console.WriteLine("SecBot: Stay safe online. Goodbye!");
                break;
            }

            // 🔹 Response
            string response = responseManager.GetResponse(input);
            TypingEffect("SecBot: " + response);
        }
    }


    private void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
  ███████╗███████╗ ██████╗ ██████╗ ██████╗  ██████╗ ████████╗
  ██╔════╝██╔════╝██╔════╝██╔════╝ ██╔══██╗██╔═══██╗╚══██╔══╝
  ███████╗█████╗  ██║     ██║      ██████╔╝██║   ██║   ██║   
  ╚════██║██╔══╝  ██║     ██║      ██╔══██╗██║   ██║   ██║   
  ███████║███████╗╚██████╗╚██████╗ ██████╔╝╚██████╔╝   ██║   
  ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═════╝  ╚═════╝    ╚═╝   

                 🤖 SECCBOT 🤖
           ""Your Security Chat Bot""
        ==============================
          Protect • Detect • Prevent
");

        Console.ResetColor();
    }
    private void TypingEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine();
    }
}

