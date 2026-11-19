namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book myBook = new Book();
            myBook.title = "mohamed";
            myBook.page = 450;
            object obj = myBook;
            Console.WriteLine($"title : {myBook.title} , page : {myBook.page}");
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q2
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.Equals(myBook));
            Console.WriteLine(myBook .GetHashCode());
            Console.WriteLine(myBook.GetType());
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q3
            Console.WriteLine("Error type: Compile-time error");
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q4
            int totalstudent = 0;
            int totalscore = 10;
            try
            {
                int avg = totalscore / totalstudent;
                Console.WriteLine($"avg : {avg}");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);

            }
            finally {
                Console.WriteLine("Done");
            }


            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q5
            int pages = 300;
            double z = pages;
            Console.WriteLine($"pages :{z}");
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q6
            double price = 49.99;
            int y = (int)price;
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q7
            string pagesText = "464";
            int y1 = Convert.ToInt32(pagesText);
            Console.WriteLine($"y1 : {y1}");
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q8
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"year : {year}");
            Console.WriteLine();
            string badtext = "abc";
            bool isparsed = int.TryParse(badtext, out int w);
            Console.WriteLine(isparsed);
            Console.WriteLine(w);


            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q9
            int pages2 = 464;
            Console.WriteLine(pages2.ToString());
            Console.WriteLine(pages2.GetType());
            #endregion
            Console.WriteLine("-----------------------------------------");
            #region Q10
           
            int copies = 100; 
            object obj1;
            obj1 = copies;
            Console.WriteLine(obj1);
          int n=(int)obj1;
            Console.WriteLine(n);
            #endregion
        }
    }
}
