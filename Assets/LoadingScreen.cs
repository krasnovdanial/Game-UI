using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public string loadLevel;
    public GameObject loadingScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        SceneManager.LoadScene(loadLevel);
        loadingScreen.SetActive(true);
    }
}
