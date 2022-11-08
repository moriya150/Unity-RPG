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

            Name.text = te.text; //���͂���������text�ɕϊ�

            
        if (Name == null)
            {
                return;     //�������@�󔒂��Ɩ߂�
               
            }

            else if(Name != null) 
            {
                SceneManager.LoadScene("Dungeon1");
                StartCoroutine("Access");
            }

        }

        private IEnumerator Access() �@//���͂������O�̃v���C���[��V�K�쐬
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
                    //���������ڑ����ł��Ă��Ȃ��Ƃ�
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
