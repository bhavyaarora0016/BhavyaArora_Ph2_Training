using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1409Lib
{
    [Serializable()]
    public class Movie
    {
        public string moviename { get; set; }
        public string movielang { get; set; }
        public int moviestock { get; set; }
        public string moviegenre { get; set; }

        public Movie()
        {

        }
        public Movie(string name, string language, string genre, int stock)
        {
            moviename = name;
            movielang = language;
            moviestock = stock;
            moviegenre = genre;
        }
    }

    [Serializable()]

    public class Searching
    {
        public List<Movie> Search { get; set; }

        public static List<Movie> movies = new List<Movie>();

        public void mStart()
        {
            movies.Add(new Movie("top gun", "english", "action", 16));
            movies.Add(new Movie("the black phone", "english", "horror", 7));
            movies.Add(new Movie("central intelligence", "english", "comedy", 20));
            movies.Add(new Movie("palm springs", "english", "romance", 21));
        }

        public void search()
        {
            Console.WriteLine("Search by\n 1.Name\n 2.Language\n 3.Genre");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter movie name: ");
                    string namesearch = Console.ReadLine();
                    var chname = movies.Where(cn => cn.moviename == namesearch).ToList();

                    if (chname != null)
                    {
                        Search = chname;
                    }
                    else
                    {
                        Console.WriteLine("movie not found");
                    }
                    break;

                case 2:
                    Console.WriteLine("enter movie language: ");
                    string langsearch = Console.ReadLine();
                    var chlang = movies.Where(cn => cn.movielang == langsearch).ToList();

                    if (chlang != null)
                    {
                        Search = chlang;
                    }
                    else
                    {
                        Console.WriteLine("language unavailable.");
                    }
                    break;

                case 3:
                    Console.WriteLine("enter movie language: ");
                    string genresearch = Console.ReadLine();
                    var chgenre = movies.Where(cn => cn.moviegenre == genresearch).ToList();

                    if (chgenre != null)
                    {
                        Search = chgenre;
                    }
                    else
                    {
                        Console.WriteLine("genre unavailable.");
                    }
                    break;


                default:
                    break;
            }



        }

        public void AddMovies()
        {
            Movie mv = new Movie();
            Console.WriteLine("enter movie name: ");
            mv.moviename = Console.ReadLine();

            Console.WriteLine("enter movie language: ");
            mv.movielang = Console.ReadLine();

            Console.WriteLine("enter movie genre: ");
            mv.moviegenre = Console.ReadLine();

            Tuple<string, string, string> mvt = Tuple.Create<string, string, string>(mv.moviename, mv.movielang, mv.moviegenre);

            Predicate<Tuple<string, string, string>> k = (i) =>
            {
                int flag = 0;
                foreach (var item in movies)
                {
                    if (item.moviename == i.Item1 && item.movielang == i.Item2 && item.moviegenre == i.Item3)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            if (k(mvt))
            {
                Console.WriteLine("movie exists");
            }
            else
            {
                movies.Add(mv);
            }
        }

        public void DeleteMovies()
        {
            Movie mvd = new Movie();

            Console.WriteLine("enter movie name: ");
            mvd.moviename = Console.ReadLine();

            Console.WriteLine("enter movie language: ");
            mvd.movielang = Console.ReadLine();

            Console.WriteLine("enter movie genre: ");
            mvd.moviegenre = Console.ReadLine();

            foreach (var item in movies)
            {
                if (item.moviename == mvd.moviename && item.movielang == mvd.movielang && item.moviegenre == mvd.moviegenre)
                {
                    movies.Remove(item);
                }
            }
        }

        public void DisplayMovies()
        {
            foreach (var item in movies)
            {
                Console.WriteLine("movie name: " + item.moviename);
                Console.WriteLine("movie language: " + item.movielang);
                Console.WriteLine("movie genre: " + item.moviegenre);
                Console.WriteLine("----------");
            }
        }
    }

    [Serializable()]

    public class CustomerUser : Searching
    {
        public long userId { get; set; }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string login { get; set; }
        public DateTime date
        {
            get { return DateTime.Now; }
        }

        public bool validate()
        {
            if (userId == 8427462012 && Password == "password")
            {
                login = "true";
                return true;
            }
            else
            {
                login = "false";
                return false;
            }
        }

        public List<Movie> alreadySeen { get; set; }


    }

    [Serializable()]

    public class Watch : Searching
    {
        public List<Tuple<Movie, DateTime>> watchlist = new List<Tuple<Movie, DateTime>>();
        public List<Tuple<Movie, int>> release = new List<Tuple<Movie, int>>();
        public List<Tuple<string, int, double>> total = new List<Tuple<string, int, double>>();

        public void AddtoWatchList()
        {
            Console.WriteLine("enter movie name: ");
            string mnameadd = Console.ReadLine();
            var mnadd = movies.Where(m => m.moviename == mnameadd).ToList();

            if (mnadd != null)
            {
                foreach (Movie item in mnadd)
                {
                    Console.WriteLine(item.moviename);

                    movies.Remove(item);
                    item.moviestock = item.moviestock - 1;
                    Console.WriteLine("Enter year");
                    int yr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt1 = Convert.ToInt32(Console.ReadLine());
                    DateTime t1 = new DateTime(yr1, mon1, dt1);

                    Tuple<Movie, DateTime> tupaddwl = Tuple.Create<Movie, DateTime>(item, t1);
                    movies.Add(item);
                    watchlist.Add(tupaddwl);

                }
            }
            else
            {
                Console.WriteLine("cannot add movie to watchlist");
            }
        }

        public void releaseList()
        {
            string rl = Console.ReadLine();
            Tuple<Movie, DateTime> k = null;

            foreach (var item in watchlist)
            {
                if (rl == item.Item1.moviename)
                {
                    k = item;

                    movies.Remove(item.Item1);
                    item.Item1.moviestock = item.Item1.moviestock + 1;

                    Console.WriteLine("Enter year");
                    int yr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt = Convert.ToInt32(Console.ReadLine());

                    DateTime t = new DateTime(yr, mon, dt);
                    TimeSpan ts = t - item.Item2;
                    Tuple<Movie, int> poi = Tuple.Create<Movie, int>(item.Item1, ts.Days);
                    release.Add(poi);
                    movies.Add(item.Item1);


                }
            }
            watchlist.Remove(k);
        }

        public void totalCost(string tc)
        {
            int flag = 0;
            foreach (var item in release)
            {
                if (tc == item.Item1.moviename)
                {
                    flag = 1;
                    Console.WriteLine(item.Item1.moviename);
                    Console.WriteLine("enter amount for one day: ");

                    double Cost = Convert.ToInt32(Console.ReadLine());
                    double k = 0.18 * Cost;
                    double ty = item.Item2 * 0.01 * Cost;
                    double yt = k + ty + Cost;

                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.moviename, item.Item2, yt);

                    total.Add(k2);

                }
            }

            foreach (var item in watchlist)
            {
                if (tc == item.Item1.moviename)
                {
                    Console.WriteLine(item.Item1.moviename);
                    Console.WriteLine("Enter the cost for one day");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    TimeSpan tu = DateTime.Now - item.Item2;
                    double k = 0.18 * Cost;
                    double ty = (tu.Days) * 0.01 * Cost;
                    double yt = k + ty + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.moviename, tu.Days, yt);

                    total.Add(k2);
                }
                else if (flag != 1)
                {
                    foreach (var item1 in movies)
                    {
                        if (tc == item1.moviename)
                        {
                            Console.WriteLine(item1.moviename);
                            Console.WriteLine("Enter the cost for one day");
                            double Cost = Convert.ToInt32(Console.ReadLine());

                            double k = 0.18 * Cost;
                            double ty = 0 * 0.01 * Cost;
                            double yt = k + ty + Cost;
                            Console.WriteLine($"GST is {k}");
                            Console.WriteLine($"Bluray cost is {ty}");
                            Console.WriteLine("Total cost is" + " " + yt);
                            Tuple<string, int, double> k2 = Tuple.Create(item.Item1.moviename, 0, yt);

                            total.Add(k2);

                        }
                    }
                }

            }


        }
    }
}   
