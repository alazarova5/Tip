using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Veiw
{
    public class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount{ get; set; }
        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent youwant to tip:");
            Percent = double.Parse(Console.ReadLine());
        }
        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }
        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: {0:C} ", TipAmount);
            Console.WriteLine("The total will be {0:C}" , Total);
        }
    }
}
