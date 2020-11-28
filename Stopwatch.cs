using System;

namespace MyStopwatchTest
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _isRanning;

        public void Start()
        {
            if (_isRanning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _startTime = DateTime.Now;
            _isRanning = true;
 
        }

        public void Stop()
        {
            if(!_isRanning)
            {
                throw new InvalidOperationException("Stopwatch is not running!");
            }

            _endTime = DateTime.Now;
            _isRanning = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;     
        }
    }
}
