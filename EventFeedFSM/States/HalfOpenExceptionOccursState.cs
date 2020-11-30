using System;

namespace EventFeedFSM.States
{
    public class HalfOpenExceptionOccursState : IState
    {
        private readonly Context _context;

        public HalfOpenExceptionOccursState(Context context)
        {
            _context = context;
        }

        public void ExceptionOccurs()
        {
            throw new InvalidStateTransitionException();
        }

        public void SuccessfulDispatch()
        {
            throw new InvalidStateTransitionException();
        }

        public void ExceptionOccursBeyondThreshold()
        {
            throw new InvalidStateTransitionException();
        }

        public void InactivityTimeOutExpires()
        {
            throw new InvalidStateTransitionException();
        }

        public void ExceptionOccursWithinThreshold()
        {
            _context.SetState(_context.GetHalfOpenExceptionOccurredState());
        }

        public void ExceptionOccursBeyondThresholdWithIgnoredEvents()
        {
            _context.SetState(_context.GetShutdownState());
        }

    }
}