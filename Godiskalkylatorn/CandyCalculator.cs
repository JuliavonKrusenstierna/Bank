using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Godiskalkylatorn
{
    [Serializable]

    class CandyCalculator : Person 
    {
        public int NumberOfCandies { get; set; }


        private List<Person> people; //Association till Person

        public CandyCalculator() // Konstruktor som körs när ett nytt objekt skapas
        {
            people = new List<Person>(); // nytt objekt
        }

        public List<Person> GetPeople()
        {
            return people;
        } // orginallistan

        public List<Person> GetPeopleByName()
        {
            return people.OrderBy(x => x.Name).ToList();
        } // metod för att sortera listan efter namn

        public List<Person> GetPeopleByAge()
        {
            return people.OrderBy(x => x.Age).ToList();
        } // metod för att sortera listan efter ålder

        public void AddPerson(string name, int age)
        {
            Person person = new Person()
            {
                Name = name,
                Age = age
            };

            people.Add(person);

        } // metod för att lägga till en person i listan

        public int DivideCandy(int inPutCandies)  // Metod som fördelar godisarna rättvist, även resten 
        {

            NumberOfCandies = inPutCandies / people.Count;
           int restCandy = inPutCandies % people.Count;

            foreach (Person person in people)
            {
                if (restCandy > 0)
                {

                    person.Candies = NumberOfCandies + 1;
                    restCandy--;

                }

                else
                    person.Candies = NumberOfCandies;
            }
            return Candies;

        }

        public void DivideCandyByAge(int inPutCandies)           // Metod som fördelar godisar efter ålder

        {
            int restCandy = 0;
            NumberOfCandies = inPutCandies / people.Count;
            restCandy = inPutCandies % people.Count;

            foreach (Person person in GetPeopleByAge())
            {
                if (restCandy > 0)
                {
                    person.Candies = NumberOfCandies + 1;
                    restCandy--;                 
                }

                else
                    person.Candies = NumberOfCandies;
            }
        }
    

        public void DivideCandyByName(int inPutCandies)

        {        
            NumberOfCandies = inPutCandies / people.Count;
            int restCandy = inPutCandies % people.Count;

            foreach (Person person in GetPeopleByName())
            {
                if (restCandy > 0)
                {                
                    person.Candies = NumberOfCandies + 1;
                    restCandy--;
                }

                else
                    person.Candies = NumberOfCandies;
            }          
        } // metod som fördelar godisar efter namn





    }

}


