public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        
    }
    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            _prompts = new List<string>
            {
                "What made you smile today?",
                "What is something you learned about yourself recently?",
                "Describe a moment you felt proud of yourself.",
                "What challenge did you face today and how did you respond?",
                "Who did you connect with today and what did you talk about?",
                "What is something you are grateful for right now?",
                "How did you take care of yourself today?",
                "What is a goal you want to work towards?",
                "Describe a place where you feel at peace.",
                "What is something you want to remember about today?",
                "How did you help someone today?",
                "What inspired you today?",
                "What is a small victory you had today?",
                "What is something you want to improve in your life?",
                "How did you handle stress or frustration today?",
                "What is a dream you have for your future?",
                "What is something you wish you could tell your past self?",
                "Describe a favorite moment from today.",
                "What is something you are looking forward to?",
                "How did you show kindness today?"
            };
        }
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }
}