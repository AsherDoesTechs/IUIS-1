using System;

namespace IUIS.Services
{
    public sealed class RepositoryChangedEventArgs : EventArgs
    {
        public RepositoryChangedEventArgs(string module, string action, string recordId)
        {
            Module = module;
            Action = action;
            RecordId = recordId;
        }

        public string Module { get; }
        public string Action { get; }
        public string RecordId { get; }
    }

    public static class RepositoryEvents
    {
        public static event EventHandler<RepositoryChangedEventArgs>? Changed;

        public static void Publish(string module, string action, string recordId) =>
            Changed?.Invoke(null, new RepositoryChangedEventArgs(module, action, recordId));
    }
}
