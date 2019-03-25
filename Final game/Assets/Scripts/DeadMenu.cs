using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    private MenuPause pause;
    private controles player;
    public GameObject deadMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        deadMenuUI.SetActive(false);
        player = GetComponentInParent<controles>();
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void Restart()
    {
        deadMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
