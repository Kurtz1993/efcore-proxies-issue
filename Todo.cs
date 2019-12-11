using System;
using System.ComponentModel.DataAnnotations;

namespace EfCoreIssue
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public bool Done { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}