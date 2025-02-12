using UnityEngine;

public class MultiplicationScoreWall : ScoreWallBase
{
    [SerializeField, Range(1, 100)] int _multiplicationScoreMax;
    const int MultiplicationScoreMin = 1;

    int _multiplicationScoreValue;

    protected override void TextValue()
    {
        _multiplicationScoreValue = RandomValue(MultiplicationScoreMin, _multiplicationScoreMax);
        _fixScoreValueText.text = "×" + _multiplicationScoreValue.ToString();
    }

    protected override void CalculationScoreValue()
    {
        ScoreManager.Instance.ChangeScore(ScoreManager.Instance.Score * _multiplicationScoreValue);
    }
}
