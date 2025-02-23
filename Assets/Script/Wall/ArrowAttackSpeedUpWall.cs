using UnityEngine;

public class ArrowAttackSpeedUpWall : WallBase
{
    [SerializeField, Range(0, 100)] float _attackSpeedUpValue;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + "\n -" + _attackSpeedUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.AttackIntervalValueChange( - _attackSpeedUpValue);
    }
}
