using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    public class EntityBase : IObjectState
    {
    
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}