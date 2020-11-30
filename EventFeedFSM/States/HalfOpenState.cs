using System;
using System.Collections.Generic;
using System.Text;

namespace EventFeedFSM.States
{
    public class HalfOpenState : IState
    {
        private readonly Context _context;

        public HalfOpenState(Context context)
        {
            _context = context;
        }

        public void ExceptionOccurs()
        {
            _context.SetState(_context.GetHalfOpenExceptionOccurredState());
        }

        public void SuccessfulDispatch()
        {
            _context.SetState(_context.GetNormalState());
        }

        public void ExceptionOccursBeyondThreshold()
        {
            throw new InvalidStateTransitionException();
        }

        public void InactivityTimeOutExpires()
        {
            _context.SetState(_context.GetNormalState());
        }

        public void ExceptionOccursWithinThreshold()
        {
            throw new InvalidStateTransitionException();
        }

        public void ExceptionOccursBeyondThresholdWithIgnoredEvents()
        {
            throw new InvalidStateTransitionException();
        }

    }
}
