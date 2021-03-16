using System;

namespace CollierFirlus_1322Lab14
{
    class Movies
    {
        //Class: 1322L
        //Section: 06
        //Term: Fall 2020
        //Instructor: Peter Adeojo
        //Name: Collier Firlus
        //Lab 14
        static void Main(string[] args)
        {
            BluRayCollection MyCollection = new BluRayCollection();
            MyCollection.Add(new BluRayDisc("Lord of the Rings", "Peter Jackson", 2001, 10.00));
            MyCollection.Add(new BluRayDisc("Harry Potter", "Chris Colombus", 2001, 15.00));
            MyCollection.Add(new BluRayDisc("Inception", "Christopher Nolan", 2010, 20.00));
            MyCollection.Add(new BluRayDisc("The Hateful Eight", "Quentin Tarantino", 2015, 30.00));
            MyCollection.Add(new BluRayDisc("Star Wars", "George Lucas", 1977, 10.00));

            Console.WriteLine(MyCollection.toString());
            MyCollection.Print();
        }
    }
}
