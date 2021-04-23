using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : BasicMenuFunctions
{
    // Class Members
    // Public
    [Header("Panels References")]
    public GameObject baseMainMenuPanel;
    public GameObject boatSelectionPanel;
    public GameObject helpPanel;
    public GameObject settingsPanel;

    [Header("Boat Prefabs")]
    public GameObject[] boatPrefabs;

    public static GameObject selectedBoat;
    public static string boatName = "";
    // Private

    public void ContinueToSelection()
    {
        baseMainMenuPanel.SetActive(false);
        boatSelectionPanel.SetActive(true);
    }

    public override void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public override void Quit()
    {
        base.Quit();
    }

    public void Settings()
    {

    }

    public void Help()
    {
        baseMainMenuPanel.SetActive(false);
        helpPanel.SetActive(true);
    }

    public void ReturnMenuButton(GameObject currentPanel)
    {
        currentPanel.SetActive(false);
        baseMainMenuPanel.SetActive(true);
    }

    public void SetSelectedBoat(GameObject objectCalling)
    {
        if (objectCalling.name == "MotorBoat")
        {
            Debug.Log("Motor Boat");
            selectedBoat = boatPrefabs[1];
        }
        else if (objectCalling.name == "SailBoat")
        {
            Debug.Log("Sail Boat");
            selectedBoat = boatPrefabs[0];
        }

        boatName = objectCalling.name;
    }


}
