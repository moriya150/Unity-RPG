using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// �퓬��ʂŃX�e�[�^�X��\��������
public class NameUI : MonoBehaviour
{
        public string PlayerNAME;   
        
        // �v�Z���邽�߂�int�ɕϊ�
        public static int LV;
        public static int HP;
        public static int MAXHP;
        public static int AT;
        public static int DEF;

        // GameObject�ɓ���邽�߂ɂ�������string�ɕϊ�
        public string STLV;
        public string STHP;
        public string STMAXHP;
        public string STAT;
        public string STDEF;

        // �G���[��h�����߂ɑ��̃X�N���v�g�ɂ킽���p�̕ϐ�
        public static string StaticSTLV;
        public static string StaticSTHP;
        public static string StaticSTMAXHP;
        public static string StaticSTAT;
        public static string StaticSTDEF;

        // ��ʂɕ\�����邽�߂�GameObject
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
            // �퓬�J�n�{�^���p�l���̃I�t
            BTSTARTPanel.SetActive(false);

            UICanvas.SetActive(true);
            UIEnemyCanvas.SetActive(true);

            // DB����ǂݍ��񂾖��O
            PlayerNAME = PHPLoadTest.LoadNAME;

            // DB����ǂݍ��񂾂��̂�int�^�ɕϊ�
            LV = int.Parse(PHPLoadTest.LoadLV);
            MAXHP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            HP    = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            AT    = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);
            DEF   = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);

            // GameObject�ɓ���邽�߂ɂ�������string�ɕϊ�
            STLV = LV.ToString();
            STHP    = HP.ToString();
            STMAXHP = MAXHP.ToString();
            STAT    = AT.ToString();
            STDEF   = DEF.ToString();

            // update���̉e���Ő�ɒl�����Ƃ�  
            StaticSTHP = HP.ToString();

            // �\�������邽�߂�GameObject��string�^������
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
            // �����͔�\��
            UICanvas.SetActive(false);
            UIEnemyCanvas.SetActive(false);
        }



        // Update is called once per frame
        void Update()
        {   
            UIHP.GetComponent<Text>().text = StaticSTHP;
        }
    }
