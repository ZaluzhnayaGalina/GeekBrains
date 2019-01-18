using System.Collections.Generic;

namespace Lesson7
{
    public delegate void Update();
    public delegate void Finish(int count);
    public class GameDoubler
    {
        private int _finish;
        private int _current;
        private int _count;        
        public event Update DataUpdated;
        public event Finish GameWon;

        public int Finish => _finish;

        public int Current
        {
            get { return _current; }
        }

        public int Count => _count;


        Stack<int> stack = new Stack<int>();


        public GameDoubler(int finish)
        {
            this._finish = finish;
            _current = 1;
            _count = 0;
            DataUpdated?.Invoke();
            //minCount=?
        }

        public void Plus()
        {
            stack.Push(_current);
            _current++;
            NewAttempt();
        }

        private void NewAttempt()
        {
            _count++;
            CheckGameWon();
            DataUpdated?.Invoke();
        }

        public void Multi()
        {
            stack.Push(_current);
            _current *= 2;
            NewAttempt();
        }

        public void Reset()
        {
            stack.Clear();
            _current = 1;
            _count = 0;
            DataUpdated?.Invoke();
        }

        public void Undo()
        {
            if (stack.Count > 0)
            {
                _current = stack.Pop();
                _count--;
            }
            DataUpdated?.Invoke();
        }
        public void CheckGameWon()
        {
            if (_current == _finish)
                GameWon?.Invoke(_count);
        }
    }
}
