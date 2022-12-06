using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 敵のステータスなどを管理
public class UnitEnemy : MonoBehaviour
{  
    public static int Enemyhp = 30;
    public static int EnemyhpMax = 30;
    public static int Enemyat = 10;
    public static int Enemydef = 5;

    public string STEnemyNAME;
    public string STEnemyHP     = Enemyhp.ToString();
    public string STEnemyHPMAX  = EnemyhpMax.ToString();

    public static string staticSTEnemyHP;
    public static string staticSTEnemyHPMAX;

    // UIに表示する用
    public GameObject UIEnemyNAME;
    public GameObject UIEnemyHP ;
    public GameObject UIEnemyHPMAX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 敵の名前とHPとMAXHPを表示
    public void BTSTART_UIEnemy()
    {
        Enemyhp = int.Parse(PHPEnemyLoad.LoadEnemyHP);
        EnemyhpMax = int.Parse(PHPEnemyLoad.LoadEnemyHP);
        Enemyat = int.Parse(PHPEnemyLoad.LoadEnemyAT);
        Enemydef = int.Parse(PHPEnemyLoad.LoadEnemyDEF);

        STEnemyNAME = PHPEnemyLoad.LoadEnemyNAME;
        STEnemyHP = Enemyhp.ToString();
        STEnemyHPMAX = EnemyhpMax.ToString();

        staticSTEnemyHP = Enemyhp.ToString();

        UIEnemyNAME.GetComponent<Text>().text   = STEnemyNAME;
        UIEnemyHP.GetComponent<Text>().text     = STEnemyHP;
        UIEnemyHPMAX.GetComponent<Text>().text  = STEnemyHPMAX;

        Debug.Log(Enemyhp);
        Debug.Log(Enemyat);
        Debug.Log(Enemydef);
    }

    public void EnemyAttack()
    {
        int BaseDamege = 0;

        BaseDamege = (Enemyat) - (Unit.Playerdef);

        if (BaseDamege > 0)
        {
            Unit.Playerhp -= BaseDamege;
            NameUI.StaticSTHP = Unit.Playerhp.ToString();
        }
        else
        {
            BaseDamege = 1;
            Unit.Playerhp -= BaseDamege;
            NameUI.StaticSTHP = Unit.Playerhp.ToString();
        }

        if (Unit.Playerhp <= 0)
        {
            Unit.Playerhp = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UIEnemyHP.GetComponent<Text>().text = staticSTEnemyHP;
    }
}