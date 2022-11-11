    using UnityEngine;
    using UnityEngine.UI;

    public class NameUI : MonoBehaviour //�퓬��ʂŃX�e�[�^�X��\��������
{
        //public static NameUI instance;

        public string PlayerNAME;   

        public static int LV;   //�v�Z���邽�߂�int�ɕϊ�
        public static int HP;
        public static int MAXHP;
        public static int AT;
        public static int DEF;

        public string STLV;     //GameObject�ɓ���邽�߂ɂ�������string�ɕϊ�
        public string STHP;
        public string STMAXHP;
        public string STAT;
        public string STDEF;

        public GameObject UINAME;  //��ʂɕ\�����邽�߂�GameObject
        public GameObject UILV;
        public GameObject UIHP;
        public GameObject UIMAXHP;
        public GameObject UIAT;
        public GameObject UIDEF;

        public GameObject BTSTARTPanel;
        public GameObject UICanvas;

        public void BTSTART()
        {
            BTSTARTPanel.SetActive(false);//�퓬�J�n�{�^���p�l���̃I�t

            UICanvas.SetActive(true);

            PlayerNAME = PHPLoadTest.LoadNAME;   //DB����ǂݍ��񂾖��O

            LV = int.Parse(PHPLoadTest.LoadLV);
            MAXHP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�
            HP = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);
            AT = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�
            DEF = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�

            STLV = LV.ToString();    //GameObject�ɓ���邽�߂ɂ�������string�ɕϊ�
            STHP = HP.ToString();
            STMAXHP = MAXHP.ToString();
            STAT = AT.ToString();
            STDEF = DEF.ToString();

            UINAME.GetComponent<Text>().text = PlayerNAME;   //�\�������邽�߂�GameObject��string�^������
            UILV.GetComponent<Text>().text = STLV;
            UIHP.GetComponent<Text>().text = STHP;
            UIMAXHP.GetComponent<Text>().text = STMAXHP;
            UIAT.GetComponent<Text>().text = STAT;
            UIDEF.GetComponent<Text>().text = STDEF;

    }

        // Start is called before the first frame update
        void Start()
        {  /*     
                PlayerNAME�@= PHPLoadTest.LoadNAME;   //DB����ǂݍ��񂾖��O

                LV          = int.Parse(PHPLoadTest.LoadLV);
                MAXHP       = int.Parse(PHPLoadTest.LoadKISO_HP) + int.Parse(PHPLoadTest.LoadSOUBI_HP);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�
                HP          = MAXHP;
                AT          = int.Parse(PHPLoadTest.LoadKISO_AT) + int.Parse(PHPLoadTest.LoadSOUBI_AT);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�
                DEF         = int.Parse(PHPLoadTest.LoadKISO_DEF) + int.Parse(PHPLoadTest.LoadSOUBI_DEF);//DB����ǂݍ��񂾂��̂�int�^�ɕϊ�

                STLV    = LV.ToString();    //GameObject�ɓ���邽�߂ɂ�������string�ɕϊ�
                STHP    = HP.ToString();
                STMAXHP = MAXHP.ToString();
                STAT    = AT.ToString();
                STDEF   = DEF.ToString();

                UINAME.GetComponent<Text>().text    = PlayerNAME;   //�\�������邽�߂�GameObject��string�^������
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
