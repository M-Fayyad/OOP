namespace Properties 
    //  تعزيز حماية الكلاس او الكبسولاشن : properties
    
    // هي طريقة للتعامل مع شىء خاص 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar doll = new(0m)
            {
                Amount = 0m //set
            };

            Console.WriteLine(doll.Amount); //get
            Console.WriteLine(doll.IsZero); //get
        }
    }



    public class Dollar
    {
        private decimal amount;

        /*  Property Syntax
         *  <AccessModifier>  <Datatype>  <name of filed..> 
         *  {
         *      get{}
         *      اذا اردت ارجاع فيمة الفيلد البرايفت 
         *      
         *      set{}
         *      اذا اردت وضع قيمة للفيلد البرايفت 
         *  }
          
         */
        public decimal Amount
        {
            get 
            {
                return this.amount;
            }
            set 
            {   // validation
                // من مميزاتها اقدر اعمل فاليديشن على الفيلد من هنا داخل الكلاس بدون التعديل في الكلاس الاساسي اللي فيه (المين)و
                this.amount = ProcessValue(value);
            }
        }

        public bool IsZero
        {
            get
            {
                return this.amount == 0;
            }
        }


        public Dollar(decimal amount)
        {
            this.amount = ProcessValue(amount);
        }
        public decimal ProcessValue (decimal value) => value <= 0 ? 0 : Math.Round(value, 2);
    }
}