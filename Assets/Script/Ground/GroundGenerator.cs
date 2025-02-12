using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    [SerializeField] GameObject _groundPrefab;
    [SerializeField] GameObject _goalPrefab;
    [SerializeField] int _instanceIndex;
    
    void Start()
    {
        for (int i =0; i < _instanceIndex; i++)
        {
            var posz = (i + 1)  * 80;
            if (i == -1 +  _instanceIndex)
            {
                Instantiate(_goalPrefab, new Vector3(0, 0, posz), Quaternion.identity);
            }
            else
            {
                Instantiate(_groundPrefab, new Vector3(0, 0, posz), Quaternion.identity);   
            }
        }
    }
}
