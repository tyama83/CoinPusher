using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int initScore;
    int currentScore;
    Text scoreText;

    void Start()
    {
        currentScore = initScore;
        scoreText = this.GetComponent<Text>();
        printScore(initScore);
    }

    public void addScore(int n)
    {
        currentScore += n;
        printScore(currentScore);
    }

    void printScore(int n)
    {
        scoreText.text = n.ToString();
    }
}
