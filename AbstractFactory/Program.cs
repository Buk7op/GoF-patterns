using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();

            // client = new Client(new PepsiFactory());
            // client.Run();

            // client = new Client(new SchweppesFactory());
            // client.Run();
        }
    }
}
