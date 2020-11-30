using System;
using EventFeedFSM.States;

namespace EventFeedFSM
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetState(new NormalState(context));
        }
    }
}
