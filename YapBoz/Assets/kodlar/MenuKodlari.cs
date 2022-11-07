using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKodlari : MonoBehaviour
{

 
    public void kolaySeviye()
    {
        SceneManager.LoadScene(1);
    }
    public void ortaSeviye()
    {
        SceneManager.LoadScene(2);
    }
    public void zorSeviye()
    {
        SceneManager.LoadScene(3);
    }
    public void anaEkranaGit()
    {
        SceneManager.LoadScene(0);
    }
    public void cikis()
    {
        Application.Quit();
    }
}
