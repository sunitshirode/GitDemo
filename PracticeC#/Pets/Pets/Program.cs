using System;



namespace Pets

{

    class Pets

    {
        String nameOfPet;
        String typeOfPet;
        float weightOfPet;

        void speak()
        {
            Console.WriteLine(nameOfPet + "\tcan speak.");
        }

        void eat()
        {
            Console.WriteLine(nameOfPet + "\tcan eat.");
        }
        void walk()
        {
            Console.WriteLine(nameOfPet + "\tcan walk.");
        }
        void fly()
        {
            Console.WriteLine(nameOfPet + "\tcan fly.");
        }
        Pets(String name)
        {
            nameOfPet = name;
        }
        static void Main(string[] args)
        {
            Pets dog = new Pets("dog");

            Pets cat = new Pets("cat");

            Pets duck = new Pets("duck");

            Pets sparrow = new Pets("sparrow");

            dog.walk();
            dog.eat();

            cat.walk();
            cat.eat();

            duck.eat();
            duck.speak();
            duck.walk();

            sparrow.fly();
        }
    }
}
/*create Pets class. 
 * create some properties: Name, Type, Weight
 * create some methods: Speak, eat, walk, fly
 * Create objects of pets - dog, cat, ducks, sparrow
 * if a dog is speaking, it should print 'dog is speaking'.
 * similarly for others
*/
