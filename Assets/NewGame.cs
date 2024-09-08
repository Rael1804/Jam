using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
 public void JugarOtraVez()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }
}
