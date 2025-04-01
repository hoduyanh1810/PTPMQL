using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Person")]

    public class Person
{
    [Key]
    public required string PersonID { get; set;}

    public required string FullName { get; set; }  
    public required string Address { get; set; }
}

}