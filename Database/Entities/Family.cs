
namespace Database.Entities
{
    using System;

    public class Family
    {
        public Family()
        {
        }

        public Family(string familyName, string origin)
            : this(Guid.NewGuid(), familyName, origin)
        {
        }

        public Family(Guid id, string surname, string origin)
        {
            this.Id = id;
            this.Surname = surname;
            this.Origin = origin;
        }

        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Origin { get; set; }

        public override string ToString()
        {
            return string.Format("Surname: [{0}], Origin:[{1}]", this.Surname, this.Origin);
        }
    }
}
