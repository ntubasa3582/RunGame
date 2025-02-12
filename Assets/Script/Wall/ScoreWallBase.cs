using TMPro;
using UnityEngine;
public class ScoreWallBase : MonoBehaviour
{
    //Score変数の値を変更する時に使う数値を表示する変数
    public TextMeshProUGUI _fixScoreValueText;

    void Start()
    {
        TextValue();
    }

    protected int RandomValue(int min, int max)
    {
        return Random.Range(min, max);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CalculationScoreValue();
        }
    }

    /// <summary>
    /// Scoreの値を変更するメソッド
    /// </summary>
    protected virtual void CalculationScoreValue() { }

    
    /// <summary>
    /// TextMeshの文字を変更するメソッド
    /// </summary>
    protected virtual void TextValue() { }
}
