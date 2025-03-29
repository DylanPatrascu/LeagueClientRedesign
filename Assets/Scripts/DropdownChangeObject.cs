using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// use a dropdown to select a game object
// link the game object inside the dropdown's event
public class DropdownImageChange : MonoBehaviour {
    [SerializeField] GameObject[] pages;

    private void DisableAllPages() {
        foreach (GameObject page in pages) {
            page.SetActive(false);
        }
    }
    public void OnDropdownClick(TMP_Dropdown dropdown) {
        
        DisableAllPages();

        switch(dropdown.value) {
            case 0:
                pages[0].SetActive(true);
                break;
            case 1:
                pages[1].SetActive(true);
                break;
            case 2:
                pages[2].SetActive(true);
                break;
            case 3:
                pages[3].SetActive(true);
                break;
        }
    }
}
