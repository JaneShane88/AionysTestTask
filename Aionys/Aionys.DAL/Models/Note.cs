using System;
using System.Collections.Generic;
using System.Text;

namespace Aionys.DAL.Models
{
    public class Note
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Note other)
        {
            return other != null && Id == other.Id &&
                Text == other.Text &&
                Date == other.Date;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Text, Date);
        }
    }
}
