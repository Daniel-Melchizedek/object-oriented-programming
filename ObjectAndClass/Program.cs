namespace ObjectAndClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            customer.FirstName = "Daniel";

            customer.Validate();

        }
    }
}
