using UnityEngine;
/// <summary>
/// Playerの移動を管理するクラス
/// </summary>
public class PlayerMove : MonoBehaviour
{
    Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HorizontalMove();
        MoveLimit();
    }
    
    /// <summary>
    /// Playerの移動を管理するメソッド
    /// </summary>
    void HorizontalMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector3(x * PlayerStatus.Instance.XMoveSpeed, 0, PlayerStatus.Instance.ZMoveSpeed);
        // transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * PlayerStatus.Instance.XMoveSpeed, 0) * Time.deltaTime);
    }

    
    /// <summary>
    /// x座標の移動制限を管理するメソッド
    /// </summary>
    void MoveLimit()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9, 9f);
        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {
        //特定の位置に来たら移動を止める
        if (other.gameObject.CompareTag("GoalGround"))
        {
        }
    }
}