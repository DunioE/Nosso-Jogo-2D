using UnityEngine.SceneManagement;
using UnityEngine;

public class controlador : MonoBehaviour
{

    public static bool isGameOn;
    public GameObject gameOverS;
    
    public static Vector2 lastCheckPointPos = new Vector2(7.3f, 1.7f);

    private void Awake()
    {
        isGameOn = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    void Start()
    {

    }

    void Update()
    {
        if (isGameOn)
        {
            gameOverS.SetActive(true);
        }

    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}