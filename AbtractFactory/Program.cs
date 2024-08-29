namespace AbtractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IDog dog;
            ITiger tiger;
            IAnimalFactory animalFactory;

            animalFactory = new PetAnimalFactory();
            dog = animalFactory.GetDog();
            dog.Action();
            dog.Speak();
            tiger = animalFactory.GetTiger();
            tiger.Action();
            tiger.Speak();

            animalFactory = new WildAnimalFactory();
            dog = animalFactory.GetDog();
            dog.Action();
            dog.Speak();
            tiger = animalFactory.GetTiger();
            tiger.Action();
            tiger.Speak();

        }
    }
}
