using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour //�퓬��ʂ̃t���O�Ǘ�
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
