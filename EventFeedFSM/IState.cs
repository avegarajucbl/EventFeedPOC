using System;

namespace EventFeedFSM
{
    public interface IState
    {
        void ExceptionOccurs();
        void SuccessfulDispatch();
        void ExceptionOccursBeyondThreshold();
        void InactivityTimeOutExpires();
        void ExceptionOccursWithinThreshold();
        void ExceptionOccursBeyondThresholdWithIgnoredEvents();
    }
}
