using UnityEngine;
/// <summary>
/// Playerのステータスを管理するクラス
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    static PlayerStatus _instance;
    public static PlayerStatus Instance => _instance;
    PlayerStatus _playerStatus;

    [SerializeField] int _hp;
    public int Hp => _hp;

    [SerializeField] float _xMoveSpeed;
    public float XMoveSpeed => _xMoveSpeed;

    [SerializeField] float _zMoveSpeed;
    public float ZMoveSpeed => _zMoveSpeed;

    [SerializeField] float _attackInterval;
    public float AttackInterval => _attackInterval;

    [SerializeField] float _arrowSpeed;
    public float ArrowSpeed => _arrowSpeed;

    [SerializeField] float _arrowDistance;
    public float ArrowDistance => _arrowDistance;

    [SerializeField] int _arrowAmount;
    public int ArrowAmount => _arrowAmount;

    [SerializeField] int _arrowDamage;
    public int ArrowDamage => _arrowDamage;
    

    void Awake()
    {
        if (_instance == null)
        {
            _instance = GetComponent<PlayerStatus>();
            _instance = this;
        }

        _playerStatus = GameObject.FindObjectOfType<PlayerStatus>();
    }

    void Update()
    {
        // Debug.Log(_hp);
    }

    /// <summary>
    /// Hp変数の値を変更するメソッド
    /// </summary>
    /// <param name="value">Hp変数の値を変えるために必要な値</param>
    public void HpValueChange(int value) { _hp += value; }
    
    public void XMoveValueChange(float value) { _xMoveSpeed += _xMoveSpeed; }
    
    public void ZMoveValueChange(float value) { _zMoveSpeed += _zMoveSpeed; }

    public void AttackIntervalValueChange(float value) { _attackInterval += _attackInterval; }

    public void ArrowSpeedChange(float value) { _xMoveSpeed += value; }

    public void ArrowDistanceChange(float value) { _arrowDistance += value; }

    public void ArrowAmountChange(int value) { _arrowAmount += value; }

    public void ArrowDamageChange(int value) { _arrowDamage += _arrowDamage; }
}
