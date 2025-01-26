using UnityEngine;
/// <summary>
/// このクラスを継承して足す、引く、かけるクラスを作る
/// </summary>
public class ScoreWallBase : MonoBehaviour
{
    [SerializeField] TextMesh _fixScoreValueText;

    int RandomValue(int min, int max)
    {
        return RandomValue(min, max);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CalculationScoreValue();
        }
    }
    
    /// <summary>
    /// Scoreの値を変更し
    /// </summary>
    public void CalculationScoreValue()
    {
        
    }
}
