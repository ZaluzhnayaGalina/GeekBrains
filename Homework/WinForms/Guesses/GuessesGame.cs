using System;

namespace Guesses
{
    public class GuessesGame
    {
        private int _answer;
        private int _higherBound;
        private int _maxAttemptsCount;
        private int _attemptsCount;
        public GuessesGame()
        {            
            _higherBound = 100;
            _answer = (new Random()).Next(100);
            _maxAttemptsCount = (int)Math.Round(Math.Log(_higherBound, 2));
        }
        public bool UserAnswerIsGreater(int answer)
        {
            return answer > _answer;
        }
        public bool UserAnswerIsLess(int answer)
        {
            return answer < _answer;
        }
        public bool Attempt(int answer)
        {
            _attemptsCount++;
            return answer == _answer;            
        }
        public bool CheckAttemptPosibility()
        {
            _attemptsCount++;
            return _attemptsCount <= _maxAttemptsCount;
        }
    }
}
