using UnityEngine;
/// <summary>
/// 壁の生成を管理するクラス
/// </summary>
public class WallSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] _WallPrefabs;
    int _objIndex = 100;
    void Start()
    {
        ObjectInstance(new Vector3(transform.position.x -5f, 2.4f, transform.position.z - 50));
        ObjectInstance(new Vector3(transform.position.x +5f,2.4f,transform.position.z -50));
    }
    
    /// <summary>
    /// 壁を生成する処理が書いてあるメソッド
    /// </summary>
    void ObjectInstance(Vector3 pos)
    {
        int index = default;
        index = RandomNum(0, 5);
        if (_objIndex != index)
        {
            _objIndex = index;
        }
        Instantiate(_WallPrefabs[0], pos, _WallPrefabs[0].transform.rotation);
    }


    /// <summary>
    /// 指定した数のランダムな値を返す
    /// </summary>
    /// <param name="min">ランダムの最小値</param>
    /// <param name="max">ランダムの最大値</param>
    /// <returns></returns>
    int RandomNum(int min, int max)
    {
        return Random.Range(min, max);
    }
}
