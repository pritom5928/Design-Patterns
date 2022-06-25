using Observer.SubjectImplementations;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject RedMi = new Subject("Redmi Note 7 Pro", 21000, "Out of Stock");

            //User Pritom will be created and user1 object will be registered to the subject
            Observer.ObserversImplementations.Observer user1 = new Observer.ObserversImplementations.Observer("Pritom", RedMi);

            //User Jugal will be created and user1 object will be registered to the subject
            Observer.ObserversImplementations.Observer user2 = new Observer.ObserversImplementations.Observer("Jugal", RedMi);

            //User Pinke will be created and user3 object will be registered to the subject
            Observer.ObserversImplementations.Observer user3 = new Observer.ObserversImplementations.Observer("Pinke", RedMi);


            Console.WriteLine("Red Mi Mobile current state : " + RedMi.getAvailability());
            Console.WriteLine();


            // Now product is available
            RedMi.setAvailability("Available");
            Console.Read();
        }
    }
}
