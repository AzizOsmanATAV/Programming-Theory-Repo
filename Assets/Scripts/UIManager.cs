using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartTheGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }

}
