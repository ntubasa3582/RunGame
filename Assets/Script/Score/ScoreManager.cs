using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager _instance;
    public static ScoreManager Instance => _instance;
    ScoreManager _scoreManager;
    int _score;
    public int Score => _score;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = GetComponent<ScoreManager>();
            _instance = this;
        }

        _scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }
    
    /// <summary>
    /// Scoreの値を変更するメソッド
    /// </summary>
    /// <param name="value">変更後の値をもらう変数</param>
    public void ChangeScore(int value)
    {
        _score = value;
    }
}
