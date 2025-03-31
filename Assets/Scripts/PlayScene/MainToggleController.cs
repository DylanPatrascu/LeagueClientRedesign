using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainToggleController : MonoBehaviour
{
    public Toggle mainToggle;
    public GameObject subButtonsPanel; 
    public GameObject description; 

    private void Start()
    {
        // hide everything at start
        subButtonsPanel.SetActive(false);
        description.SetActive(false);

        mainToggle.onValueChanged.AddListener(OnMainToggleChanged);
    }

    private void OnMainToggleChanged(bool isOn)
    {
        if (isOn)
        {
            subButtonsPanel.SetActive(true);
            description.SetActive(true);
        }
        else
        {
            // Prevent auto-closing
            //mainToggle.isOn = true;
            mainToggle.isOn = false;
            subButtonsPanel.SetActive(false);
            description.SetActive(false);
        }
    }

    public void ForceClose()
    {
        mainToggle.isOn = false;
        subButtonsPanel.SetActive(false);
        description.SetActive(false);
    }

    public void UpdateDescriptionEnter()
    {
        if (!mainToggle.isOn)
        {
            description.SetActive(true);
        }
    }

    public void UpdateDescriptionExit()
    {
        if (!mainToggle.isOn)
        {
            description.SetActive(false);
        }
    }
}