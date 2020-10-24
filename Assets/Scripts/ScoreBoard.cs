using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [Tooltip("In seconds")] [SerializeField] float timeForPoints = 3.0f;

    int score = 0;
    Text scoreText;

    float nextTimeToScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();

        nextTimeToScore = timeForPoints;
    }

    private void Update()
    {
        if (Time.time >= nextTimeToScore)
        {
            nextTimeToScore = Time.time + timeForPoints;
            ScoreHit(1);
        }
    }

    public void ScoreHit(int scoreIncrease)
    {
        score += scoreIncrease;
        scoreText.text = score.ToString();
    }
}
