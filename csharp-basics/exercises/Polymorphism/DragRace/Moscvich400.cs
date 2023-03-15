using System;

namespace DragRace
{
    public class Moscvich400: ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 2;
        }

        public void SlowDown()
        {
            currentSpeed -= 2;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine(" -- brap brap ---");
        }
    }
}