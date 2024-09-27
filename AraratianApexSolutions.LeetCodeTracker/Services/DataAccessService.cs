namespace AraratianApexSolutions.LeetCodeTracker.Services;

using System.Collections.Generic;
using System.Linq;
using AraratianApexSolutions.LeetCodeTracker.Models;

public class DataAccessService(LeetCodeTrackerDbContext context)
{
    public List<Question> GetQuestions(int pageNumber, int howMany)
    {
        return [.. context.Questions.OrderBy(a => a.Number).Skip((pageNumber - 1) * howMany).Take(howMany)];
    }

    public int GetQuestionsPageCount(int howMany)
    {
        int rowCount = context.Questions.Count();
        int pageCount = (rowCount / howMany) + 1;

        if (rowCount % howMany == 0)
        {
            pageCount--;
        }

        return pageCount;
    }

}
