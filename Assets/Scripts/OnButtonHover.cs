using UnityEngine;
using TMPro;

public class OnButtonHover : MonoBehaviour
{
    public Color hoverColor = new Color(200f / 255f, 170f / 255f, 110f / 255f);
    public Color defaultColor = new Color(200f / 255f, 155f / 255f, 60f / 255f);
    public int fontSizeIncrease = 5;

    public void UpdateTextEnter(TMP_Text buttonText)
    {
        if (!buttonText.GetComponentInParent<UnityEngine.UI.Button>().interactable) return;

        buttonText.fontSize += fontSizeIncrease;
        buttonText.color = hoverColor;
    }

    public void UpdateTextExit(TMP_Text buttonText)
    {
        if (!buttonText.GetComponentInParent<UnityEngine.UI.Button>().interactable) return;

        buttonText.fontSize -= fontSizeIncrease;
        buttonText.color = defaultColor;
    }

}
