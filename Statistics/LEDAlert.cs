namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows;
        public void TakeAction(bool actionStatus)
        {
            ledGlows = actionStatus;
        }
    }
}
