﻿using System.Collections.Generic;

namespace Models
{
    public interface IUser
    {
        int Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string Surname { get; set; }
        ISchedule Schedule { get; set; } 
        IList<IBlock> EnroledBlocks { get; set; }
        IList<IPass> Passes { get; set; }  
    }

    public class User : IUser, IEntity
    {
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Surname { get; set; }
        public virtual ISchedule Schedule { get; set; }
        public virtual IList<IBlock> EnroledBlocks { get; set; }
        public virtual IList<IPass> Passes { get; set; }
        public virtual int Id { get; set; }
    }
}