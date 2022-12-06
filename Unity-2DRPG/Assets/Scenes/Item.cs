using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// �����p�i���쐬�j
public class Item : MonoBehaviour
{
    public GameObject DungeonButton;
    public GameObject LoadPanelItem;

    // Start is called before the first frame update
    void Start()
    {
        LoadPanelItem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 3�b�҂R���[�`��
    public IEnumerator DelayCoroutine3()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Dungeon1");
    }

    public void Onclick()
    {
        LoadPanelItem.SetActive(true);
        DungeonButton.SetActive(false);
        StartCoroutine("DelayCoroutine3");      
    }
}
