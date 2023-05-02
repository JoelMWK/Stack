Prompt prompt = new Prompt();
bool action = false;

while (!action)
{
    prompt.Question();
    prompt.Action();

    Console.WriteLine("Press any button to continue");
    Console.ReadLine();
    Console.Clear();
}