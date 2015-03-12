﻿using System.Collections.Generic;
using Models;
using NHibernate;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ISession session) : base(session)
        {
        }
    }

    public class LevelRepository : GenericRepository<Level>
    {
        public LevelRepository(ISession session) : base(session)
        {
        }
    }

    public class BlockRepository : GenericRepository<Block>
    {
        public BlockRepository(ISession session) : base(session)
        {
        }
    }

    public class PassRepository : GenericRepository<Pass>
    {
        public PassRepository(ISession session) : base(session)
        {
        }
    }
}
