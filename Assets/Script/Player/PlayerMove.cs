using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 7f;
    Rigidbody _rb;
    float _laneIndex;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = new Vector3(0, 0, _moveSpeed);
    }

    void Update()
    {
        PositionChange();
    }

    
    /// <summary>
    /// 他のレーンに移動する処理が書かれてるメソッド
    /// </summary>
    void PositionChange()
    {
        _laneIndex = Mathf.Clamp(_laneIndex, -1, 1);
        if (Input.GetKeyDown(KeyCode.A))
        {
            _laneIndex -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _laneIndex += 1;
        }

        switch (_laneIndex)
        {
            case -1:
                transform.position = new Vector3(-7, transform.position.y, transform.position.z);
                break;
            case 0:
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                break;
            case 1:
                transform.position = new Vector3(7, transform.position.y, transform.position.z);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GoalGround"))
        {
            _rb.velocity = new Vector3(0, 0, 0);
        }
    }
}