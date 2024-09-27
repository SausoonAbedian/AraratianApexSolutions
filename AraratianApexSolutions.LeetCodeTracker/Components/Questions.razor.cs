namespace AraratianApexSolutions.LeetCodeTracker.Components;

using AraratianApexSolutions.LeetCodeTracker.Models;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;

public partial class Questions
{
    private List<Question> _questions;
    private int _howMany = 25;
    private int _maxPageNumber;
    private int _pageNumber = 1;

    protected override void OnInitialized()
    {
        this._questions = DataAccessService.GetQuestions(this._pageNumber, this._howMany);
        this._maxPageNumber = DataAccessService.GetQuestionsPageCount(this._howMany);
    }

    private void QuestionsTableRowClick(int number)
    {
        Navigation.NavigateTo($"/QuestionDescriptions/{number}");
    }

    private void ListChange(string input)
    {
        try
        {
            int temp = 0;

            if (!int.TryParse(input, out temp))
            {
                return;
            }

            if (temp > this._maxPageNumber)
            {
                temp = this._maxPageNumber;
            }
            else if (temp < 1)
            {
                temp = 1;
            }

            this._pageNumber = temp;

            this._questions = DataAccessService.GetQuestions(this._pageNumber, this._howMany);
            StateHasChanged();
        }
        catch
        {
            return;
        }
    }

    private void SelectChange(string input)
    {
        try
        {
            int temp = 0;

            if (!int.TryParse(input, out temp))
            {
                return;
            }

            if (temp > 250)
            {
                temp = 250;
            }
            else if (temp < 1)
            {
                temp = 1;
            }

            this._howMany = temp;

            this._maxPageNumber = DataAccessService.GetQuestionsPageCount(this._howMany);

            if (this._pageNumber > this._maxPageNumber)
            {
                this._pageNumber = this._maxPageNumber;
            }

            this._questions = DataAccessService.GetQuestions(this._pageNumber, this._howMany);

            StateHasChanged();
        }
        catch
        {
            return;
        }
    }
}
