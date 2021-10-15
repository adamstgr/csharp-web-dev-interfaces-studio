using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public string SceneSelector { get; set; }

        public DVD(string sceneSelector, int storageCapacity, string label) : base(storageCapacity, label)
        {
            SceneSelector = sceneSelector;
        }
        public void SpinDisc()
        {
            Console.WriteLine("Gee whiz! DVDs spin at 700 RPMs!");
        }
        public void WriteDisc()
        {
            Console.WriteLine("You can certainly write to this bad boy!");
        }
        public void ReadDisc()
        {
            Console.WriteLine("When you read this, you're probably watching a movie, baby!");
        }
        public void ReflectLight()
        {
            Console.WriteLine("I look pretty in the sunshine?");
        }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
