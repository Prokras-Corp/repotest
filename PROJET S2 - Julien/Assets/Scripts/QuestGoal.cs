using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal
{
    public GoalType type;
    public int requiredAmount;
    public int currentAmount;

    public bool isReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void EnemyKilled()
    {
        if (type == GoalType.Kill)
        {
            currentAmount += 1;
        }
    }

    public void ItemCollected()
    {
        if (type == GoalType.Gathering)
        {
            currentAmount += 1;
        }
    }
    
}

public enum GoalType
{
    Kill,
    Gathering
}

