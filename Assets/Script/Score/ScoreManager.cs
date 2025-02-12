using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    static ScoreManager _instance;
    public static ScoreManager Instance => _instance;
    ScoreManager _scoreManager;
    int _score = 0;
    public int Score => _score;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = GetComponent<ScoreManager>();
            _instance = this;
        }

        _scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        ChangeScore(0);
    }
    
    /// <summary>
    /// Scoreの値を変更するメソッド
    /// </summary>
    /// <param name="value">変更後の値をもらう変数</param>
    public void ChangeScore(int value)
    {
        _score = value;
        _scoreText.text = _score.ToString();
    }
}
