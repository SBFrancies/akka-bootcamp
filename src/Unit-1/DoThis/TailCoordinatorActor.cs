using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace WinTail
{
    public class TailCoordinatorActor : UntypedActor
    {
        public class StartTail
        {
            public StartTail(string filePath, IActorRef reporterActor)
            {
                FilePath = filePath;
                ReporterActor = reporterActor;
            }

            public string FilePath { get; }
            public IActorRef ReporterActor { get; }
        }

        public class StopTail
        {
            public StopTail(string filePath)
            {
                FilePath = filePath;
            }

            public string FilePath { get; }
        }

        protected override void OnReceive(object message)
        {
            switch (message)
            {
                    case StartTail start:
                        Context.ActorOf(Props.Create<TailActor>(start.FilePath, start.ReporterActor));

                        break;
            }
        }

        protected override SupervisorStrategy SupervisorStrategy()
        {
            return new OneForOneStrategy(10, TimeSpan.FromSeconds(30), x =>
            {
                switch (x)
                {
                    case ArithmeticException _:
                        return Directive.Resume;
                    case NotSupportedException _:
                        return Directive.Stop;
                    default:
                        return Directive.Restart;
                }
            });
        }
    }
}
