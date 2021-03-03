using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string startGameScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene(startGameScene);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
