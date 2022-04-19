using System;
using Xunit;
using StcskAndQueue;
using StcskAndQueue.AnimalShelters;
namespace TestStacksandQueues
{
    public class AnimalShelterTest
    {
        [Fact]
        public void DogDequeueTest()
        {
            AnimalShelter animal = new AnimalShelter();
            Dog hasky = new Dog();
            Dog chewawa = new Dog();
            Cat soso = new Cat();
            Cat linlin = new Cat();
            animal.Enqueue(hasky);
            animal.Enqueue(chewawa);
            animal.Enqueue(soso);
            animal.Enqueue(linlin);
            //Assert.Equal(soso, animal.Dequeue("Cat"));
            Assert.True(animal.Dog.Dequeue() is Dog);
        }


        [Fact]
        public void CatDequeueTest()
        {
            AnimalShelter animal = new AnimalShelter();
            Dog hasky = new Dog();
            Dog chewawa = new Dog();
            Cat soso = new Cat();
            Cat linlin = new Cat();
            animal.Enqueue(hasky);
            animal.Enqueue(chewawa);
            animal.Enqueue(soso);
            animal.Enqueue(linlin);
            //Assert.Equal(soso, animal.Dequeue("Cat"));
            Assert.True(animal.Cat.Dequeue() is Cat);
        }

        [Fact]
        public void NullTest()
        {
            AnimalShelter animal = new AnimalShelter();
            Dog hasky = new Dog();
            animal.Enqueue(hasky);
            
            Assert.Null(animal.Dequeue("Cat"));
        }


    }
}
