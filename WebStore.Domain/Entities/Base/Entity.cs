using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }

    public abstract class NamedEntity : Entity, INamedEntity
    {
        public string Name { get; set; }
    }
}
