using UnityEngine;
/// <summary>
/// Arrowの移動やライフタイムを管理するクラス
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class ArrowController : MonoBehaviour
{
    Rigidbody _rb;
    Vector3 _playerPos;
    Vector3 _direction;
    void Awake()
    {
        _playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        _rb = GetComponent<Rigidbody>();
        DirectionSetting();
        _rb.velocity = _direction * PlayerStatus.Instance.ArrowSpeed;
    }

    void Update()
    {
        DistanceCheck();
    }
    
    /// <summary>
    /// 自身とプレイヤーの距離がArrowDistance変数の値より大きくなったら自身を破棄する
    /// </summary>
    void DistanceCheck()
    {
        if (Vector3.Distance(_playerPos, transform.position) >= PlayerStatus.Instance.ArrowDistance)
        {
            Destroy(gameObject);
        }
    }

    void DirectionSetting()
    {
        _direction = transform.localEulerAngles;
        _direction = Quaternion.Euler(_direction) * Vector3.forward;
    }
}
