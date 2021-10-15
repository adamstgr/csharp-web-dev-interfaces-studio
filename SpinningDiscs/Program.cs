using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD PrincessBride = new DVD("pick some scenes", 300, "The Princess Bride");
            CD RageAgainstTheMachine = new CD("there are 18 tracks", 32, "Rage Against The Machine");

            RageAgainstTheMachine.ReflectLight();
            RageAgainstTheMachine.SpinDisc();

            PrincessBride.ReadDisc();
            PrincessBride.GiveManufacturer("Hallmark");
            // TODO: Declare and initialize a CD and a DVD object.

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
