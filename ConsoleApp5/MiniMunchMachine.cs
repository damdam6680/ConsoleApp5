using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MiniMunchMachine : AbstractVendingMachine
    {
        private readonly int szer;
        private readonly int gl;
        private readonly int wys;
        private int pojemnosc;
        private readonly double[] monety;
        private readonly string typPrzyciskow;
        private double bank = 0;
        List<Product> products = new List<Product>();
        Dictionary<char,List<Product>> kasetka = new Dictionary<char,List<Product>>();
        private char kot = 'A';

        public double Bank { get => bank; set => bank = value; }

        public MiniMunchMachine(int szer, int gl, int wys, int pojemnosc, double[] monety, string typPrzyciskow)
        {
            this.szer = szer;
            this.gl = gl;
            this.wys = wys;
            this.pojemnosc = pojemnosc;
            this.monety = monety;
            this.typPrzyciskow = typPrzyciskow;
        }

        public override void AddProduct(Product pro)
        {
            if(pojemnosc != 0)
            {
                products.Add(pro);
                kasetka.Add(kot, products);
                kot++;
                pojemnosc--;
            }
            else
            {
                Console.WriteLine("nie ma miejsca w maszynie");
            }
           
        }
        


        public override void AddMomeny(double kwota)
        {
            for (int i = 0; i < monety.Length; i++)
            {
                if (kwota == monety[i])
                {
                    bank += kwota;
                    
                }
                else
                {
                    Console.WriteLine("moneta nie przyjmuje takiej kowty");
                    
                }
            }
        }

        public override void BuyProduct(char kod)
        {
            int i=0;
            foreach(KeyValuePair<char,List<Product>> kvt in kasetka)
            {
                if(kvt.Key == kod)
                {
                    if (kvt.Value[i].Cena < Bank)
                    {
                        Console.WriteLine("wydawanie produktu " + kvt.Value[i].Cena);
                        bank -= kvt.Value[i].Cena;
                        kasetka.Remove(kod);
                        break;
                    }   
                    else
                    {
                        Console.WriteLine("nie masz wystarczajaca pieniedzy");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("nie ma takiego produktu o takim kodzie");
                    break;
                }
                i++;
            }
        }

        public override void returnCoins()
        {
            Console.WriteLine("Zwracam" + Bank);
            Bank = 0;

        }

        public override void AddProduct(char kod, Product pro)
        {
            if (pojemnosc != 0)
            {
                kasetka.Add(kod, products);
                pojemnosc--;
            }
            else
            {
                Console.WriteLine("nie ma miejsca w maszynie");
            }
        }
        public void ShowProducts()
        {
            int i = 0;
            foreach (KeyValuePair<char, List<Product>> kvt in kasetka)
            {
                Console.WriteLine(kvt.Key + " nazwa: " + kvt.Value[i].Nazwa_ + "cena: " + kvt.Value[i].Cena);
                i++;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + szer + " " + gl + " " + wys;
        }
    }
}
