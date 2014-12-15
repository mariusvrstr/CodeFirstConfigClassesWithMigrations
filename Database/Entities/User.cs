
namespace Database.Entities
{
    using System;

    public class User
    {
        public User()
        {
        }

        public User(Guid id, string name, DateTime birthDay, Guid familyId)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDay = birthDay;
            this.FamilyId = familyId;

        }

        public User(string name, DateTime birthDay, Guid familyId)
            : this(Guid.NewGuid(), name, birthDay, familyId)
        {
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDay { get; private set; }
        public Guid? FamilyId { get; private set; } // Foreign Key
        public virtual Family Family { get; set; } // Nav Property

        public override string ToString()
        {
            return string.Format("ID: [{0}],  Name: [{1}], FamilyId: [{2}] Birthday: [{3}]", this.Id, this.Name,
                this.FamilyId, this.BirthDay.ToShortDateString());
        }
    }
}
