using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
   public class Program
    {
       public static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");



            //int tmp1 = 1;

            //int tmp7 = 2;
            //int? tmp1b = null;
            //double tmp2 = 2.0;
            //string tmp3 = "aaaa";
            //bool tmp4 = true;

            //var tmp5 = 1;
            //var tmp5b = "ala";
            //var tmp6 = "ma kota";

            //Console.WriteLine($"{tmp5b} {tmp6} {tmp1 + tmp7}");

            //var path = @"C:\Users\s16492\Desktop\Cw1";
            //var newPerson = new Person { FirstName = "Adrian" };


            var url = args.Length>0?args[0]:"https://www.pja.edu.pl";
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var htmlContent = await response.Content.ReadAsStringAsync();

                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                var matches = regex.Matches(htmlContent);


                foreach (var match in matches)
                {
                    Console.WriteLine(match.ToString());
                }


            }





        }
    }
}
