using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfCoreIssue
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
