using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "When I was a child, I loved to...",
                "What gets me excited to wake up in the morning?",
                "When I think of the impact I want to make, I think about doing...",
                "What is most important to me in my life?",
                "When do I feel most alive?",
                "Make a list of things that bring you joy.",
                "What do I want to be remembered for?",
                "How can I make the world a better place?",
                "Make a list of things that energize you.",
                "What brings me fulfillment in life?",
                "What's one action I can take today to make me 1% better than yesterday?",
                "Make a list of areas you want to improve on in life.",
                "How can I make my personal growth more of a priority?",
                "Who do I want to be in five years? Include as much detail as possible.",
                "What do I need to let go of and why?",
                "Write down three things that make you feel valuable. How can you incorporate those into your life more often?",
                "Who is someone I need to let go of and why?",
                "What positive changes have I made this year?",
                "How can I feel more fulfilled every day?",
                "What is my dream job and why?",
                "How do I define success? Does my current job fulfill that definition?",
                "Do I find purpose in my current career path?",
                "What do I value in work? Does my current work provide that?",
                "If failure wasn't an option, what would I do for work?",
                "What are my career ambitions?",
                "How do I want to be remembered in the workplace?",
                "What's more important: loving what I do or making the highest income?",
                "What life lessons has worked taught me? How can I incorporate those in my non-work life?",
                "Confucius once said, “Choose a job you love, and you will never have to work a day in your life. How does this make you feel about your current job?",
                "What past experiences caused me to make mistakes? Why?",
                "When I think about moments where I felt joy, what was I doing? How can I do more of that?",
                "What can I learn from my past that can improve my future?",
                "Honest self-reflection opens your mind to reprogramming, change, success, and freedom. How can I practice more honest self-reflection?",
                "What past experiences created breakthroughs? Why?",
                "List five lessons your past experiences (good or bad) have taught you.",
                "Reflect on a moment where you felt excited about life. Where were you? What were you doing? Who were you with? Use as much detail as possible.",
                "Make a list of people who support you the most. Why is their support important to you?",
                "What hobbies do I cherish most and why?",
                "ow have I grown in the last 12 months?",
                "What hobby or skill makes you me excited?",
                "What's one thing I enjoy doing that makes you lose track of time?",
                "If money wasn't a concern, what would you do with your life?",
                "What's one topic I can talk about endlessly?",
                "When I think of doing something that makes me fulfilled, what comes to mind?",
                "If you were guaranteed success, what would you chase?",
                "What's your most favorite way to spend your time?",
                "Whose life inspires you most and why?",
                "When I feel most alive, I am doing...",
                "My life is most ideal when...",
                "To increase your awareness, you must invite new practices into your life. What are three new practices or exercises you can do to continue to become more aware of who you are?",
                "I feel most happy when...",
                "What type of situations trigger me, and how can I deal with them better in the future?",
                "When I am processing tough emotions, it's best for me to...",
                "If today were your last day, would you want to do what you're about to do? If not, why?",
                "How do I respond to challenges? Is there a better approach for me to take?",
                "What am I insecure about? How can I learn from my insecurities?",
                "When do I feel my best? What am I doing?",
                "What is working well in my life today?",
                "Spend five to 15 minutes writing about the dream version of yourself. Who do they surround themselves with? How do they spend their weekends? What are their favorite hobbies? What to do they do for a living? Do they like to travel, or are they homebodies?",
                "What are my core values? Am I living in alignment with them?",
                "What fears hold you back from living as your most authentic self?",
                "What (or who) would I need to get rid of to live as my most authentic version?",
                "Write a list of everything that brings you joy. Then, challenge yourself to do one thing from your list every day this week.",
                "Where in life do you feel like you're not living as your most authentic self?",
                "What's your ideal version? How are they different than who you're living as now?",
                "List five core values that help you live authentically.",
                "What are you afraid would happen if you share your most authentic self with the world?",
                "How would I feel if I didn't live as my most authentic version?",
                "You're the average of the five people you spend the most time with. Do the people you spend the most time with have qualities and characteristics you wish to portray?",
                "Think about a relationship that is near and dear to your heart. What is going well, and what can you improve?",
                "What type of person do I want to show up as for my friends and family?",
                "What do you value most in a friend?",
                "When I think of my closest relationships, I feel...",
                "Who do I trust most and why?",
                "What do you value most in a life partner?",
                "How can you better support your friends and family?",
                "What qualities do you bring to a relationship?",
                "What three important lessons have you learned from past relationships?",
                "What are three moments that made you smile today?",
                "List three challenges you faced and how you overcame each one.",
                "What are you looking forward to today?",
                "What, if anything, went wrong today, and how can I improve on it tomorrow?",
                "List three events that made you feel loved today.",
                "What are three thoughts that made you smile today?",
                "How often do I procrastinate? How can I take action more easily?",
                "How do I have an impact on my surrounding community?",
                "What did I do during my morning routine, and what was my favorite part?",
                "Explain, in detail, your ideal day.",
                "Today, I am grateful for:",
                "Gratitude can serve as a flashlight that illuminates the most authentic version of yourself. The more you practice being grateful, the brighter your flashlight will shine. How does this make you feel?",
                "What recent accomplishment are you proud of?",
                "When you think of your closest relationships, who are you grateful for and why?",
                "What past experiences are you grateful for?",
                "How has practicing gratitude improved the quality of your life?",
                "What mistake or failure are you grateful for? What did it teach you?",
                "What's on memory from the last year that you're grateful for? Why?",
                "How can you become more grateful every day?",
                "What’s something that you grateful to have today that you didn’t have a year ago?",
                };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Until next time, keep writing!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}