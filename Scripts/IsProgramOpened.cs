using UnityEngine;

public class IsProgramOpened : MonoBehaviour
{
    public bool _IsOpen;
    public bool _IsStartDayWindowOpen;
    public Transform transformApp1;
    public void IsOpened_SetTrue()
    {
        _IsOpen = true;
    }
    public void IsOpened_SetFalse()
    {
        _IsOpen = false;
    }
    public void IsStartWindowOpened_SetTrue()
    {
        _IsStartDayWindowOpen = true;
    }
     public void IsStartWindowOpened_SetFalse()
    {
        _IsStartDayWindowOpen = false;
    }
    void Start()
    {
        _IsOpen = false;
        _IsStartDayWindowOpen = false;
    }
    public void ResetPosition()
    {
        if(_IsOpen == false)
        {
            transformApp1.position = new Vector2(0,0);
        }
    }
}
