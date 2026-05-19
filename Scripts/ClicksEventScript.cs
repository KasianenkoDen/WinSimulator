using System.Collections;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ClicksEventScript : Selectable, IPointerClickHandler
{
    [Header("ClickEvents")]
    public UnityEvent OnLeftClick;
    public UnityEvent OnRightClick;

    private Coroutine _resetButton;
    protected void Reset()
    {
        var imageComponent = GetComponent<UnityEngine.UI.Image>();
        if(imageComponent == null)
        {
            imageComponent = gameObject.AddComponent<UnityEngine.UI.Image>();
        }
        targetGraphic = imageComponent;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        DoStateTransition(SelectionState.Pressed, true);
        switch (eventData.button)
        {
            default:
            case PointerEventData.InputButton.Left:
                OnLeftClick?.Invoke();
                break;

            case PointerEventData.InputButton.Right:
                OnRightClick?.Invoke();
                break;
        }
        if(_resetButton == null)
        {
            StopCoroutine(OnFinishSumbit());
        }
        _resetButton = StartCoroutine(OnFinishSumbit());
    }
    private IEnumerator OnFinishSumbit()
    {
        var fadeTime = colors.fadeDuration;
        var elapsedTime = 0f;
        while(elapsedTime < fadeTime)
        {
            elapsedTime += Time.unscaledDeltaTime;
            yield return null;
        }
        DoStateTransition(currentSelectionState,false);
    }
}
