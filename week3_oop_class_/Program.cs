using week3_oop_class_;

class Program
{
    static void Main(string[] args)
    {
        // creating an object (variable of a certain class type) 
        transaction transaction = new transaction();

        transaction.month = 1;
        transaction.val = 10.5f;

        Console.WriteLine("Transaction value is " + transaction.val);

        float val = 10.5f;
        Console.WriteLine("Transaction value is "+ val);


    }
}
