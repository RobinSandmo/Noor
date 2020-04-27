
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMenu() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public Canvas menu;

    bool menuIsOpen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuIsOpen = !menuIsOpen;

            if (menuIsOpen)
            {
                menu.enabled = true;
                Time.timeScale = 0;
            }
            if (!menuIsOpen)
            {
                menu.enabled = false;
                Time.timeScale = 1;
            }
        }
    }
}
