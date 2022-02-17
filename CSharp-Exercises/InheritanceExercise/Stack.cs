namespace InheritanceExercise
{
    internal class Stack
    {
        private readonly List<object> _stackList;

        public Stack()
        {
            _stackList = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj != null)
            {
                _stackList.Add(obj);
            }
            else
                throw new InvalidOperationException();
        }
        public object Pop()
        {

            if (_stackList.Count != 0)
            {
                var lastElement = _stackList.Last();
                _stackList.Remove(lastElement);

                return lastElement;
            }
            else
                throw new InvalidOperationException();
        }
        public void Clear()
        {
            _stackList.Clear();
        }
    }
}
