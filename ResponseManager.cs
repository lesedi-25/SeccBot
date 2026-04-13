using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ResponseManager
{
    private Random random = new Random();

    // Topics
    private string[] phishingResponses = 
    {
        "Phishing is when attackers trick you into giving personal information.",
        "Phishing uses fake emails or websites to steal your data.",
        "Always check links carefully to avoid phishing attacks."
    };

    private string[] passwordResponses =
    {
        "Use strong passwords with symbols and numbers to ensure that your password is more secure.",
        "Avoid using personal info like your name or birthday to make it harder to guess avoid all things personal for password creation.",
        "Change your passwords regularly to stay secure."
    };

    private string[] malwareResponses =
    {
        "Malware is harmful software that damages your system.",
        "Install antivirus software to protect against malware.",
        "Malware can steal or destroy your data."
    };
    private string[] FirewallResponses =
        { "A firewall is a security system that monitors and controls incoming and outgoing network traffic based on predetermined security rules.",
         "Firewalls can be hardware, software, or a combination of both.",
          "Firewalls help protect your network from unauthorized access and cyber threats."

    };
    private string[] WifihackResponses =
         { "Wi-Fi hacking involves exploiting vulnerabilities in wireless networks to gain unauthotized access.",
     "To protect against Wi-Fi hacking, use strong encryption (like WPA3) and a strong password for your Wi-Fi network connection"
     "Ensure that you have a vpn active whenever you use public Wi-Fi for an extra layer of protection"};

    public string GetResponse(string input)
    {
        // 🔹 FIREWALL
        if (input.Contains("firewall"))
            return GetRandom(FirewallResponses);

        // 🔹 PHISHING
        if (input.Contains("phishing"))
            return GetRandom(phishingResponses);

        // 🔹 PASSWORD
        if (input.Contains("password"))
            return GetRandom(passwordResponses);

        // 🔹 MALWARE / VIRUS
        if (input.Contains("malware") || input.Contains("virus"))
            return GetRandom(malwareResponses);

        // 🔹 GREETING
        if (input.Contains("hello") || input.Contains("hi"))
            return "Hello! How can I help you stay safe online today?";

        // 🔹 PURPOSE
        if (input.Contains("purpose"))
            return "My purpose is to help you learn about cybersecurity and stay safe online.";

        // 🔹 DEFAULT
        return "I can help with phishing, passwords, malware, and online safety. Try asking me something!";
    }

    private string GetRandom(string[] responses)
    {
        int index = random.Next(responses.Length);
        return responses[index];
    }
}
