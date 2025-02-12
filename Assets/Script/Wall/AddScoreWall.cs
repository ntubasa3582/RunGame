using UnityEngine;

public class AddScoreWall : ScoreWallBase
{
    [SerializeField, Range(1, 100)] int _addScoreMax;
    const int AddScoreMin = 1;
    
    int _addScoreValue;

    protected override void TextValue()
    {
        _addScoreValue = RandomValue(AddScoreMin,_addScoreMax);
        _fixScoreValueText.text ="+" +  _addScoreValue.ToString();
    }

    protected override void CalculationScoreValue()
    {
        ScoreManager.Instance.ChangeScore(ScoreManager.Instance.Score + _addScoreValue);
    }
}
