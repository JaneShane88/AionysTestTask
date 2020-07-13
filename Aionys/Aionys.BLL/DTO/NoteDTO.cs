using System;

namespace Aionys.BLL.DTO
{
    public class NoteDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as NoteDTO;

            if (item == null)
            {
                return false;
            }

            return Id == item.Id &&
                Text == item.Text &&
                Date == item.Date;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
