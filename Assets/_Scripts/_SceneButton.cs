using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneButton : MonoBehaviour
{
    private void Awake()
    {
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("Game");
        _Check.number = Config.getNumber();
        _ClamBehavior.onclick = 0;
        _ClamBehavior.score = 0;
        _ClamBehavior.onend = 3;
        _ClamBehavior.endcheck = 0;
        _StarBehavior.checkend = 0;
    }

    public void Continue()
    {
        SceneManager.LoadScene("Level");
    }

}
