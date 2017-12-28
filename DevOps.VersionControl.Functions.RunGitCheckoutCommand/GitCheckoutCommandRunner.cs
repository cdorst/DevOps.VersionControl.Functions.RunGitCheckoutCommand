using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitCheckoutCommand
{
    public static class GitCheckoutCommandRunner
    {
        private const string checkout = nameof(checkout);

        public static void Checkout(string directory, params string[] arguments)
            => Git(directory,
                command: checkout,
                arguments);
    }
}
