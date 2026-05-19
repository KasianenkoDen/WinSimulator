using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class DayCheckAnimation : MonoBehaviour
{
    public PlayableDirector ThreeDaysDirector, TwoDaysDirector, OneDayDirector, EndScreen;
    public PlayableDirector StartWin;
    public int WhichDay;

    void Start()
    {
        WhichDay = 3;
    }
    public void DaysMinus()
    {
        WhichDay--;
    }
    public void DaysPlay()
    {
        switch (WhichDay)
        {
            case 3:
                ThreeDaysDirector.Play();
                StartCoroutine(UntilAnimStopped(ThreeDaysDirector));
                break;
            case 2:
                TwoDaysDirector.Play();
                StartCoroutine(UntilAnimStopped(TwoDaysDirector));
                break;
            case 1:
                OneDayDirector.Play();
                StartCoroutine(UntilAnimStopped(OneDayDirector));
                break;
            case 0:
                EndScreen.Play();
                break;
        } 
    }

    IEnumerator UntilAnimStopped(PlayableDirector DayAnim)
    {
        yield return new WaitUntil(() => DayAnim.state == PlayState.Paused);
        StartWin.Play();
    }
}
