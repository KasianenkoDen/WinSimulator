using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class CloseAllWindowsAtStart : MonoBehaviour
{
    public GameObject app1;
    public GameObject Lowerapp1;
    public GameObject RightClick;
    public GameObject WinTab;
    public Button Yes, No, Print, x_button, _button;
    public Toggle lowerpanel;
    public Button LogOff;
    public GameObject LogOffCheckWindow;

    void Start()
    {
        LogOff.interactable = false;
        Yes.interactable = false;
        No.interactable = false;
        Print.interactable = false;
        WinTab.SetActive(false);
        app1.SetActive(false);
        Lowerapp1.SetActive(false);
        RightClick.SetActive(false);
        LogOffCheckWindow.SetActive(false);
    }
    public void unInteractableButtons_True()
    {
        Yes.interactable = true;
        No.interactable = true;
        Print.interactable = true;
    }
    public void unIteractable_DayReset()
    {
        x_button.interactable = true;
        _button.interactable = true;
        lowerpanel.interactable = true;
    }
    public void unInteractableButtons_No_False()
    {
        No.interactable = false;
    }
    public void LogOffButtonInteractable_On()
    {
        LogOff.interactable = true;
    }
}
