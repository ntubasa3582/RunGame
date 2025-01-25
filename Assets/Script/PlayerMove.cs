using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = new Vector3(0, 0, _moveSpeed);
    }

    void Update()
    {
        HorizonMoveLimit();
        HorizonMove();
    }

    void HorizonMove()
    {
        _rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * 5, 0, _rb.velocity.z);
    }

    void HorizonMoveLimit()
    {
        var pos = transform.position;
        var posx = Mathf.Clamp(pos.x, -9.5f, 9.5f);
        transform.position = new Vector3(posx, transform.position.y, transform.position.z);
    }
}