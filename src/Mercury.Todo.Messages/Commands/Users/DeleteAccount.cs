namespace Mercury.Todo.Messages.Commands.Users
{
    public class DeleteAccount : AuthenticatedCommand
    {
        public bool Soft { get; set; }
    }
}