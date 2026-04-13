class Program
{
    public Program()
    {
    }

    static void Main()
    {
        AudioPlayer.PlayGreeting();

        SeccBot bot = new SeccBot();
        bot.StartChat();
    }
}