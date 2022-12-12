using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

// DB�Ƀf�[�^���A�b�v���[�h
public class PHPUPDATE : MonoBehaviour
{
    public static int LVUP�ϐ� = 1;
    public static int LVUP�{�� = 100;
    public static int KISO_HP_kakeru;
    public static int KISO_AT_kakeru;
    public static int KISO_DEF_kakeru;

    public string UPNAME;
    public string UPLV;
    public string UPKISO_HP;
    public string UPKISO_AT;
    public string UPKISO_DEF;
    public string UPEXP;
    public string UPSOUBI_HP;
    public string UPSOUBI_AT;
    public string UPSOUBI_DEF;

    // �o���l�����𒴂����烌�x���A�b�v�@AND�@DB�ɃA�b�v�f�[�g
    public void LVUP()
    {
        LVUP�ϐ� = int.Parse(PHPLoad.LoadLV);

        if (BattleMainSystem.ALLEXP >= LVUP�ϐ� * LVUP�{��)
        {
            LVUP�ϐ�++;
            LVUP�{�� = LVUP�{�� * 2;

            KISO_HP_kakeru = int.Parse(PHPLoad.LoadKISO_HP);
            KISO_AT_kakeru = int.Parse(PHPLoad.LoadKISO_AT);
            KISO_DEF_kakeru = int.Parse(PHPLoad.LoadKISO_DEF);

            KISO_HP_kakeru = KISO_HP_kakeru + KISO_HP_kakeru;
            KISO_AT_kakeru = KISO_AT_kakeru + KISO_AT_kakeru;
            KISO_DEF_kakeru = KISO_DEF_kakeru + KISO_DEF_kakeru;

            UPDATE_LVUP();
        }

        // LVUP���Ȃ��ꍇEXP����UPDATE
        else
        {
            UPDATE_EXP();
        }
    }

    // EXP����UPDATE
    public void UPDATE_EXP()
    {
        UPNAME      = PHPLoad.LoadNAME; ;
        UPLV        = PHPLoad.LoadLV;
        UPKISO_HP   = PHPLoad.LoadKISO_HP;
        UPKISO_AT   = PHPLoad.LoadKISO_AT;
        UPKISO_DEF  = PHPLoad.LoadKISO_DEF;

        UPEXP       = BattleMainSystem.ALLEXP.ToString();

        // �����̊T�O���������ύX�\��
        UPSOUBI_HP = PHPLoad.LoadSOUBI_HP;     
        UPSOUBI_AT  = PHPLoad.LoadSOUBI_AT;
        UPSOUBI_DEF = PHPLoad.LoadSOUBI_DEF;

        StartCoroutine("LVUPLOAD");
        StartCoroutine("DelayCoroutine3");
    }

    // LVUP��DB�ɔ��f
    public void UPDATE_LVUP()
    {
        UPNAME      = PHPLoad.LoadNAME;

        UPLV        = LVUP�ϐ�.ToString();

        UPKISO_HP   = KISO_HP_kakeru.ToString();
        UPKISO_AT   = KISO_AT_kakeru.ToString();
        UPKISO_DEF  = KISO_DEF_kakeru.ToString();

        UPEXP       = BattleMainSystem.ALLEXP.ToString();

        // �����̊T�O���������ύX�\��
        UPSOUBI_HP = PHPLoad.LoadSOUBI_HP;
        UPSOUBI_AT  = PHPLoad.LoadSOUBI_AT;
        UPSOUBI_DEF = PHPLoad.LoadSOUBI_DEF;
        
        StartCoroutine("LVUPLOAD");
        StartCoroutine("DelayCoroutine3");
    }

    public IEnumerator LVUPLOAD()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("NAME", UPNAME);
        dic.Add("LV", UPLV);
        dic.Add("KISO_HP", UPKISO_HP);
        dic.Add("KISO_AT", UPKISO_AT);
        dic.Add("KISO_DEF", UPKISO_DEF);
        dic.Add("EXP", UPEXP);
        dic.Add("SOUBI_HP", UPSOUBI_HP);
        dic.Add("SOUBI_AT", UPSOUBI_AT);
        dic.Add("SOUBI_DEF", UPSOUBI_DEF);

        StartCoroutine(Post("http://localhost/dbaccess/UPDATE.php", dic));

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

    // 3�b�҂R���[�`��
    public IEnumerator DelayCoroutine3()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Dungeon1");
    }

    // 7�b�҂R���[�`��
    public IEnumerator DelayCoroutine7()
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
