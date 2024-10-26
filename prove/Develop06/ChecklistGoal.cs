using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int totalPoints = _points;

            if (_amountCompleted == _target)
            {
                totalPoints += _bonus;
            }

            return totalPoints;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {(_amountCompleted >= _target ? "Complete" : "Incomplete")}";
    }

    public int GetAmountCompleted() => _amountCompleted;
    public int GetTarget() => _target;
    public int GetBonus() => _bonus;

    public void SetAmountCompleted(int amount) => _amountCompleted = amount;
}