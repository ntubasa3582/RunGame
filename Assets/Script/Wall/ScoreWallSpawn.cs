using UnityEngine;

public class ScoreWallSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] _scoreChangeWallPrefabs ;
    int _addNum;
    void Start()
    {
        if (RandomNum(0, 10) > 2)
        {
            RandomObjectNum();
        }
        
        
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

    
    /// <summary>
    /// ３つからランダムにオブジェクトを生成するメソッド
    /// </summary>
    void RandomObjectNum()
    {
        switch (RandomNum(0, 3))
        {
            case 0:
                RandomObjectInstance(-5,0);
                break;
            case 1:
                RandomObjectInstance(0,1);
                break;
            case 2:
                RandomObjectInstance(5,2);
                break;
        }
    }

    void RandomObjectInstance(int posX, int objIndex)
    {
        Instantiate(_scoreChangeWallPrefabs[objIndex], new Vector3(posX, 2, transform.position.z), Quaternion.identity);
    }
    
}
