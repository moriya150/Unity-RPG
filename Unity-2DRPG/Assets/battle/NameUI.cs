using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 戦闘画面でステータスを表示させる
public class NameUI : MonoBehaviour
{
        public string PlayerNAME;   
        
        // 計算するためにintに変換
        public static int LV;
        public static int HP;
        public static int MAXHP;
        public static int AT;
        public static int DEF;

        // GameObjectに入れるためにいったんstringに変換
        public string STLV;
        public string STHP;
        public string STMAXHP;
        public string STAT;
        public string STDEF;

        // エラーを防ぐために他のスクリプトにわたす用の変数
        public static string StaticSTLV;
        public static string StaticSTHP;
        public static string StaticSTMAXHP;
        public static string StaticSTAT;
        public static string StaticSTDEF;

        // 画面に表示するためのGameObject
        public GameObject UINAME;
        public GameObject UILV;
        public GameObject UIHP;
        public GameObject UIMAXHP;
        public GameObject UIAT;
        public GameObject UIDEF;

        public GameObject BTSTARTPanel;
        public GameObject UICanvas;
        public GameObject UIEnemyCanvas;

        public void BTSTART()
        {
            // 戦闘開始ボタンパネルのオフ
            BTSTARTPanel.SetActive(false);

            UICanvas.SetActive(true);
            UIEnemyCanvas.SetActive(true);

            // DBから読み込んだ名前
            PlayerNAME = PHPLoadTest.LoadNAME;

            // DBから読み込んだものをint型に変換
            LV = int.Parse(PHPLoadTest.LoadLV);
            MAXHP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            HP    = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            AT    = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);
            DEF   = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);

            // GameObjectに入れるためにいったんstringに変換
            STLV = LV.ToString();
            STHP    = HP.ToString();
            STMAXHP = MAXHP.ToString();
            STAT    = AT.ToString();
            STDEF   = DEF.ToString();

            // update文の影響で先に値を入れとく  
            StaticSTHP = HP.ToString();

            // 表示させるためにGameObjectにstring型を入れる
            UINAME.GetComponent<Text>().text    = PlayerNAME;   
            UILV.GetComponent<Text>().text      = STLV;
            UIHP.GetComponent<Text>().text      = STHP;
            UIMAXHP.GetComponent<Text>().text   = STMAXHP;
            UIAT.GetComponent<Text>().text      = STAT;
            UIDEF.GetComponent<Text>().text     = STDEF;

            Unit.Playerhp       = HP;
            Unit.PlayerhpMax    = MAXHP;
            Unit.Playerat       = AT;
            Unit.Playerdef      = DEF;
        }

        // Start is called before the first frame update
        void Start()
        {
            // 初期は非表示
            UICanvas.SetActive(false);
            UIEnemyCanvas.SetActive(false);
        }



        // Update is called once per frame
        void Update()
        {   
            UIHP.GetComponent<Text>().text = StaticSTHP;
        }
    }
