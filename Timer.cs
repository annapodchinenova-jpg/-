using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes = 1;
    public float seconds = 0;

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                minutes--;
                seconds += 59;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
