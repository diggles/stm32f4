using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;
using Microsoft.SPOT.Hardware.STM32F4;

namespace STM32F4
{
    public class Program
    {
        public static void Main()
        {
            OutputPort led = new OutputPort(Pins.GPIO_PIN_D_14, false); //PA1 on discovery board

            while (true)
            {
                led.Write(true);
                Thread.Sleep(500);
                led.Write(false);
                Thread.Sleep(500);
            }
        }

    }
}
