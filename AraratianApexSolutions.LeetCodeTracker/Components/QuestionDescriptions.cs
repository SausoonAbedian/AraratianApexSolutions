namespace AraratianApexSolutions.LeetCodeTracker.Components;

using AraratianApexSolutions.LeetCodeTracker.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

public partial class QuestionDescriptions
{
    [Parameter]
    public int Id { get; set; }

    protected override void OnInitialized()
    {
        
    }
}
