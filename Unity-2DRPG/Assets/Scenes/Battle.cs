using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 戦闘画面のシーン変移ボタン
public class Battle : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickWin()
    {
        SceneManager.LoadScene("Item");
    }

    public void OnclickLose()
    {
        SceneManager.LoadScene("StartTitle");
    }
}
