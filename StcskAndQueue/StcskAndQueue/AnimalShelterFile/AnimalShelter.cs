using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StcskAndQueue.AnimalShelters
{
    public class AnimalShelter
    {
        public Queue Cat = new Queue();
        public Queue Dog = new Queue();

        public void Enqueue(Animal animal)
        {
            
            if (animal is Cat)
            {
                Cat cat = new Cat();

                Cat.Enqueue(cat);
            }
            else if (animal is Dog)
            {
                Dog dog = new Dog();

                Dog.Enqueue(dog);
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return (Animal)Cat.Dequeue();

            }
            else if (pref == "dog")
            {
                return (Animal)Dog.Dequeue();
            }
            return null;
        }



        //internal void Enqueue(Dog dog1)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void Enqueue(Cat cat1)
        //{
        //    throw new NotImplementedException();
        //}

        //public string QueuePrint()
        //{
        //    string fullNude = "";
        //    Node temp = Queue.front;

        //    while (temp != null)
        //    {
        //        fullNude += $"[ {temp.data} ] -> ";

        //        temp = temp.next;
        //    }
        //    fullNude += "NULL";

        //    return fullNude;
        //}
        //public class PrintQueue : System.Printing.PrintSystemObject;




    }

    public class Animal
    {
    }
    public class Cat : Animal
    {
    }
    public class Dog : Animal
    {
    }





}
