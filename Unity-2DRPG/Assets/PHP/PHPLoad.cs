using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

// タイトルで入力した名前を使って、DBでロード
public class PHPLoad : MonoBehaviour
{
    public static string LoadNAME;
    public static string LoadLV;
    public static string LoadKISO_HP;
    public static string LoadKISO_AT;
    public static string LoadKISO_DEF;
    public static string LoadEXP;
    public static string LoadSOUBI_HP;
    public static string LoadSOUBI_AT;
    public static string LoadSOUBI_DEF;

    public void LoadDB()
    {
        LoadNAME = PHPTitle.Name;
        StartCoroutine("Dataload");
        StartCoroutine("DelayCoroutine");       
    }

    public IEnumerator Dataload()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("NAME" ,LoadNAME);

        StartCoroutine(Post("http://localhost/dbaccess/load.php", dic));

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
                // そもそも接続ができていないとき
                Debug.Log("HttpPost NG: " + www.error);
            }
            else if (www.isDone)
            {
                string[] data = www.downloadHandler.text.Split(',');

                LoadNAME        = data[1];
                LoadLV          = data[2];
                LoadKISO_HP     = data[3];
                LoadKISO_AT     = data[4];
                LoadKISO_DEF    = data[5];
                LoadEXP         = data[6];
                LoadSOUBI_HP    = data[7];
                LoadSOUBI_AT    = data[8];
                LoadSOUBI_DEF   = data[9];

                Debug.Log(LoadNAME);
                Debug.Log(LoadLV);
                Debug.Log(LoadKISO_HP);
                Debug.Log(LoadKISO_AT);
                Debug.Log(LoadKISO_DEF);
                Debug.Log(LoadEXP);
                Debug.Log(LoadSOUBI_HP);
                Debug.Log(LoadSOUBI_AT);
                Debug.Log(LoadSOUBI_DEF);
            }
        }
    }

    // 7秒待つコルーチン
    public IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(7);

        SceneManager.LoadScene("Dungeon1");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
