using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �_���W�����I�����
public class Dungeon : MonoBehaviour
{   
    // �����_���ɓG��I��
    public static int RANDOM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �����I���{�^���p
    public void first()
    {
        RANDOM = Random.Range(1,4);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }

    // �ጴ�I���{�^���p
    public void second()
    {
        RANDOM = Random.Range(4,7);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }

    // �ΎR�I���{�^���p
    public void third()
    {
        RANDOM = Random.Range(7,10);
        Debug.Log(RANDOM);
        SceneManager.LoadScene("Battle");
    }
}
