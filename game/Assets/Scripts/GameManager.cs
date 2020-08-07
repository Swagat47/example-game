using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  

    public void PlayGame(int SceneIndex)
    {        
        SceneManager.LoadScene(SceneIndex);
    }
}
