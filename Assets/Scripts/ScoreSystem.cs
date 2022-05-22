using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] float scoreMultiplier;

    float score;
    bool shouldCount = true;
    // Update is called once per frame
    void Update()
    {
        if (!shouldCount) { return; }
        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public int EndTimer()
    {
        shouldCount = false;

        scoreText.text = string.Empty;

        return Mathf.FloorToInt(score);
    }
}
