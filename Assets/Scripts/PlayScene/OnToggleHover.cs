using UnityEngine;
using TMPro;

public class OnToggleHover : MonoBehaviour
{
    public Color hoverColor = new Color(200f / 255f, 170f / 255f, 110f / 255f);
    public Color defaultColor = new Color(200f / 255f, 155f / 255f, 60f / 255f);
    public int fontSizeIncrease = 5;
    private bool isToggled = false;

    public void Awake()
    {
        if (this.GetComponentInParent<UnityEngine.UI.Toggle>().isOn){
            isToggled = true;
        }
    }
    public void UpdateTextEnter(TMP_Text toggleText)
    {
        if (!toggleText.GetComponentInParent<UnityEngine.UI.Toggle>().interactable
            || toggleText.GetComponentInParent<UnityEngine.UI.Toggle>().isOn) return;

        toggleText.fontSize += fontSizeIncrease;
        toggleText.color = hoverColor;
    }

    public void UpdateTextExit(TMP_Text toggleText)
    {
        if (!toggleText.GetComponentInParent<UnityEngine.UI.Toggle>().interactable 
            || toggleText.GetComponentInParent<UnityEngine.UI.Toggle>().isOn) return;
        toggleText.fontSize -= fontSizeIncrease;
        toggleText.color = defaultColor;
    }

    public void UpdateTextDeselect(TMP_Text toggleText)
    {
        if (isToggled == true)
        {
            toggleText.fontSize -= fontSizeIncrease;
            toggleText.color = defaultColor;
            isToggled = false;
        }
        else
        {
            isToggled = true;
        }
    }
}
