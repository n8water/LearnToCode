using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    //global variables
    private readonly List<int> _scores;
   

    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores()
    {
        CheckIfListContainsItems(_scores);

        return _scores;
    }

    public int Latest()
    {
        CheckIfListContainsItems(_scores);

        return _scores.Last();
    }

    public int PersonalBest()
    {
        CheckIfListContainsItems(_scores);

        return _scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        CheckIfListContainsItems(_scores);

        var temp = _scores.OrderByDescending(num => num);

        return _scores.Count<4?temp.ToList():temp.Take(3).ToList();
    }

    private void CheckIfListContainsItems(List<int> scores)
    {
        if (_scores.Count < 0)
            throw new NullReferenceException();
    }

}