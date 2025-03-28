using UnityEngine;
using UnityEngine.UI;

// this goes inside the scrollbar object
// then, link the scrollbar inside the button's OnClick()
public class ConnectButtonScroll : MonoBehaviour {

   [SerializeField] Button[] buttons;
   [SerializeField] float[] scrollValue;
   [SerializeField] Scrollbar scrollBar;
    
    // clicking a button moves the scrollbar to its value
    public void ClickAndScroll(Button clickedButton) {

        int buttonIndex = System.Array.IndexOf(buttons, clickedButton);
      
        if (buttonIndex == -1) {
            return;
        }
        
        scrollBar.value = scrollValue[buttonIndex];
    }

}
