// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

Console.WriteLine("Hello, World!");

Product product = new Product("cola",12,"2202");
Product product1 = new Product("cola1",12,"2202");
double[] monety = { 0.20, 0.50, 1, 2, 5 };
MiniMunchMachine mini = new MiniMunchMachine(12, 32, 12, 20, monety, "A-Z");
mini.AddProduct(product);
mini.AddProduct(product);
mini.AddProduct(product);
mini.AddProduct(product);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
mini.AddProduct(product1);
string zap = "";
while (true)
{
    Console.WriteLine("Witam w programie");
    string w = Console.ReadLine().ToUpper();
    zap += w + "\n";
    switch (w)
    {
        case "A":
            Console.WriteLine("Pokaż produkty");
            mini.ShowProducts();
            break;
            
        case "B":
            Console.WriteLine("Wrzuć monetę");
            string moneta = Console.ReadLine();
            zap += w + " " + moneta + "\n";
            mini.AddMomeny(double.Parse(moneta));
            
            break; 
        case "C":
            Console.WriteLine("Kup produkt");
            string kod = Console.ReadLine();
            mini.BuyProduct(char.Parse(kod));
            zap += w + " " + kod + "\n";
            break; 
        case "D":
            Console.WriteLine("Pokaż ilość wrzuconych pieniędzy");
            Console.WriteLine(mini.Bank);
            zap+= w + "\n";
            break; 
        case "E":
            Console.WriteLine("Wyciąg monety");
            mini.returnCoins();
            break;
        case "3721":
            string nazwa = Console.ReadLine();
            string cena = Console.ReadLine();
            string data = Console.ReadLine();
            Product pro = new Product(nazwa, double.Parse(cena), data);
            mini.AddProduct(pro);
            zap += w + " " + nazwa + " " + cena + " " + data + "\n";
            break;
        case "2137":
            string text =  File.ReadAllText("D:\\log.txt");
            Console.WriteLine(text);
            break;
        case "F":
            File.WriteAllText("D:\\log.txt", zap);
            return;
        default:
            Console.WriteLine();
            break;

    }

}
