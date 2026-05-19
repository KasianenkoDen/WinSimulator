using System.Reflection;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleImage : MonoBehaviour
{
    public Sprite PressedImage, DefualtImage;
    public Toggle toggle;
    public Image TargetImage;
    public TextMeshProUGUI IconText;
    void Start()
    {
        toggle.onValueChanged.AddListener(ChangeImage);
    }
    public void ChangeImage(bool IsOn)
    {
        if(gameObject != null)
        TargetImage.sprite = IsOn ? DefualtImage : PressedImage;

        IconText.fontStyle = IsOn ? FontStyles.Bold : FontStyles.Normal;
    }

}
