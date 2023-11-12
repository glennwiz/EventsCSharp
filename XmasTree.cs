public class XmasTree
{
    /*
        Define the delegate
        Define an event based on the delegate
        Raise the event
    */

    public delegate void DataSentEventHandler(string data);
    public event DataSentEventHandler DataSent;
    public string CurrentSubscriber { get; set; } = "Any";

    List<string> XmasTreeStrings { get; set; } = new List<string>();

    public XmasTree()
    {

        XmasTreeStrings.Add("                            *       ");
        XmasTreeStrings.Add("                           o*o      ");
        XmasTreeStrings.Add("                          **o**     ");
        XmasTreeStrings.Add("                         *o***o*    ");
        XmasTreeStrings.Add("                        o***o***o   ");
        XmasTreeStrings.Add("                       **o*****o**  ");
        XmasTreeStrings.Add("                      o****o*o****o ");
        XmasTreeStrings.Add("                           | |      ");
        XmasTreeStrings.Add("                           | |      ");
    }

    internal void GetTree()
    {
        foreach (var item in XmasTreeStrings)
        {
            DataSent?.Invoke(item);
        }

        CurrentSubscriber = "NormalPrinter";

        foreach (var item in XmasTreeStrings)
        {
            DataSent?.Invoke(item);
        }

        CurrentSubscriber = "ColorPrinter";
        foreach (var item in XmasTreeStrings)
        {
            DataSent?.Invoke(item);
        }
    }
}