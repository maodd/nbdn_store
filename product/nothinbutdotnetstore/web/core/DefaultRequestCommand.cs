using System;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultRequestCommand : RequestCommand
    {
        Predicate<Request> request_specification;
        ApplicationCommand application_command;

        public DefaultRequestCommand(Predicate<Request> request_specification, ApplicationCommand application_command)
        {
            this.request_specification = request_specification;
            this.application_command = application_command;
        }

        public void process(Request request)
        {
            application_command.process(request);
        }

        public bool can_handle(Request request)
        {
            return request_specification(request);
        }
    }
}