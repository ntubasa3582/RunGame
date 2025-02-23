using UnityEngine;

public class ArrowSpeedUpWall : WallBase
{
    [SerializeField, Range(0, 100)] float _arrowSpeedUpValue;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + "\n+" + _arrowSpeedUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.ArrowSpeedChange(_arrowSpeedUpValue);
    }
}
