using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

//敵データをDBでロード 対応した敵を表示
public class PHPEnemyLoad : MonoBehaviour 
{
    public int IntLoadEnemy_ID;

    public static string LoadEnemy_ID;
    public static string LoadEnemyNAME;
    public static string LoadEnemyHP;
    public static string LoadEnemyAT;
    public static string LoadEnemyDEF;
    public static string LoadEnemyEXP;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;
    public GameObject Enemy8;
    public GameObject Enemy9;

    // 乱数に対応した敵データをDBからロード
    public void LoadEnemyDB()
    {   
        IntLoadEnemy_ID = Dungeon.RANDOM;
        LoadEnemy_ID = IntLoadEnemy_ID.ToString();
        StartCoroutine("DataloadEnemy");
    }

    // 乱数に対応した敵を表示
    public void LoadEnemySelection()    
    {
        if (IntLoadEnemy_ID == 1)
        {
            Enemy1.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 2)
        {
            Enemy2.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 3)
        {
            Enemy3.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 4)
        {
            Enemy4.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 5)
        {
            Enemy5.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 6)
        {
            Enemy6.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 7)
        {
            Enemy7.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 8)
        {
            Enemy8.SetActive(true);
        }
        else if (IntLoadEnemy_ID == 9)
        {
            Enemy9.SetActive(true);
        }
    }


    public IEnumerator DataloadEnemy()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("ENEMY_ID", LoadEnemy_ID);

        StartCoroutine(Post("http://localhost/dbaccess/Enemy_load.php", dic));

        yield return 0;
    }

    private IEnumerator Post(string url, Dictionary<string, string> post)
    {
        WWWForm form = new WWWForm();

        foreach (KeyValuePair<string, string> post_arg in post)
        {
            form.AddField(post_arg.Key, post_arg.Value);
        }

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();

            if (www.error != null)
            {
                //そもそも接続ができていないとき
                Debug.Log("HttpPost NG: " + www.error);
            }

            else if (www.isDone)
            {
                string[] data = www.downloadHandler.text.Split(',');

                LoadEnemyNAME = data[1];
                LoadEnemyHP = data[2];
                LoadEnemyAT = data[3];
                LoadEnemyDEF = data[4];
                LoadEnemyEXP = data[5];

                // 計算用に代入
                UnitEnemy.Enemyhp = int.Parse(LoadEnemyHP);
                UnitEnemy.EnemyhpMax = int.Parse(LoadEnemyHP);
                UnitEnemy.Enemyat = int.Parse(LoadEnemyAT);
                UnitEnemy.Enemydef = int.Parse(LoadEnemyDEF);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // 対応していない敵を非表示
        Enemy1.SetActive(false);
        Enemy2.SetActive(false);
        Enemy3.SetActive(false);
        Enemy4.SetActive(false);
        Enemy5.SetActive(false);
        Enemy6.SetActive(false);
        Enemy7.SetActive(false);
        Enemy8.SetActive(false);
        Enemy9.SetActive(false);

        LoadEnemyDB();
    }

    // Update is called once per frame
    void Update()
    {

    }
}