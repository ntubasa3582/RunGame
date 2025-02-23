using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9, 9f);
        transform.position = pos;
    }
}
