using UnityEngine;
using UnityEngine.UI;

// put this in some parent object to the buttons (like a menu container)
// then, link the parent inside the button's OnClick()
// not my code btw lol
public class RadioButtons : MonoBehaviour {

    [SerializeField] Button[] buttons;
    
    public void SetAllButtonsInteractable() {
        foreach (Button button in buttons) {
            button.interactable = true;
        }
    }
    
    public void OnButtonClicked(Button clickedButton) {
        
        int buttonIndex = System.Array.IndexOf(buttons, clickedButton);
      
        if (buttonIndex == -1) {
            return;
        }
      
        SetAllButtonsInteractable();
      
        clickedButton.interactable = false;
    }

}
