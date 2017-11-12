using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Companies.SAP_Bulgaria
{
    class Dog { }

    class AnimalShelter<TAnimal>
    {
        private const int DefaultPlacesNumber = 20;
        private TAnimal[] animalList;
        private int usedPlaces;

        //ctor
        //this type of inheritance works only
        //if there is another ctor that takes such param
        public AnimalShelter() : this(DefaultPlacesNumber)
        { }

        public AnimalShelter(int placesNumber)
        {
            this.animalList = new TAnimal[placesNumber];
            this.usedPlaces = 0;
        }

        public void Shelter (TAnimal newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is Full");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public TAnimal Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index " + index);
            }

            TAnimal releasedAnimal = this.animalList[index];

            for(int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }

            this.animalList[this.usedPlaces - 1] = default(TAnimal);
            this.usedPlaces--;

            return releasedAnimal;
        }

        public static void Init()
        {
            AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();

            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());

            Dog d = shelter.Release(1); //index 1
            d = shelter.Release(0);
            d = shelter.Release(0);
        }
    }
}
