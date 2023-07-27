using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public Lives live;

    void Update()
    {
        if (live.numOfHearts == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
