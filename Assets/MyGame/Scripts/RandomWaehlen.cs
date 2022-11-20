using UnityEngine;

public class RandomWaehlen : MonoBehaviour
{
    [SerializeField] private Color randomColor;
    [SerializeField] private GameObject transformen;

    private float randomNumber;
    
    void Start()
    {
        randomColor = new Color(Random.value, Random.value, Random.value);
        Debug.Log(randomColor);
        randomNumber = Random.value;
        Debug.Log(randomNumber);
        transformen.transform.rotation = Random.rotation;
        Debug.Log(transformen.transform.rotation);
    }
}
