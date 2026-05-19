using UnityEngine;
using UnityEngine.Playables;

public class CheckStartTaskIcon : MonoBehaviour
{
    public GameObject AnimationTarget;
    public GameObject WhiteBg;
    public PlayableDirector Animation;
    public void CheckIfPlaying()
    {
        if(Animation.time <= 0.1f)
        {
            WhiteBg.SetActive(false);
            AnimationTarget.SetActive(false);
        }
    }
}
