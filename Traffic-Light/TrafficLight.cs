using System;
namespace Traffic_Light
{
    public enum TrafficLightColor
    {
        None,
        Red,
        Yellow,
        Green
    }
    public class TrafficLight
    {
        // Auto-implemented property
        public TrafficLightColor CurrentColor { get; set; }
        // Random number generator
        private Random random;


        // Default Constructor
        public TrafficLight()
        {
            //TODO: Set the Auto-implemented property CurrentColor to None
            CurrentColor = TrafficLightColor.None;
            random = new Random();
        }

        // Initial Value Constructor
        public TrafficLight(TrafficLightColor lightColor)
        {
            //TODO: Set the Auto-implemented property CurrentColor to this function's parameter
            CurrentColor = lightColor;
            random = new Random();
        }

        // A method to change the light to a random value
        public void change()
        {
            //TODO: Set the Auto-implemented property CurrentColor to
            // a random color, either Red, Yellow, or Green
            // None should not be included

            Array colors = Enum.GetValues(typeof(TrafficLightColor));

            CurrentColor = (TrafficLightColor)colors.GetValue(random.Next(1, colors.Length));
        }

        public override string ToString()
        {
            //TODO: Return the correct string based on the value of
            // the Auto-implemented property CurrentColor
            switch (CurrentColor)
            {
                case TrafficLightColor.Red:
                    return "The Light is Red!";
                case TrafficLightColor.Yellow:
                    return "The Light is Yellow!";
                case TrafficLightColor.Green:
                    return "The Light is Green!";
                default:
                    return "The Light is Out of Order";
            }
        }
    }
}
