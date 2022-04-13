using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private int score;

    private void OnLevelWasLoaded()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (Time.timeSinceLevelLoad + (score++) / 15).ToString("F0");
    }
}
