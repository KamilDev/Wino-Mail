﻿namespace Wino.Core.Domain.Enums
{
    public enum SynchronizationType
    {
        // Shared
        UpdateProfile, // Only update profile information
        ExecuteRequests, // Run the queued requests, and then synchronize if needed.
        // Wino Mail
        FoldersOnly, // Only synchronize folder metadata.
        InboxOnly, // Only Inbox, Sent and Draft folders.
        CustomFolders, // Only sync folders that are specified in the options.
        FullFolders, // Synchronize all folders. This won't update profile or alias information.
        Alias, // Only update alias information
        // Calendar
        Events
    }
}
