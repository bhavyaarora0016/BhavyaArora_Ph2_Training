using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using _1409Lib;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace _1409_ps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerUser cu1 = new CustomerUser();
            cu1.userId = 8427462012;
            cu1.Password = "password";
            cu1.validate();

            CustomerUser cu2 = new CustomerUser();
            cu2.userId = 8427462012;
            cu2.Password = "password123";
            cu2.validate();

            FileStream fs = new FileStream(@"empty.bin",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, cu1);
            bf.Serialize(fs, cu2);

            fs.Flush();
            fs.Close();
            fs.Dispose();

            FileStream fs1 = new FileStream(@"empty.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            CustomerUser[] cu = new CustomerUser[2];

            for (int i = 0; i < 2; i++)
            {
                cu[i] = (CustomerUser)bf1.Deserialize(fs1);

            }
            foreach (var item in cu)
            {
                Console.WriteLine(item.userId);
                Console.WriteLine(item.Password);
                Console.WriteLine(item.login);
                Console.WriteLine(item.date);
            }

            fs1.Flush();
            fs1.Close();
            fs1.Dispose();

            Searching s1 = new Searching();
            s1.mStart();
            s1.DisplayMovies();
            s1.search();

            FileStream fs2 = new FileStream(@"empty1.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write = new BinaryFormatter();
            write.Serialize(fs2, s1);
            fs2.Flush();
            fs2.Close();
            fs2.Dispose();

            FileStream fs3 = new FileStream(@"empty1.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read = new BinaryFormatter();
            Searching s2 = new Searching();
            s2 = (Searching)read.Deserialize(fs3);
            foreach (var item in s2.Search)
            {
                Console.WriteLine($"{item.moviename} {item.movielang} {item.moviegenre} {item.moviestock}");
            }
            fs3.Flush();
            fs3.Close();
            fs3.Dispose();

            Console.WriteLine("Add watchlist");
            Watch e1 = new Watch();
            mer:

            Console.WriteLine("enter name of movie");
            e1.AddtoWatchList();
            Console.WriteLine("Enter yes to continue");
            string d = Console.ReadLine();
            if (d == "yes")
            {
                goto mer;
            }
            foreach (var item in e1.watchlist)
            {

                Console.WriteLine($"{item.Item1.moviename} {item.Item1.movielang} {item.Item1.moviegenre} {item.Item1.moviestock} {item.Item2}");
            }

            string js11 = JsonConvert.SerializeObject(e1);
            FileStream fs7 = new FileStream(@"empty3.json", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fs7);

            sw1.Write(js11);
            sw1.Close();
            sw1.Dispose();
            fs7.Close();
            fs7.Dispose();

            FileStream fs8 = new FileStream(@"empty3.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs8);
            string js12 = sr.ReadToEnd();

            Watch s22 = JsonConvert.DeserializeObject<Watch>(js12);
            foreach (var item in s22.watchlist)
            {
                Console.WriteLine($"{item.Item1.moviename} {item.Item1.movielang} {item.Item1.moviegenre} {item.Item1.moviestock} {item.Item2}");
            }

            Console.WriteLine("Already seen movie");
            e1.releaseList();
            List<Movie> dgg = new List<Movie>();
            foreach (var item in e1.release)
            {
                dgg.Add(item.Item1);
            }

            cu1.alreadySeen = dgg;
            FileStream fs4 = new FileStream(@"empty2.Xml", FileMode.Create, FileAccess.Write);
            System.Xml.Serialization.XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
            xm.Serialize(fs4, s1);
            fs4.Flush();
            fs4.Close();
            fs4.Dispose();
            FileStream fs5 = new FileStream(@"empty2.Xml", FileMode.Open, FileAccess.Read);
            System.Xml.Serialization.XmlSerializer ms = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));

            var t = (CustomerUser)ms.Deserialize(fs5);
            Console.WriteLine("Already seen movies");
            foreach (var item in t.alreadySeen)
            {
                Console.WriteLine($"{item.moviename} {item.movielang} {item.moviegenre} {item.moviestock}");
            }
            fs5.Flush();
            fs5.Close();
            fs5.Dispose();

            Console.WriteLine("which movie's cost would you like to find out?");
            string id = Console.ReadLine();
            e1.totalCost(id);
            FileStream fs9 = new FileStream(@"empty4.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter write1 = new BinaryFormatter();
            write1.Serialize(fs9, e1);
            fs9.Flush();
            fs9.Close();
            fs9.Dispose();

            FileStream fs81 = new FileStream(@"empty4.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter read1 = new BinaryFormatter();

            var sii2 = (Watch)read.Deserialize(fs81);
            foreach (var item in sii2.total)
            {
                Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3}");
            }
            fs81.Flush();
            fs81.Close();
            fs81.Dispose();


        }
    }
}
