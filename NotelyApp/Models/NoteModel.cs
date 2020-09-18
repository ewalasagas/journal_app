using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{
    public class NoteModel
    {
        public Guid Id { get; set; }

        public string Subject { get; set; }

        public string Detail { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModified { get; set; }

        public bool IsDeleted { get; set; }

    }
}
