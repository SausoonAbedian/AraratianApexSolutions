namespace AraratianApexSolutions.LeetCodeTracker.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class QuestionDescription
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Difficulty { get; set; }

    public Question Question { get; set; }
}
