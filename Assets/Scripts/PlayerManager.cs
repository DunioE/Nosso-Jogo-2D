using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static Vector2 lastCheckPointPos = new Vector2(-8.7f,-2.9f);

    private void Awake()
    {
        isGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
        
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
