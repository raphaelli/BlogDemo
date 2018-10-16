using BlogDemo.Core.Interfac;

namespace BlogDemo.Core.Entities
{
    public abstract class Entity : IEntity
    {
        public int id { get; set; }
    }
}
