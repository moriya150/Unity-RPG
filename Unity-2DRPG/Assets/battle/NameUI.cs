    using UnityEngine;
    using UnityEngine.UI;

    public class NameUI : MonoBehaviour //戦闘画面でステータスを表示させる
{
        //public static NameUI instance;

        public string PlayerNAME;   

        public static int LV;   //計算するためにintに変換
        public static int HP;
        public static int MAXHP;
        public static int AT;
        public static int DEF;

        public string STLV;     //GameObjectに入れるためにいったんstringに変換
        public string STHP;
        public string STMAXHP;
        public string STAT;
        public string STDEF;

        public GameObject UINAME;  //画面に表示するためのGameObject
        public GameObject UILV;
        public GameObject UIHP;
        public GameObject UIMAXHP;
        public GameObject UIAT;
        public GameObject UIDEF;

        public GameObject BTSTARTPanel;
        public GameObject UICanvas;

        public void BTSTART()
        {
            BTSTARTPanel.SetActive(false);//戦闘開始ボタンパネルのオフ

            UICanvas.SetActive(true);

            PlayerNAME = PHPLoadTest.LoadNAME;   //DBから読み込んだ名前

            LV = int.Parse(PHPLoadTest.LoadLV);
            MAXHP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);//DBから読み込んだものをint型に変換
            HP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            AT = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);//DBから読み込んだものをint型に変換
            DEF = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);//DBから読み込んだものをint型に変換

            STLV = LV.ToString();    //GameObjectに入れるためにいったんstringに変換
            STHP = HP.ToString();
            STMAXHP = MAXHP.ToString();
            STAT = AT.ToString();
            STDEF = DEF.ToString();

            UINAME.GetComponent<Text>().text = PlayerNAME;   //表示させるためにGameObjectにstring型を入れる
            UILV.GetComponent<Text>().text = STLV;
            UIHP.GetComponent<Text>().text = STHP;
            UIMAXHP.GetComponent<Text>().text = STMAXHP;
            UIAT.GetComponent<Text>().text = STAT;
            UIDEF.GetComponent<Text>().text = STDEF;

    }

        // Start is called before the first frame update
        void Start()
        {  /*     
                PlayerNAME　= PHPLoadTest.LoadNAME;   //DBから読み込んだ名前

                LV          = int.Parse(PHPLoadTest.LoadLV);
                MAXHP       = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);//DBから読み込んだものをint型に変換
                HP          = MAXHP;
                AT          = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);//DBから読み込んだものをint型に変換
                DEF         = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);//DBから読み込んだものをint型に変換

                STLV    = LV.ToString();    //GameObjectに入れるためにいったんstringに変換
                STHP    = HP.ToString();
                STMAXHP = MAXHP.ToString();
                STAT    = AT.ToString();
                STDEF   = DEF.ToString();

                UINAME.GetComponent<Text>().text    = PlayerNAME;   //表示させるためにGameObjectにstring型を入れる
                UILV.GetComponent<Text>().text      = STLV;
                UIHP.GetComponent<Text>().text      = STHP;
                UIMAXHP.GetComponent<Text>().text   = STMAXHP;
                UIAT.GetComponent<Text>().text      = STAT;
                UIDEF.GetComponent<Text>().text     = STDEF;
                */
                UICanvas.SetActive(false);
        }



        // Update is called once per frame
        void Update()
        {
        
        }
    }
