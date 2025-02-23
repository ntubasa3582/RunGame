using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAmountUpWall : WallBase
{
    [SerializeField, Range(0, 100)] int _arrowAmountUpValue;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + "\n+" + _arrowAmountUpValue.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.ArrowAmountChange(_arrowAmountUpValue);
    }
}
