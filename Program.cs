using System;
using System.Device.Gpio;
using System.Threading;

int ledPin = 11; //GPIO24 is pin 18 on RPi
int ledOnTime = 1000; //led on time in ms
int ledOffTime = 500; //led off time in ms

using GpioController controller = new(PinNumberingScheme.Board);
controller.OpenPin(ledPin, PinMode.Output);

Console.WriteLine("LED Demo started");

while (!Console.KeyAvailable)
{
    controller.Write(ledPin, PinValue.High);
    Thread.Sleep(ledOnTime);    

    controller.Write(ledPin, PinValue.Low);
    Thread.Sleep(ledOffTime);

    Console.Write(".");
}

Console.WriteLine("LED Demo Ended");