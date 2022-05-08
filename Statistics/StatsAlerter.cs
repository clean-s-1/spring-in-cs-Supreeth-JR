using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsAlerter
    {
        private readonly float _maxThreshold;
        private readonly IAlerter[] _alerts;

        public StatsAlerter(float maxThreshold, IAlerter[] alerts)
        {
            _maxThreshold = maxThreshold;
            _alerts = alerts;
        }

        public void checkAndAlert(List<float> lstStatus)
        {
            var lstMaxStatus = lstStatus.Where(x => x >= _maxThreshold);
            if (lstMaxStatus?.Count() > 0)
            {
                foreach (IAlerter alerter in _alerts)
                {
                   alerter.TakeAction(true);
                }
            }
        }
    }
}
