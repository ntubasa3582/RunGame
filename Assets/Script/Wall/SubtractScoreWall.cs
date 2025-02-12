using UnityEngine;

public class SubtractScoreWall : ScoreWallBase
{
    [SerializeField, Range(1, 100)] int _subtractScoreMax;
    const int SubtractScoreMin = 2;

    int _subtractScoreValue;

    protected override void TextValue()
    {
        _subtractScoreValue = RandomValue(SubtractScoreMin, _subtractScoreMax);
        _fixScoreValueText.text ="-" +  _subtractScoreValue.ToString();
    }

    protected override void CalculationScoreValue()
    {
        ScoreManager.Instance.ChangeScore(ScoreManager.Instance.Score - _subtractScoreValue);
    }   
}
