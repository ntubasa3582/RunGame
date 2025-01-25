using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField] GameObject _groundPrefab;
    [SerializeField] float _instanceIndex;
    
    void Awake()
    {
        for (int i =0; i < _instanceIndex; i++)
        {
            var posz = (i + 1)  * 40; 
            Instantiate(_groundPrefab, new Vector3(0,0,posz), Quaternion.identity);
        }
    }
}
