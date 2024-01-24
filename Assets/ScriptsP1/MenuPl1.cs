using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPl1 : MonoBehaviour
{
   
    public GameObject MenuPausa;
    public GameObject Pausa;
    public GameObject Friend;
    public void Pause()
    {
        Time.timeScale = 0f;
        Pausa.SetActive(false);
        MenuPausa.SetActive(true);
    }

    
    public void Reaundar()
    {
        Time.timeScale = 1f;
        Pausa.SetActive(true);
        MenuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Multiplayer()
    {
        Time.timeScale = 1f;
      //  Friend.SetActive(true);
        SceneManager.LoadScene("J1J2");
    }

}
