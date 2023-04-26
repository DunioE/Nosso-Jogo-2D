using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitionScript : MonoBehaviour
{
    public int levelIndex;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MenuEvents menuEvents = FindObjectOfType<MenuEvents>();
            if (menuEvents != null)
            {
                menuEvents.LoadLevel(levelIndex);
            }
            else
            {
                SceneManager.LoadScene(levelIndex);
            }
        }
    }
}