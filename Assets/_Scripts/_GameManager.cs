using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{
    private void Awake()
    {
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
