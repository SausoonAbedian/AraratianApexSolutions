namespace AraratianApexSolutions.LeetCodeTracker.Models;

using System.Collections.Generic;
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

    public List<QuestionDescription> Description { get; set; }
}
