using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Drag_Icon : MonoBehaviour
{
    public Canvas App_icon;
    private Vector3 mouseWordXPos;
    [SerializeField]
    public int Hight;
    public void PosCheck()
    {
        Vector2 mouseXpos = Mouse.current.position.ReadValue();
        mouseWordXPos = Camera.main.ScreenToWorldPoint(mouseXpos);
    }
    public void Drag_Action(BaseEventData data)
    {
        PointerEventData pointerdata = (PointerEventData)data;
        Vector2 pos; 
        Vector2 pos2 = new Vector2(0, Hight);
        Vector2 pos3 = new Vector2(mouseWordXPos.x,0);
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)App_icon.transform, pointerdata.position, App_icon.worldCamera, out pos);
        App_icon.transform.position = App_icon.transform.TransformPoint(pos-pos2+pos3);
    }
}
