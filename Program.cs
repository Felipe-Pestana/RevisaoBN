Submarine submarine = new();
Destroyer destroyer = new();
Carrier carrier = new();

//Console.Clear();

char a;

Console.Write("Informe o alinhamento do Submarino: ");
a = char.Parse(Console.ReadLine());
submarine.ChooseAlignment(a);

Console.Write("Informe o alinhamento do Destroyer: ");
a = char.Parse(Console.ReadLine());
destroyer.ChooseAlignment(a);

Console.Write("Informe o alinhamento do Porta Aviões: ");
a = char.Parse(Console.ReadLine());
carrier.ChooseAlignment(a);

Console.Write(submarine.ToString());
Console.Write(destroyer.ToString());
Console.Write(carrier.ToString());
