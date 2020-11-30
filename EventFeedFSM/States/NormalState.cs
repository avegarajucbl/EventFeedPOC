using System;
using System.Collections.Generic;
using System.Text;

namespace EventFeedFSM.States
{
    public class NormalState : IState
    {
        private readonly Context _context;

        public NormalState(Context context)
        {
            _context = context;
        }

        public void ExceptionOccurs()
        {
            _context.SetState(_context.GetExceptionState());
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
            throw new InvalidStateTransitionException();
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
