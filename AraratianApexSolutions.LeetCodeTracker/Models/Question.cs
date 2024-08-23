namespace AraratianApexSolutions.LeetCodeTracker.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Question
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Number { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public QuestionDifficultyEnum Difficulty { get; set; }
}
