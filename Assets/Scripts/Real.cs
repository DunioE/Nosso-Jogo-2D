using UnityEngine.SceneManagement;
using UnityEngine;

public class Real : MonoBehaviour
{

    public static bool oGameOver;
    public GameObject gameOverScreen;

    public static Vector2 lastCheckPointPos = new Vector2(130, 1);

    private void Awake()
    {
        oGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    void Start()
    {

    }

    void Update()
    {
        if (oGameOver)
        {
            gameOverScreen.SetActive(true);
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
