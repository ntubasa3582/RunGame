using Unity.VisualScripting;
using UnityEngine;

public class ScoreWallSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] _scoreChangeWallPrefabs;
    [SerializeField] float _wallWidth;
    int _addNum;
    void Start()
    {
        RandomObjectInstance();   
    }
    
    /// <summary>
    /// 指定した数のランダムな値を返す
    /// </summary>
    /// <param name="min">ランダムの最小値</param>
    /// <param name="max">ランダムの最大値</param>
    /// <returns></returns>
    int RandomNum(int min,int max)
    {
        return Random.Range(min, max);
    }
    
    

    void RandomObjectInstance()
    {
        for (float i = -7; i <= 7; i+=7)
        {
            int value = default;
            switch (RandomNum(0, 10))
            {
                case <= 4:
                    value = 0;
                    break;
                case <= 8:
                    value = 1;
                    break;
                case <= 10:
                    value = 2;
                    break;
            }
            Instantiate(_scoreChangeWallPrefabs[value], new Vector3(i, 2, transform.position.z),
                Quaternion.identity);
        }
    }   
}
