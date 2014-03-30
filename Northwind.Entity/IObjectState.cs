using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Entity
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }

    public enum ObjectState
    {
        Unchanged,
        Added,
        Modified,
        Deleted
    }
}