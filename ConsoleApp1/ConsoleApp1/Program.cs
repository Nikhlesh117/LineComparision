using LineComparision.LineComparision;

namespace LineComparision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculateLine obj = new CalculateLine(10, 20, 30, 40);
            double Line_one = obj.LengthLine();
            CalculateLine obj_two = new CalculateLine(20, 40, 60, 80);
            double Line_Two = obj_two.LengthLine();

            if (Line_one.Equals(Line_Two))
            {
                Console.WriteLine("Both the Line are Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }


            if(Line_one.CompareTo(Line_Two)==0)
            {
                Console.WriteLine("Both Line are Equal");
            }
            else if(Line_one.CompareTo(Line_Two) >0 )
            {
                Console.WriteLine("Line One is greater than line two");
            }
            else
            {
                Console.WriteLine("Line Two is greater than line One");
            }
        }
    }
}