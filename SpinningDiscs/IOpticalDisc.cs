using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        public const bool Reflective = true;
        void SpinDisc();
        void WriteDisc();
        void ReadDisc();
        void ReflectLight();

    }
}
