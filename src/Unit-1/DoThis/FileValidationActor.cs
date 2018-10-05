using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace WinTail
{
    public class FileValidationActor : UntypedActor
    {
        private readonly IActorRef _consoleWriterActor;

        public FileValidationActor(IActorRef consoleWriterActor)
        {
            _consoleWriterActor = consoleWriterActor;
        }

        protected override void OnReceive(object message)
        {
            var msg = message as string;

            if (string.IsNullOrEmpty(msg))
            {
                _consoleWriterActor.Tell(new Messages.NullInputError("Input was blank. Please try again.\n"));
                Sender.Tell(new Messages.ContinueProcessing());
            }

            else if (IsFileUrl(msg))
            {
                _consoleWriterActor.Tell(new Messages.InputSuccess($"Starting processing for {msg}"));

                Context.ActorSelection("akka://MyActorSystem/user/tailCoordinatorActor")
                    .Tell(new TailCoordinatorActor.StartTail(msg, _consoleWriterActor));
            }

            else
            {
                _consoleWriterActor.Tell(new Messages.ValidationError("File does not exist"));
                Sender.Tell(new Messages.ContinueProcessing());
            }
        }

        private bool IsFileUrl(string path)
        {
            return File.Exists(path);
        }
    }
}
