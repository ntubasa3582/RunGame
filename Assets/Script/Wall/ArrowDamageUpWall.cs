using UnityEngine;

public class ArrowDamageUpWall : WallBase
{
    [SerializeField, Range(0, 100)] int _arrowDamageUpValue;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + "\n-" + _arrowDamageUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.ArrowDamageChange(_arrowDamageUpValue);
    }
}
