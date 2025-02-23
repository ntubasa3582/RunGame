using UnityEngine;
/// <summary>
/// Playerの攻撃を管理するクラス
/// </summary>
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _arrowPrefab;
    float _elapsedTime;
    
    void Update()
    {
        ArrowInstance();
    }

    /// <summary>
    /// 一定時間おきにArrowを生成する処理が書いてあるメソッド
    /// </summary>
    void ArrowInstance()
    {
        //_elapsedTimeの値がAttackIntervalより大きくなったらArrowを生成して_elapsedTimeの値を０にする
        _elapsedTime += Time.deltaTime;
        if (PlayerStatus.Instance.AttackInterval < _elapsedTime)
        {
            if (PlayerStatus.Instance.ArrowAmount % 2 != 0)
            {
                Instantiate(_arrowPrefab, transform.position, Quaternion.identity);
                for (int i = 1; i <= PlayerStatus.Instance.ArrowAmount / 2; i++)
                {
                    Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0, i * 1f, 0));
                    Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0, (i * 1f) * -1, 0));
                }
            }
            else
            {
                Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0,0.5f, 0));
                Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0,0.5f, 0));
                for (int i = 0; i < PlayerStatus.Instance.ArrowAmount / 2; i++)
                {
                    Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0, i * 0.7f+0.5f, 0));
                    Instantiate(_arrowPrefab, transform.position, Quaternion.Euler(0, (i * 0.7f) * -1 +0.5f, 0));
                }   
            }
            
            _elapsedTime = 0;
        }
    }
}
