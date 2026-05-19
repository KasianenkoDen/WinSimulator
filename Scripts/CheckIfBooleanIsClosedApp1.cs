using UnityEngine;

public class CheckIfBooleanIsClosedApp1 : MonoBehaviour
{
    public IsProgramOpened Script;
    public GameObject itself;
    void Update()
    {
        if(Script._IsOpen == false)
        {
            itself.SetActive(false);
        }
        if(Script._IsOpen == true)
        {
            itself.SetActive(true);
        }
    }
}
