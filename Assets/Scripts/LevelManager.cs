using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    void Start() {
        if (autoLoadNextLevelAfter == 0) {
            Debug.Log("Level Auto Load Disabled.");
        } else {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }

    public void LoadLevel(string name) {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitRequest() {
        Application.Quit();
        Debug.Log("I Want to quit!");
    }
}
