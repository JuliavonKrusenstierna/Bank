using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace Godiskalkylatorn
{
    class CandyCalculator : Person
    {

//        Om jag hade gjort på rätt sätt
//Skapa en klass med personer och istället hade en lista av typen person.
//Varje person massa egenskaper.
//Då kan man plocka ut egenskaperna. 


        public int NumberOfCandies { get; set; }


        private List<Person> people; //Association till Person

        public CandyCalculator() // Konstruktor som körs när ett nytt objekt skapas
        {
            people = new List<Person>(); // nytt objekt

        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public void AddPerson(Person person)
        {
          
            people.Add(person);

        }

        public int DivideCandy(int inPutCandies)
        {

            NumberOfCandies = inPutCandies / people.Count;

            foreach (Person person in people)
            {
                person.Candies = NumberOfCandies;
            }
            return Candies;

        }

        public List<Person> DivideCandyByAge(int inPutCandies)           

        {
            NumberOfCandies = inPutCandies / people.Count;
            foreach (Person person in people.OrderBy(x => x.Age))
            {
                person.Candies = NumberOfCandies;
            }

            return people.OrderBy(x => x.Age).ToList();
          
        }

        public List<Person> DivideCandyByName(int inPutCandies)

        {
            NumberOfCandies = inPutCandies / people.Count;
            foreach (Person person in people.OrderBy(x => x.Name))
            {
                person.Candies = NumberOfCandies;
            }

            return people.OrderBy(x => x.Name).ToList();

        }
            
    }




    //   Metoder // kolla upp hur man gör med resten

    // Avklarade
    // AddPerson
    //CandyCalculator
    //GetPeople
    //DivideCandyByAge
    //DivideCandyByName

}



