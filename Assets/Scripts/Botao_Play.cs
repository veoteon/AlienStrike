using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao_Play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Alien Strike"); // Substitua "NomeDaCenaDoJogo" pelo nome da cena onde seu jogo começa.
    }
}
