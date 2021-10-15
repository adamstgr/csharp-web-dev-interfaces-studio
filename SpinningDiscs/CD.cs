using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public string TrackList { get; set; }
        public CD(string trackList, int storageCapacity, string label) : base(storageCapacity, label)
        {
            TrackList = trackList;
        }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public void ReadDisc()
        {
            Console.WriteLine("This thing reads supa fast!");
        }

        public void ReflectLight()
        {
            Console.WriteLine("Yep, super reflective!");
        }

        public void SpinDisc()
        {
            Console.WriteLine("Spin to win!");
        }

        public void WriteDisc()
        {
            Console.WriteLine("You can put up to ten Terabytes on this bad boy.");
        }
    }
}
