using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCanvasOnContact : MonoBehaviour
{
    public float displayTime = 5.0f; // tempo em segundos que o canvas ser� exibido
    public GameObject canvasObject; // refer�ncia ao objeto do canvas que ser� mostrado
    private bool displayCanvas = false; // vari�vel para controlar se o canvas deve ser exibido ou n�o
    private float displayTimer = 0.0f; // temporizador para controlar o tempo de exibi��o do canvas

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            displayCanvas = true; // ativa a exibi��o do canvas quando o player entrar em contato com o objeto
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
                canvasObject.SetActive(false); // desativa o canvas quando o tempo de exibi��o acabar
                displayCanvas = false; // desativa a exibi��o do canvas
                displayTimer = 0.0f; // reseta o temporizador
            }
        }
    }
}