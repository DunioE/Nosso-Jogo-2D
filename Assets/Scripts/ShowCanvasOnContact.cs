using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCanvasOnContact : MonoBehaviour
{
    public float displayTime = 5.0f; // tempo em segundos que o canvas será exibido
    public GameObject canvasObject; // referência ao objeto do canvas que será mostrado
    private bool displayCanvas = false; // variável para controlar se o canvas deve ser exibido ou não
    private float displayTimer = 0.0f; // temporizador para controlar o tempo de exibição do canvas

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            displayCanvas = true; // ativa a exibição do canvas quando o player entrar em contato com o objeto
        }
    }

    void Update()
    {
        if (displayCanvas)
        {
            canvasObject.SetActive(true); // ativa o canvas
            displayTimer += Time.deltaTime; // atualiza o temporizador

            if (displayTimer >= displayTime)
            {
                canvasObject.SetActive(false); // desativa o canvas quando o tempo de exibição acabar
                displayCanvas = false; // desativa a exibição do canvas
                displayTimer = 0.0f; // reseta o temporizador
            }
        }
    }
}