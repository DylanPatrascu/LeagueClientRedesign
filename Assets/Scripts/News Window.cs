using UnityEngine;
using UnityEngine.UI;

public class NewsWindow : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject[] buttons;

    private void Start()
    {
        panels[0].SetActive(true);

        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
    }

    public void selectNews(int index)
    {
        foreach (GameObject panel in panels)
            panel.SetActive(false);

        panels[index].SetActive(true);

        buttons[index].GetComponent<Button>();
    }
}
