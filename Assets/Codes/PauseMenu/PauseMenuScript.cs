using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    public bool isPaused = false;

    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            testingText.text = "Down";
            testingText.color = Color.red;
            //Debug.Log("Down");
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
            testingText.color = Color.magenta;
            //Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(testingKey))
        {
            testingText.text = "Up";
            testingText.color = Color.yellow;

            //This is how you define a color that is not pre-defined
            //testingText.color = new Color(0.6f, 0.3f, 0.1f, 0.5f);

            //Debug.Log("Up");
        }
        else
        {
            //Nothing here
            //This would be every frame the key is not pressed
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        //Will only open menu 
        //menu.SetActive(true);

        isPaused = !isPaused;

        //Will open menu if it's closed, close it if it's open
        //menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);

        //if (isPaused == true)
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}