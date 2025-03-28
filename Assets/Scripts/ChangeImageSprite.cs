using UnityEngine;
using UnityEngine.UI;

// specific to battle pass: change an image's sprite with a button click
// this goes inside the image with a sprite
// for GoToSprite, link the image inside the button's OnClick()
public class ChangeImageSprite : MonoBehaviour {
    [SerializeField] Image page;
    [SerializeField] Sprite[] pageSprites;
    int currentPage = 0;
    [SerializeField] Image title;
    [SerializeField] Sprite[] titleSprites;
    int currentTitle = 0;
    [SerializeField] Button[] chapterButtons;

    public void NextSprite() {
        if (currentPage + 1 == pageSprites.Length) {
            return;
        }

        currentPage++;
        page.sprite = pageSprites[currentPage];

        switch(currentPage) {
            case 0:
                title.sprite = titleSprites[0];
                currentTitle = 0;
                break;
            case 2:
                title.sprite = titleSprites[1];
                currentTitle = 1;
                break;
            case 4:
                title.sprite = titleSprites[2];
                currentTitle = 2;
                break;
            case 6:
                title.sprite = titleSprites[3];
                currentTitle = 3;
                break;
            case 8:
                title.sprite = titleSprites[4];
                currentTitle = 4;
                break;
        }
    }

    public void PrevSprite() {
        if (currentPage - 1 == -1) {
            return;
        }

        currentPage--;
        page.sprite = pageSprites[currentPage];

        switch(currentPage) {
            case 0:
                title.sprite = titleSprites[0];
                currentTitle = 0;
                break;
            case 2:
                title.sprite = titleSprites[1];
                currentTitle = 1;
                break;
            case 4:
                title.sprite = titleSprites[2];
                currentTitle = 2;
                break;
            case 6:
                title.sprite = titleSprites[3];
                currentTitle = 3;
                break;
            case 8:
                title.sprite = titleSprites[4];
                currentTitle = 4;
                break;
        }
    }

    // for chapter title sprites
    public void GoToTitleSprite(Button clickedButton) {
        
        int buttonIndex = System.Array.IndexOf(chapterButtons, clickedButton);
      
        if (buttonIndex == -1) {
            return;
        }

        title.sprite = titleSprites[buttonIndex];
        currentTitle = buttonIndex;
   
    }

    // for main page sprites
    public void GoToPageSprite(Button clickedButton) {
        
        int buttonIndex = System.Array.IndexOf(chapterButtons, clickedButton);
      
        if (buttonIndex == -1) {
            return;
        }

        // this is dumb, but 8% programming
        switch(buttonIndex) {
            case 0:
                page.sprite = pageSprites[0];
                currentPage = 0;
                title.sprite = titleSprites[0];
                currentTitle = 0;
                break;
            case 1:
                page.sprite = pageSprites[2];
                currentPage = 2;
                title.sprite = titleSprites[1];
                currentTitle = 1;
                break;
            case 2:
                page.sprite = pageSprites[4];
                currentPage = 4;
                title.sprite = titleSprites[2];
                currentTitle = 2;
                break;
            case 3:
                page.sprite = pageSprites[6];
                currentPage = 6;
                title.sprite = titleSprites[3];
                currentTitle = 3;
                break;
            case 4:
                page.sprite = pageSprites[8];
                currentPage = 8;
                title.sprite = titleSprites[4];
                currentTitle = 4;
                break;
        }
        
    }

}
