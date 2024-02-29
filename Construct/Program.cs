namespace Construct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(6, 5, 2000);
            Console.WriteLine(d1.GetDate());
        }

        // dd/mm/yyyy       dd(int) / month(int) / year(int)

    }




    public class Date
    {
        private static readonly int[] DayToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DayToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // تعني انه لا احد يسطيع التعديل على هذا الفيلد او المتغير الا في الكونستراكتور فقط : readonly 


        // يتم عمل المتغيرات (برايفت) لاجل عدم استخدامها في أى مكان غير الكلاس الخاص بها

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;


        /* Constructors Syntax 
            < AccessModifier>  <typeName>(Parameter list)
            {
                series of statement 
            }
        */
        public Date(int day, int month, int year)
        {
            var isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeapYear ? DayToMonth366 : DayToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    // للتعبير عن الفيلد وعدم الاخطلاط بين الباراميتار و الفيلد : this
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

            }

        }

        // هذا الشكل اذا اردت عمل (اوفر لودينج للاكونستراكتر) بدون اخذ نسخة كاملة من الاول 
        public Date(int year) : this(01, 01, year)
        {

        }
        public Date(int month,int year) : this(01, month, year)
        {

        }

        public string GetDate()
        {
            return $" {day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')} ";
        }

    }
}