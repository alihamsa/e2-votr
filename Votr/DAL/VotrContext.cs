﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Votr.Models;

namespace Votr.DAL
{
    public class VotrContext : ApplicationDbContext
    {
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<PollTag> PollTagRelations { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }
    }
}