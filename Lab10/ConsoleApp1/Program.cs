using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Software<int> list = new Software<int>(30);
            list.Add(1);
            list.Add(3);
            list.Add(10);
            list.Add(5);
            list.Add(3);
            list.Add(10);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
            
            list.Remove(1);
            list.Remove(3);
            
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
            SortedList<string, Software<int>> SoftList = new SortedList<string, Software<int>>();
            SoftList.Add("hm23f5", new Software<int>(10));
            SoftList.Add("afdm", new Software<int>(9));
            SoftList.Add("fdhg52", new Software<int>(8));
            SoftList.Add("mmf2", new Software<int>(5));
            SoftList.Add("xm23f1", new Software<int>(15));
            SoftList.Add("hm23dsff5", new Software<int>(10));
            SoftList.Add("afdffdm", new Software<int>(9));
            SoftList.Add("fddvhg52", new Software<int>(8));
            SoftList.Add("mmdff2", new Software<int>(5));
            SoftList.Add("xmcvf23f1", new Software<int>(15));



            foreach (string key in SoftList.Keys)
            {
                Console.WriteLine("{0}\t{1}", key, SoftList[key]);
            }
            
            
            //удаление k последовательных элементов начиная с n
            Console.WriteLine("Input index:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input index:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n, m = 0; m < k; m++)
            {
                SoftList.RemoveAt(i);
            }
            
            foreach (string key in SoftList.Keys)
            {
                Console.WriteLine("{0}\t{1}", key, SoftList[key]);
            }

            Dictionary<long, string> PhoneBook = new Dictionary<long, string>
            {
                [375259249572] = "I",
                [375259249522] = "Mam",
                [375259249278] = "Dad",
                [375259252525] = "Granny",
                [375259224333] = "Liza",
                [375259249452] = "Grandfather",
            };

            foreach (long number in PhoneBook.Keys)
            {
                Console.WriteLine("+{0}\t{1}", number, PhoneBook[number]);
            }

            Console.WriteLine("Input phoneholder:");
            string ph = Console.ReadLine();
            Console.WriteLine();
            foreach (string str in PhoneBook.Values)
            {
                if (str ==  ph)
                {
                    Console.WriteLine("{0}\t+{1}", str, PhoneBook.Where(x => x.Value == str).FirstOrDefault().Key);
                }
 
            }


            ObservableCollection<Software<int>> observableconcert = new ObservableCollection<Software<int>>();
            void Change(object sender, NotifyCollectionChangedEventArgs a)
            {
                switch (a.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        Software<int> newSoft = a.NewItems[0] as Software<int>;
                        Console.WriteLine("New soft has been added: " + newSoft.SoftName);
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        Software<int> soft = a.OldItems[0] as Software<int>;
                        Console.WriteLine("Soft has been removed: " + soft.SoftName);
                        break;
                }
            }
            observableconcert.CollectionChanged += Change;
            Software<int> soft1 = new Software<int>(5);
            observableconcert.Add(soft1);
            observableconcert.Add(new Software<int>(10));
            observableconcert.Remove(soft1);
        }
    }

    
}
