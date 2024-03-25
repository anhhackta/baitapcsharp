using System;
class Animal
{
    public  void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public  void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Cat : Animal
{

    public void Bark()
    {
        Console.WriteLine("Cat is barking");
    }
}

class file2403
{
    static void Main(string[] args)
    {
        Animal animal = new Dog();
        
        
        // Downcasting
        if (animal is Dog)
        {
            Dog dog = (Dog)animal; // Thực hiện downcasting
            dog.Bark(); // Gọi phương thức của lớp dẫn xuất
        }
        else
        {
            Cat cat = (Cat)animal;
            cat.Bark();
        }
        Console.ReadKey();
    }
}
