using UnityEngine;

public class StartGameWindowButton : MonoBehaviour
{
    public IsProgramOpened Bool;
    public GameObject StartGameWindow;
    public void Start()
    {
        Bool._IsStartDayWindowOpen = false;
    }
    public void CheckOpen()
    {
        if(Bool._IsStartDayWindowOpen == false)
        {
            StartGameWindow.SetActive(true);
        }
        if(Bool._IsStartDayWindowOpen == true && StartGameWindow.activeInHierarchy)
        {
            return;
        }
        if(Bool._IsStartDayWindowOpen == true)
        {
            if(StartGameWindow != null)
            StartGameWindow.SetActive(false);
        }
    }

    
}
