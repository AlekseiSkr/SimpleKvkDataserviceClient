using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleKvkDataserviceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.DataserviceClient client = new ServiceReference.DataserviceClient();

            Console.Write("Geef Kvk nummer op:");
            string kvknummer = Console.ReadLine();

            var request = new ServiceReference.InschrijvingRequestType
            {
                ItemElementName = ServiceReference.ItemChoiceType.kvkNummer,
                Item = kvknummer,
            };

            var result = client.ophalenInschrijving(request);

            Console.WriteLine("Naam: {0}", result?.product?.maatschappelijkeActiviteit?.naam);
            Console.WriteLine("Press [ENTER] to exit.");
            Console.ReadLine();
        }
    }
}
