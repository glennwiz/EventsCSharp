public class NormalPrinter
{
    /*
        Subscribe to the event with a method, name does not mater
    */
    XmasTree publisher;
    internal void Subscribe(XmasTree publisher)
    {
        this.publisher = publisher;
        publisher.DataSent += PrintDataSendt;
    }

    private void PrintDataSendt(string data)
    {
        if (publisher.CurrentSubscriber == "NormalPrinter" || publisher.CurrentSubscriber == "Any")
        {
            Console.WriteLine($"{data}");
        }
    }
}