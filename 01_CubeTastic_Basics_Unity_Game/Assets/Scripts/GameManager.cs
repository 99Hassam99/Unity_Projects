using UnityEngine;
using UnityEngine.SceneManagement; // for restarting or reloading scenes or game

public class GameManager : MonoBehaviour
{   

    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game End");
            Invoke("Restart", restartDelay);
            // Restart();
        }
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
