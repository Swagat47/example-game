using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    int scr = 0;
    public Text ScoreText;
    public float multiplier;

    private void Start()
    {
        ScoreText.text = scr.ToString("0");
    }

    void Update()
    {
        ScoreText.text = (Time.time * multiplier).ToString("0");
    }

}