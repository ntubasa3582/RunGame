using UnityEngine;

public class MoveSpeedUpWall : WallBase
{
    [SerializeField, Range(0, 100)] float _moveSpeedUpValue;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + _moveSpeedUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.XMoveValueChange(_moveSpeedUpValue);
    }
}
