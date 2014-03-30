using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Entity
{
    public class EntityBase : IObjectState
    {
    
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}