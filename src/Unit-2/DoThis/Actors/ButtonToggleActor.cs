using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akka.Actor;

namespace ChartApp.Actors
{
    public class ButtonToggleActor : UntypedActor
    {
        public class Toggle { }

        private readonly CounterType _myCounterType;
        private bool _isToggleOn;
        private readonly Button _myButton;
        private readonly IActorRef _coordinatorActor;

        public ButtonToggleActor(IActorRef coordinatorActor, Button myButton, CounterType myCounterType,
            bool isToogleOn = false)
        {
            _coordinatorActor = coordinatorActor;
            _myButton = myButton;
            _isToggleOn = isToogleOn;
            _myCounterType = myCounterType;
        }

        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Toggle _:
                    if (_isToggleOn)
                    {
                        _coordinatorActor.Tell(new PerformanceCounterCoordinatorActor.Unwatch(_myCounterType));
                    }

                    else
                    {
                        _coordinatorActor.Tell(new PerformanceCounterCoordinatorActor.Watch(_myCounterType));
                    }

                    FlipToggle();

                    break;
                default:
                    Unhandled(message);
                    break;
            }
        }

        private void FlipToggle()
        {
            _isToggleOn = !_isToggleOn;

            _myButton.Text = $"{_myCounterType.ToString().ToUpperInvariant()} ({(_isToggleOn ? "ON" : "OFF")})";
        }
    }
}
