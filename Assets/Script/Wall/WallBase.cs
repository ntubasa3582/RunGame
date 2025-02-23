using TMPro;
using UnityEngine;
/// <summary>
///　Playerのステータスを変更する壁の元となるクラス
/// </summary>
public class WallBase : MonoBehaviour
{
    //Score変数の値を変更する時に使う数値を表示する変数
    protected TextMeshProUGUI _text;

    void Start()
    {
        TextChange();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerStatusChange();
            Destroy(gameObject);
        }
    }
    
    /// <summary>
    /// Playerのなにかしらの値を変更するメソッド
    /// </summary>
    protected virtual void PlayerStatusChange(){ }

    
    /// <summary>
    /// TextMeshの文字を変更するメソッド
    /// </summary>
    protected virtual void TextChange() { }
}
