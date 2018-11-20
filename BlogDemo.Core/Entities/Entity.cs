using BlogDemo.Core.interfaces;

namespace BlogDemo.Core.Entities
{
    public abstract class Entity : IEntity
    {
        public int id { get; set; }
    }
}