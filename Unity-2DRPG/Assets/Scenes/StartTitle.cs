using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartTitle : MonoBehaviour
{
    public GameObject btn;
    public GameObject te;
    public string tex;

    void Start() 
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        

        if (te != null) //文字の入力が有ったらボタンを出現させるようにしたい。
        {
            btn.SetActive(true);
        }

 

    }

    

    public void Onclick()
    {
        SceneManager.LoadScene("Dungeon1");

    }
}
