namespace ClassesExerciseOne
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;
        public TimeSpan Duration => GetDuration();

        private TimeSpan GetDuration()
        {
            return _endTime - _startTime;
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
            }
            else
                throw new InvalidOperationException();
        }

        public void End()
        {
            if (_isRunning)
                _endTime = DateTime.Now;
            _isRunning = false;
        }
    }
}
