using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ダンジョン選択画面
public class Dungeon : MonoBehaviour
{   
    // ランダムに敵を選ぶ
    public static int RANDOM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 草原選択ボタン用
    public void first()
    {
        RANDOM = Random.Range(1,4);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }

    // 雪原選択ボタン用
    public void second()
    {
        RANDOM = Random.Range(4,7);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }

    // 火山選択ボタン用
    public void third()
    {
        RANDOM = Random.Range(7,10);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }
}
