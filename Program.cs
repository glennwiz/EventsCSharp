var publisher = new XmasTree();

var normalPrinter = new NormalPrinter();
var colorPrinter = new ColorPrinter();

normalPrinter.Subscribe(publisher);
colorPrinter.Subscribe(publisher);

publisher.GetTree();

Console.ReadLine();