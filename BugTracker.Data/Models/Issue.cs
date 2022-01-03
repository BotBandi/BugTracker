using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Data.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }
        public string Description { get; set; } = String.Empty;
        public Priority Priority { get; set; } = Priority.Normal;
        public State State { get; set; } = State.New;
        public Type Type { get; set; }
        //public Product Product { get; set; }
        //public Customer Owner { get; set; }
        public User Assignee { get; set; }
        //public List<IssueEvent> Events { get; set; }
    }
}
