using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Product
    {
        private string nazwa_;
        private double cena_;
        private string data_;

        public Product(string nazwa_, double cena_, string data_)
        {
            try
            {
                if(nazwa_ == "") {
                    throw new Exception("nazwa jest pusta");
                }
                else if(data_== "") { throw new Exception("data jest pusta"); }
                else if(cena_ < 0 ) { throw new Exception("cena nie moze byc ujema"); }
                else
                {
                    this.nazwa_ = nazwa_;
                    this.cena_ = cena_;
                    this.data_ = data_;
                }
                
            }catch(Exception e) { Console.WriteLine(e.ToString()); }
        
        }

        public string Nazwa_ { get => nazwa_; set {

                try
                {
                    if(value== "")
                    {
                        
                        throw new Exception("nazwa jest pusta");
                        
                    }
                    else
                    {
                        nazwa_ = value;
                    }

                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } 
        }
        public double Cena {
            get { return cena_; } 
            set {
                try
                {
                    if(value < 0)
                    {
                        cena_ = 0;
                        throw new Exception("cena nie moze byc ujemna");
                        
                    }
                    else
                    {
                        cena_ = value;
                    }
                   
                }catch(Exception ex) { 
                    Console.WriteLine(ex.ToString());
                    
                }
            } 
        }
        public string Data_ { get => data_; set
            {
                try
                {
                    if(data_ == "")
                    {
                        throw new Exception("data jest pusta");
                    }
                    else
                    {
                        data_ = value;
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public override string ToString()
        {
            return nazwa_ + " " + cena_;
        }
    }
}
