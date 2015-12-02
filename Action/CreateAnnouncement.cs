﻿using Actions;
using Models;

namespace Action
{
    public class CreateAnnouncement : ICrudAction<Announcement>
    {
        public CreateAnnouncement(Announcement announcement)
        {
            ActionAgainst = announcement;
        }

        public Announcement ActionAgainst { get; set; }
        public int NumberOfUsersEmailed { get; set; }
    }
}
