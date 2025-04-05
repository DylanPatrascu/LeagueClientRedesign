using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectionButtons : MonoBehaviour {

    [SerializeField] Button[] buttons;
    [SerializeField] GameObject[] hoverImages;
    [SerializeField] GameObject[] contentPages;
    public GameObject infotab;



    public Color hoverColor = new Color(200f / 255f, 170f / 255f, 110f / 255f);
    public Color defaultColor = new Color(200f / 255f, 155f / 255f, 60f / 255f);


    public void Awake()
    {
        OnButtonClicked(buttons[0]);
    }

    public void SetAllButtonsInteractable() {
        foreach (Button button in buttons) {
            button.interactable = true;
            TMP_Text buttonText = button.GetComponentInChildren<TMP_Text>();
            buttonText.fontSize = 40f;
            buttonText.color = defaultColor;
        }
        foreach (GameObject hoverImage in hoverImages)
        {
            hoverImage.SetActive(false);
        }

        foreach (GameObject page in contentPages)
        {
            page.SetActive(false);
        }
        infotab.SetActive(false);
    }
    
    public void OnButtonClicked(Button clickedButton) {
        
        int buttonIndex = System.Array.IndexOf(buttons, clickedButton);
      
        if (buttonIndex == -1)
            return;
      
        SetAllButtonsInteractable();
      
        clickedButton.interactable = false;
        TMP_Text buttonText = clickedButton.GetComponentInChildren<TMP_Text>();
        if (buttonText == null)
        {
            Debug.LogError("TMP_Text not found on button: " + clickedButton.name);
        }
        buttonText.fontSize += 5;
        buttonText.color = hoverColor;
        hoverImages[buttonIndex].SetActive(true);
        contentPages[buttonIndex].SetActive(true);
    }

}
