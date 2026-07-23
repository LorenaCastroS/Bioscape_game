using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [Header("Menu Settings")]
    [SerializeField] private GameObject pauseMenu;

    [Header("Button Components")]
    [SerializeField] private Button resumeButtonComponent;
    [SerializeField] private Button quitButtonComponent;

    private bool paused = false;

    void Start()
    {
        if (resumeButtonComponent != null)
        {
            resumeButtonComponent.onClick.RemoveAllListeners();
            resumeButtonComponent.onClick.AddListener(button_resume);
        }
        else {
            Debug.LogWarning("Aviso: O componente resumeButtonComponent não foi arrastado no Inspector!");
        }

        if (quitButtonComponent != null)
        {
            quitButtonComponent.onClick.RemoveAllListeners();
            quitButtonComponent.onClick.AddListener(button_quit);
        }
        else { 
            Debug.LogWarning("Aviso: O componente quitButtonComponent não foi arrastado no Inspector!");
        }

            resumeGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // If player press escape the pause menu is activated
        {
            Debug.Log("A tecla ESC foi pressionada!");

            if (paused) { resumeGame(); }
            else { pauseGame(); } // Pauses the game
        }
    }

    public void pauseGame()
    {
        Debug.Log("O jogo foi pausado!");

        pauseMenu.SetActive(true);
        paused = true;
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        Debug.Log("O jogo foi despausado");

        pauseMenu.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

    public void quitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void button_quit()
    {
        Debug.Log("Botão de quit foi apertado");
        quitToMenu();
    }

    public void button_resume()
    {
        Debug.Log("Botão de resume foi apertado");
        resumeGame();
    }
}
