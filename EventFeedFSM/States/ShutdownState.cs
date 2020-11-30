using System;
using System.Collections.Generic;
using System.Text;

namespace EventFeedFSM.States
{
    public class ShutdownState: IState
    {
        private readonly Context _context;

        public ShutdownState(Context context)
        {
            _context = context;
        }
        public void ExceptionOccurs()
        {
            throw new NotImplementedException();
        }

        public void SuccessfulDispatch()
        {
            throw new NotImplementedException();
        }

        public void ExceptionOccursBeyondThreshold()
        {
            throw new NotImplementedException();
        }

        public void InactivityTimeOutExpires()
        {
            throw new NotImplementedException();
        }

        public void ExceptionOccursWithinThreshold()
        {
            throw new NotImplementedException();
        }

        public void ExceptionOccursBeyondThresholdWithIgnoredEvents()
        {
            throw new NotImplementedException();
        }
    }
}
