using System;

namespace EventFeedFSM.States
{
    public class ExceptionOccursState : IState
    {
        private readonly Context _context;

        public ExceptionOccursState(Context context)
        {
            _context = context;
        }

        public void ExceptionOccurs()
        {
            throw new InvalidStateTransitionException();
        }

        public void SuccessfulDispatch()
        {
            _context.SetState(_context.GetNormalState());
        }

        public void ExceptionOccursBeyondThreshold()
        {
            _context.SetState(_context.GetHalfOpenState());
        }

        public void InactivityTimeOutExpires()
        {
            throw new InvalidStateTransitionException();
        }

        public void ExceptionOccursWithinThreshold()
        {
            _context.SetState(_context.GetExceptionState());
        }

        public void ExceptionOccursBeyondThresholdWithIgnoredEvents()
        {
            throw new InvalidStateTransitionException();
        }
    }
}