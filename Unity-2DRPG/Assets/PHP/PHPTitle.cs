using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class PHPTitle : MonoBehaviour
{
    public static string Name;
    public InputField InputTE;
    public GameObject LoadPanel; //load�p�̃p�l��

    public GameObject ButtonCa; //�ʂ̃{�^���������Ȃ��悤��

    public GameObject TAIKI;

    public void Button_Push()
    {
        InputTE = InputTE.GetComponent<InputField>();

        Name = InputTE.text; //���͂���������string�ɕϊ�


        /*if (Name == null)
        {
            return;     //�������@�󔒂��Ɩ߂�

        }*/

        StartCoroutine("Access"); // DB�Ƀf�[�^��}�����āA���[�h�p�̃p�l���̕\���B
        LoadPanel.SetActive(true);
        ButtonCa.SetActive(false); //���̂ق����\��
    }

        public void Yomikomi()
        {
        TAIKI.SetActive(true);
        }

        private IEnumerator Access() �@//���͂������O�̃v���C���[��V�K�쐬
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("NAME", Name);

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
                   
                }
            }

        }
        // Start is called before the first frame update
        void Start()
    {
        LoadPanel.SetActive(false);
        TAIKI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //InputTE = InputTE.GetComponent<InputField>();

        //Name = InputTE.text; //���͂���������string�ɕϊ�
    }
}
