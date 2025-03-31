using UnityEngine;

public class CraftingClicked : MonoBehaviour
{
    public GameObject infoScreen;

    public void onInventoryClick()
    {
        infoScreen.SetActive(true);
    }
}
