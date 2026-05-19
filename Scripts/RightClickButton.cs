using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class RightClickButton : MonoBehaviour
{
    public Canvas RightclickIcon;
    private Vector2 mousePosition;
     public void PositionCheck(BaseEventData data)
    {
        PointerEventData pointerdata = (PointerEventData)data;
        mousePosition = pointerdata.position;
    }
    public void OnRightClick()
    {
            Vector2 pos;
            Vector2 pos2 = new Vector2(-160, 200);
            RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)RightclickIcon.transform, mousePosition, RightclickIcon.worldCamera, out pos);
            RightclickIcon.transform.position = RightclickIcon.transform.TransformPoint(pos-pos2);
    }
}
