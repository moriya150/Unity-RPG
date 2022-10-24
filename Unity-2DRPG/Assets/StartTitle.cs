using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartTitle : MonoBehaviour
{
    public GameObject btn;

    void Start()
    {
        btn = GameObject.Find("Button");
    }

    

    // Update is called once per frame
    void Update()
    {
        if (btn == null)
        {
            btn.SetActive(false);
        }
    }

    

    public void Onclick()
    {
        SceneManager.LoadScene("Dungeon1");
    }
}
