using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLaba2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double interest_basic_job = 0.2;
            double interest_extra_job = 0.15;
            double interest_royalties = 0.1;
            double interest_sale_of_property = 0.05;
            double interest_transfers_from_abroad = 0.05;

            Podatok os_robota = new Podatok("Oсновна робота", interest_basic_job * 20000);
            Podatok extra_job = new Podatok("Додаткова робота", interest_extra_job * 10000);
            Podatok royalties = new Podatok("royalties", interest_royalties * 30000);
            Podatok sale_of_property = new Podatok("sale_of_property", interest_sale_of_property * 40000);
            Podatok transfers_from_abroad = new Podatok("transfers_from_abroad", interest_transfers_from_abroad * 40000);
            Podatki podatki = new Podatki(os_robota, extra_job, royalties, sale_of_property, transfers_from_abroad);
            podatki.ShowList();
            podatki.SortPodatok();
            Console.WriteLine("");
            Console.WriteLine("");
            podatki.ShowList();
            podatki.SumaPodatkiv();
        }
    }
    class Podatok
    {
       
        public string name;
        public double podatok;
        public Podatok(string Name, double Podatok)
        {
            name = Name;
            podatok = Podatok;
        }

    }
    class Podatki
    {
        public List<Podatok> ListPodatkiv = new List<Podatok>();
        public Podatki(params Podatok[] p)
        {
            foreach (var i in p)
            {
                AddPodatok(i);
            }
        }
        public void AddPodatok(Podatok podatok)
        {
            ListPodatkiv.Add(podatok);
        }
        public void ShowList()
        {
            Console.WriteLine($"{"Name",10}{"Suma Podatka", 10}");
            foreach(var i in ListPodatkiv)
            {
                Console.WriteLine($"{i.name,10}{i.podatok, 10}");
            }
        }
        public void SortPodatok()
        {
            for(int i = 0; i < ListPodatkiv.Count; i++)
            {
                for(int j = i + 1; j < ListPodatkiv.Count; j++)
                {
                    if (ListPodatkiv[i].podatok > ListPodatkiv[j].podatok)
                    {
                        var sort = ListPodatkiv[i];
                        ListPodatkiv[i] = ListPodatkiv[j];
                        ListPodatkiv[j] = sort;
                    }
                }
            }
        }
        public void SumaPodatkiv()
        {
            double suma = 0;
            foreach (var n in ListPodatkiv)
            {
                suma += n.podatok;
            }
            Console.WriteLine("");
            Console.WriteLine(suma);
        }
    }
}
