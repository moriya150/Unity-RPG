using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class PHPTitle : MonoBehaviour
{
        public static Text Name;
        public InputField te;

        public void Button_Push()
        {
            te = te.GetComponent<InputField>();
            Name = Name.GetComponent<Text>();

            Name.text = te.text; //入力した文字をtextに変換

            
        if (Name == null)
            {
                return;     //未完成　空白だと戻る
               
            }

            else if(Name != null) 
            {
                SceneManager.LoadScene("Dungeon1");
                StartCoroutine("Access");
            }

        }

        private IEnumerator Access() 　//入力した名前のプレイヤーを新規作成
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("NAME", Name.GetComponentInChildren<InputField>().text);

            StartCoroutine(Post("http://localhost/dbaccess/Title-INSERT.php", dic));

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
                   // QuestionText.GetComponent<Text>().text = www.downloadHandler.text;
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
