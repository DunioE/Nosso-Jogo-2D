using UnityEngine;
using TMPro;

public class TriggerText : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI textMeshPro;
    public float tempoParaDestruir = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canvas.gameObject.SetActive(true);
            textMeshPro.gameObject.SetActive(true);
            Destroy(gameObject, tempoParaDestruir); // Destruir o objeto que contém o script após um tempo
            Destroy(canvas.gameObject, tempoParaDestruir); // Destruir o objeto do canvas após um tempo
            Destroy(textMeshPro.gameObject, tempoParaDestruir); // Destruir o objeto do TextMeshProUGUI após um tempo
        }
    }
}