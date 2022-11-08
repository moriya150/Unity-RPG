using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class PHPLoadTest : MonoBehaviour
{

    public static Text LoadNAME;
    public static Text LoadLV;
    public static Text LoadKISO_HP;
    public static Text LoadKISO_AT;
    public static Text LoadKISO_DEF;
    public static Text LoadEXP;
    public static Text LoadSOUBI_HP;
    public static Text LoadSOUBI_AT;
    public static Text LoadSOUBI_DEF;

    public static GameObject te;

    public void LoadDB()
    {
        LoadNAME = PHPTitle.Name;

        StartCoroutine("Dataload");
    }

        

    public IEnumerator Dataload()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("NAME", LoadNAME.GetComponentInChildren<InputField>().text);

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
                //ÇªÇ‡ÇªÇ‡ê⁄ë±Ç™Ç≈Ç´ÇƒÇ¢Ç»Ç¢Ç∆Ç´
                Debug.Log("HttpPost NG: " + www.error);

            }
            else if (www.isDone)
            {
                string[] data = www.downloadHandler.text.Split(',');
                LoadNAME.GetComponent<Text>().text =        data[1];
                LoadLV.GetComponent<Text>().text =          data[2];
                LoadKISO_HP.GetComponent<Text>().text =     data[3];
                LoadKISO_AT.GetComponent<Text>().text =     data[4];
                LoadKISO_DEF.GetComponent<Text>().text =    data[5];
                LoadEXP.GetComponent<Text>().text =         data[6];
                LoadSOUBI_HP.GetComponent<Text>().text =    data[7];
                LoadSOUBI_AT.GetComponent<Text>().text =    data[8];
                LoadSOUBI_DEF.GetComponent<Text>().text =   data[9];



            }
    }

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
