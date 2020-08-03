using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text ScoreText;
    public float multiplier;
    

    void Update()
    {
        ScoreText.text = (Time.time * multiplier).ToString("0");
    }
}
