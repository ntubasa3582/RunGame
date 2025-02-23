using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDistanceWall : WallBase
{
    [SerializeField, Range(0, 100)] float _arrowDistanceValueUp;
    [SerializeField] string _textValue;

    protected override void TextChange()
    {
        _text.text = _textValue + "\n+"+ _arrowDistanceValueUp.ToString();
    }

    protected override void PlayerStatusChange()
    {
        PlayerStatus.Instance.ArrowDistanceChange(_arrowDistanceValueUp);
    }
}
