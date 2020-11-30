using System.Collections.Generic;
using System.Text;
using EventFeedFSM.States;

namespace EventFeedFSM
{
    public class Context
    {
        private IState _normalState;
        private IState _exceptionOccursState;
        private IState _halfOpenState;
        private IState _halfOpenExceptionOccursState;
        private IState _currentState = null;
        private IState _shutdownState;

        public Context()
        {
            _normalState = new NormalState(this);
            _exceptionOccursState = new ExceptionOccursState(this);
            _halfOpenState = new HalfOpenState(this);
            _halfOpenExceptionOccursState = new HalfOpenExceptionOccursState(this);
            _shutdownState = new ShutdownState(this);

            _currentState = _normalState;
        }

        //concrate actions
        public void ExceptionOccurs()
        {
            _currentState.ExceptionOccurs();
        }

        public void SuccessfulDispatch()
        {
            _currentState.SuccessfulDispatch();
        }

        public void ExceptionOccursBeyondThreshold()
        {
            _currentState.ExceptionOccursBeyondThreshold();
        }

        public void ExceptionOccursWithinThreshold()
        {
            _currentState.ExceptionOccursWithinThreshold();
        }

        public void ExceptionOccursBeyondThresholdWithIgnoredEvents()
        {
            _currentState.ExceptionOccursBeyondThresholdWithIgnoredEvents();
        }

        public void InactivityTimeOutExpires()
        {
            _currentState.InactivityTimeOutExpires();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public IState GetNormalState()
        {
            return _normalState;
        }

        public IState GetExceptionState()
        {
            return _exceptionOccursState;
        }

        public IState GetHalfOpenState()
        {
            return _halfOpenState;
        }

        public IState GetHalfOpenExceptionOccurredState()
        {
            return _halfOpenExceptionOccursState;
        }

        public IState GetShutdownState()
        {
            return _shutdownState;
        }
    }
}
