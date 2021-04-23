using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMenuFunctions : MonoBehaviour
{
    // Class Members
    // Public
    public static bool IsPaused = false;
    // Private
    // Protected


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // Virtual Methods
    public virtual void StartGame()
    {

    }

    public virtual void GotoScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public virtual void Resume()
    {
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public virtual void Pause()
    {
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public virtual void Quit()
    {
        Debug.Log("Exiting Application");
        Application.Quit();
    }
}
