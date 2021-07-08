using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterButton : MonoBehaviour
{
    // Start is called before the first frame update
    /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } */

    void OnMouseDown()
    {
        // from start scene to gameScene
        SceneManager.LoadScene("gameScene");    
    }
}
