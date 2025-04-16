using System;
using System.Media;
namespace CybersecurityChatbot;

class CybersecurityChatbot
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ANSI colors
        string purple = "\u001b[35m";
        string green = "\u001b[32m";
        string cyan = "\u001b[36m";
        string reset = "\u001b[0m";

        // 🌟 ASCII Art in Purple
        Console.WriteLine(purple + @"
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⣛⡫⠉⣉⡉⣭⣭⣽⣛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢟⣥⡶⢟⢋⣴⣿⣿⣿⣮⠛⢻⡿⠿⢶⣝⡻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣫⣴⣿⢏⡴⢣⣿⣿⣿⠿⢿⣿⣧⡐⡾⢟⣒⡢⠙⢮⡻⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⢟⣼⣿⡿⣡⣿⢣⣿⣿⠏⣴⡿⠖⠊⠻⣿⣿⣿⣿⣿⣷⣆⢻⡜⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⢏⣾⣿⢏⣼⣿⢣⣿⣿⡏⢰⣶⣶⣶⣦⣤⡙⠋⠉⠙⢻⣿⣿⡎⣧⢹⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⡏⣼⣿⢃⣾⣿⢣⣿⣿⡟⢀⣛⣿⣿⣿⣿⣟⣉⣈⣙⣓⠀⣿⣿⡇⢿⢸⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⢸⡿⣡⣿⡿⢁⣾⣿⣿⢣⣿⣟⢿⣿⣿⣿⢩⣿⣿⣿⣿⡇⣿⣿⡇⣸⢸⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⡇⠚⣴⣿⡟⢀⣾⣿⣿⠇⡚⢿⣿⡊⣿⣿⣿⢠⣿⠟⣛⠟⡃⢸⣿⡇⠁⢸⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⢇⣾⣿⠏⣴⣿⣿⣿⡟⠀⠙⠿⣿⣧⣸⣿⣿⣿⡷⠋⠁⠀⠀⢸⣿⡇⠄⣾⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⢏⣾⣿⢋⣾⣿⣿⣿⡿⢁⠀⠀⠀⢙⣿⣿⣿⣿⡟⠀⠀⠀⣰⠷⢸⣿⡅⡀⢹⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⡏⣼⡿⢣⣿⣿⣿⣿⠟⣡⣶⣶⣴⣶⣿⣿⣿⣿⣿⣿⣷⣶⣶⣶⣾⢸⣿⠀⠉⢸⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣇⢿⢣⣿⣿⣿⠟⢡⠘⣿⣿⣿⣿⣿⣿⡿⢻⡿⠻⣿⣿⣿⣿⣿⣟⠈⣿⡆⢺⡜⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⡌⢸⣿⣿⢫⣾⣷⣦⢸⣿⣿⣿⣿⣿⣷⣤⣤⣴⣿⣿⣿⣿⣿⡟⠀⢻⣷⠀⢿⡹⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⡎⢿⣷⠸⣿⣿⣿⡆⠹⣿⣿⣯⣙⠋⣁⣉⠉⢛⣽⣿⣿⠟⣡⡄⠸⣿⣧⠈⣧⢻⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⡿⢰⢶⣭⣓⣈⡛⢸⣧⢸⣮⡙⠿⣿⣷⣤⣠⣶⣿⡿⢛⣡⣾⣿⡇⣷⣝⢿⣷⣸⣎⢿⣿⣿⣿
        ⣿⣿⣿⣿⡟⢁⣿⢸⣿⣿⣿⡏⣾⡇⠸⣿⣿⡆⢠⣝⣛⣟⣋⣥⢠⣿⣿⣿⣿⢹⣿⣿⣷⣾⡇⣿⣯⠻⣿⣿
        ⣿⣿⣿⠟⢀⡾⣡⢸⣿⣿⠟⢰⣿⠃⢰⣿⣿⣿⠈⠉⠛⠛⠋⠁⢸⣿⣿⣿⡿⣸⣿⣿⣿⣿⡇⣻⣿⣷⡹⣿
        ⣿⣿⠏⢠⡞⣱⡿⠘⠛⠋⠆⢘⣛⠠⠿⠿⠿⠋⠀⠀⠀⠀⠀⠀⠈⠻⠿⠿⠇⢛⣛⠻⠿⠛⠓⢿⣿⡟⣷⡸
        ⣿⡏⢠⢏⣼⡿⠁⠀⠀⠀⠀⣾⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⢻⣿⡹⣷⢻
        ⡿⣰⣇⣾⣿⠁⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⢿⣇⢿⠸
        ⡇⣿⢸⣿⡏⠀⠀⠀⠀⠀⢰⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⠀⠀⠀⠸⣟⢸⠀
        ⡇⣿⣾⣿⠁⠀⠀⠀⠀⠀⣼⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⡀⠀⠀⠀⠀⠀⢿⠈⢰
" + reset);

        Audio.Player();

        Console.WriteLine(cyan + "Hey hey! I’m Luna, your friendly Cybersecurity Awareness Bot! 🌙");

        Console.Write("👋So what's your name? ");
        string nameInput = Console.ReadLine();

        User currentUser = new User();
        currentUser.Name = nameInput;

        Console.WriteLine($"\n🛡️ Welcome to the Cybersecurity Awareness Chatbot, {currentUser.Name}!");
        Console.WriteLine("I'm here to help you stay safe online with easy tips, examples, and a little sprinkle of fun ");
        Console.WriteLine("Ready to learn? Let's dive in! 🏄‍♀️\n" + reset);

        StartChat(green, cyan, reset, currentUser.Name);
    }

    static void StartChat(string green, string cyan, string reset, string Name)
    {
        Console.WriteLine("\n💡 Please type 'help' to see what I can assist you with, or type a question like 'What is phishing?'");
        Console.WriteLine("Type 'exit' when you're done chatting.\n");

        while (true)
        {
            Console.Write($"{green}{Name}: {reset}");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
            {
                Console.WriteLine($"{cyan}👋 Bye for now! Try to stay safe out there, {Name}! 🛡️{reset}");
                break;
            }
            else if (userInput == "help")
            {
                Console.WriteLine($"\n🧠 You can ask me about:");
                Console.WriteLine("🔐 Password safety");
                Console.WriteLine("🎣 Phishing attacks");
                Console.WriteLine("🦠 Malware");
                Console.WriteLine("🌐 Safe browsing");
                Console.WriteLine("📵 Social media safety");
                Console.WriteLine("📧 Email scams");
                Console.WriteLine("🧩 Multi-factor authentication (MFA)");
                Console.WriteLine("💾 Backups\n");
            }
            else if (userInput.Contains("phishing"))
            {
                TalkPhishing(cyan, reset);

            }
            else if (userInput.Contains("password"))
            {
                TalkPasswords(cyan, reset);

            }
            else if (userInput.Contains("malware"))
            {
                TalkMalware(cyan, reset);

            }
            else if (userInput.Contains("browsing") || userInput.Contains("web"))
            {
                TalkBrowsing(cyan, reset);
            }

            else if (userInput.Contains("social media") || userInput.Contains("instagram") || userInput.Contains("facebook"))
            {

                TalkSocialMedia(cyan, reset);
            }
            else if (userInput.Contains("email") || userInput.Contains("scam"))
            {
                TalkEmail(cyan, reset);
            }
            else if (userInput.Contains("mfa") || userInput.Contains("multi-factor"))
            {
                TalkMFA(cyan, reset);
            }
            else if (userInput.Contains("backup") || userInput.Contains("backups"))
            {
                TalkBackup(cyan, reset);
            }
            else if (userInput.Contains("who are you luna?") || userInput.Contains("who is luna") || userInput.Contains("what is your purpose"))
            {
                WhoIsLuna(cyan, reset);
            }
            else if (userInput.ToLower().Contains("What's an antivirus"))
            {
                Console.WriteLine("🛡️ Antivirus software helps protect your device from viruses and malware. Always keep it updated!");
            }
            else if (userInput.ToLower().Contains("What is vpn"))
            {
                Console.WriteLine("🌐 VPN stands for Virtual Private Network. It keeps your browsing private and safe, especially on public Wi-Fi!");
            }
            else if (userInput.ToLower().Contains("What about public wi-fi"))
            {
                Console.WriteLine("⚠️ Be super careful on public Wi-Fi! Avoid logging into sensitive accounts unless you're using a VPN.");
            }
            else if (userInput.Contains("safety"))
            {
                TalkSafety(cyan, reset);
            }
            else if (userInput.Contains("exit"))
            {
                Console.WriteLine(cyan + "\n Luna: Thank you so much for spending time with me! Keep shining and stay safe out there ✨🌍" + reset);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"{cyan} Hmm, I’m not sure how to help with that. Please type 'help' to see what I know!{reset}");
            }
        }

    }

    static void TalkMalware(string cyan, string reset)
    {
        Console.WriteLine(cyan + "\n Malware is short for malicious software. It includes viruses, worms, spyware, ransomware, and more!");
        Console.WriteLine("💡 Tip: Don’t click on random pop-ups or download weird files from emails or websites.");
        Console.WriteLine("Example: A fake update notification could install spyware that steals your passwords." + reset);
    }

    static void TalkPhishing(string cyan, string reset)
    {
        Console.WriteLine(cyan + "\n Phishing is when someone pretends to be a trusted person or company to trick you into giving up personal info.");
        Console.WriteLine(" Example: An email saying 'Your account is compromised, click here to fix it!'—but it's fake!");
        Console.WriteLine("💡 Tip: Always check email addresses closely, and never click suspicious links." + reset);
    }

    static void TalkPasswords(string cyan, string reset)
    {
        Console.WriteLine(cyan + "\n A strong password keeps your accounts safe!");
        Console.WriteLine("💡 Tip: Use a mix of upper/lowercase letters, numbers, and symbols.");
        Console.WriteLine(" Example: Instead of 'password123', try 'Lun@R0cks2024!'");
        Console.WriteLine(" Use a password manager to help remember complex passwords!" + reset);
    }

    static void TalkSafety(string cyan, string reset)
    {
        Console.WriteLine(cyan + "\n Staying safe online means being alert and mindful of what you click, share, and download.");
        Console.WriteLine("💡 Tips to stay safe:");
        Console.WriteLine("   - Use strong passwords 🔐");
        Console.WriteLine("   - Enable 2-factor authentication 📱");
        Console.WriteLine("   - Update your software and apps regularly 🔄");
        Console.WriteLine("   - Be cautious with links and attachments in emails 📎" + reset);
    }
    static void TalkBrowsing(string cyan, string reset)
    {
        Console.WriteLine($"{cyan}🌐 Safe Browsing Tip:");
        Console.WriteLine("🔒 Look for HTTPS in the URL before entering sensitive info.");
        Console.WriteLine("🚫 Avoid clicking pop-ups or shady download buttons.{reset}");
    }
    static void TalkSocialMedia(string cyan, string reset)
    {
        Console.WriteLine($"{cyan}📱 Social Media Safety Tip:");
        Console.WriteLine("🔐 Keep your profiles private and don’t overshare personal info.");
        Console.WriteLine("✅ Enable 2FA and watch out for impersonation accounts.{reset}");
    }
    static void TalkEmail(string cyan, string reset)
    {
        Console.WriteLine($"{cyan}📧 Email Scam Tip:");
        Console.WriteLine("🚨 If it looks urgent, emotional, or too good to be true — it’s probably a scam.");
        Console.WriteLine("📮 Always verify the sender’s email address.{reset}");
    }

    static void TalkMFA(string cyan, string reset)
    {
        Console.WriteLine($"{cyan}🧩 Multi-Factor Authentication (MFA) Tip:");
        Console.WriteLine("🔐 MFA adds a second layer of protection — like a code sent to your phone.");
        Console.WriteLine("👍 Always enable MFA when available for better security!{reset}");
    }

    static void TalkBackup(string cyan, string reset)
    {
        Console.WriteLine($"{cyan}💾 Backup Tip:");
        Console.WriteLine("🗃️ Regularly backup your data to a secure location (external drive or cloud).");
        Console.WriteLine("📦 It’ll save your day if your device is stolen or crashes!{reset}");
    }

    static void WhoIsLuna(string cyan, string reset)
    {
        Console.WriteLine(cyan + "\n Awww you wanna know about me? Litreally blushing right now! 😊");
        Console.WriteLine("So I’m Luna, your cozy cyber-buddy. I was built with love to help you navigate the internet safely ❤️");
        Console.WriteLine("I live in your computer (👋 hi from here!) and I’m powered by friendly code and good vibes");
        Console.WriteLine("If you ever feel unsure about something online, come chat with me! I'm always around " + reset);
    }
}


