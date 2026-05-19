using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreSumUp : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public ButtonYES buttonYES;

    int ScoreIn = 0;
    int ScoreToShow = 0;
    float DelayCalculated;
    IEnumerator AddScore()
    {
        while(ScoreToShow < ScoreIn)
        {
            ScoreToShow++;
            ScoreText.text = ScoreToShow.ToString();

            WaitForSeconds delay = new WaitForSeconds(DelayCalculated);
            yield return delay;
        }
    }

    void Awake()
    {
        ScoreIn = buttonYES.total;
        DelayCalculated = 3.5f / ScoreIn;
        StartCoroutine(AddScore());
    }
}
