namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;
        public void TakeAction(bool actionStatus)
        {
            emailSent = actionStatus;
        }
    }
}
