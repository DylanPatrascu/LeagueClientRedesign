using TMPro;
using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    private static GameObject lastSelectedIcon;
    private static GameObject lastSelectedWindow;
    public Color hoverColor = new Color(200f / 255f, 170f / 255f, 110f / 255f);
    public Color defaultColor = new Color(200f / 255f, 155f / 255f, 60f / 255f);
    public int fontSizeIncrease = 5;


    public void OnButtonClicked(GameObject selectedIcon, GameObject selectedWindow, TMP_Text buttonText)
    {
        // Reset the previously selected button if it's different from the current one
        if (lastSelectedIcon != null && lastSelectedIcon != selectedIcon)
        {
            lastSelectedIcon.SetActive(false);
            lastSelectedWindow.SetActive(false);
            buttonText.fontSize -= fontSizeIncrease;
            buttonText.color = defaultColor;
        }

        // Set the new selection active
        selectedIcon.SetActive(true);
        selectedWindow.SetActive(true);
        buttonText.fontSize += fontSizeIncrease;
        buttonText.color = hoverColor;

        // Update the last selected references
        lastSelectedIcon = selectedIcon;
        lastSelectedWindow = selectedWindow;
    }
}
