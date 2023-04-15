using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGamePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Quit()
    {
        Application.Quit();
    }
    
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    
}
