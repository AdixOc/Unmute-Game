using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }


    public void OpenScene(string sceneName) { 

        SceneManager.LoadSceneAsync(sceneName);
    }

}
