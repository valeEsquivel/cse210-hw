public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    // add prompts to the list
    public void AddPrompt()
    {
        _prompts.Add("Describe a person who has positively impacted your life and why");
        _prompts.Add("Write about a moment from today that made you smile");
        _prompts.Add("Reflect on a mistake you made and consider what you learned from it.");
        _prompts.Add("Take five minutes to write about your current thoughts and feelings.");
        _prompts.Add("Describe the sights, sounds, and smells around you right now");
        _prompts.Add("Describe a personal achievement of today, no matter how small, and celebrate it.");
        _prompts.Add("List five things you want to accomplish tomorrow.");
        _prompts.Add("Reflect on a positive interaction you had with someone today.");
        _prompts.Add("Write about a news article or story that caught your attention recently.");
        _prompts.Add("List three things you're grateful for today");
    }
}