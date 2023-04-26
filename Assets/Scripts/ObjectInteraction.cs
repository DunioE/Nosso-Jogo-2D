using UnityEngine;
using TMPro;

public class ObjectInteraction : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI textMeshPro;
    public float objectLifetime = 5f; // Tempo de vida do objeto
    public float messageLifetime = 3f; // Tempo de vida da mensagem exibida no canvas

    private bool hasInteracted = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasInteracted)
        {
            hasInteracted = true;

            // Ativa o canvas e exibe a mensagem
            canvas.gameObject.SetActive(true);
            textMeshPro.gameObject.SetActive(true);

            // Define um tempo para a destruição do objeto, canvas e mensagem
            Destroy(gameObject, objectLifetime);
            Destroy(canvas.gameObject, messageLifetime + objectLifetime);
            Destroy(textMeshPro.gameObject, messageLifetime);
        }
    }
}