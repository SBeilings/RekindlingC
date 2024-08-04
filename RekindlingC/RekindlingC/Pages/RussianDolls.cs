using System;
namespace RekindlingC.Pages
{
  public class RussianDolls
    {
        public void RunMePlease() {

            FirstRussianDoll firstRussianDoll = new FirstRussianDoll();
            firstRussianDoll.callNext();
        }
    }
     class FirstRussianDoll
    {

        public void callNext()
        {

            SecondRussianDOll secondRussianDOll = new SecondRussianDOll();
            secondRussianDOll.RunMe();
        }
    }

}

 class SecondRussianDOll
{

    public void RunMe()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Hello World! \nIs anyone there or did I hear enough?");
            string answer = Console.ReadLine();
            string name;

            if (answer == "y" || answer == "yes")
            {
                Console.Write("Nice to have you with us, what is your name?");
                name = Console.ReadLine();
                Console.WriteLine(name + " is a lovely name, my Creator's name is Shamiel" +
                    "\n Well I have got to get going now, See ya!");
            }
            else if (answer == "enough" || answer == "Enough")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Humans would have answered with a y or a yes!\n So sad to be all alone ");
            }
        }
        
    }
}

