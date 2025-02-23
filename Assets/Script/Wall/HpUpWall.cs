using UnityEngine;

public class HpUpWall : WallBase
{
    [SerializeField, Range(0, 100)] int _hpUpValue;
    [SerializeField] string _textValue;
    int _addScoreValue;

    protected override void TextChange()
    {
        _text.text += _textValue + _hpUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        
    }
}
