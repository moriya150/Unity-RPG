using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Playerのステータスなどを管理
public class Unit : MonoBehaviour
{
    // ここでは仮の数字を入力
    public static int Playerhp = 2;
    public static int PlayerhpMax = 2;
    public static int Playerat = 1;
    public static int Playerdef = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlayerAttack()
    {
        int BaseDamage = 0;
        
        BaseDamage = (Playerat) - (UnitEnemy.Enemydef);

        if (BaseDamage > 0)
        {
            UnitEnemy.Enemyhp -= BaseDamage;
            UnitEnemy.staticSTEnemyHP = UnitEnemy.Enemyhp.ToString();
        }
        else
        {
            BaseDamage = 1;
            UnitEnemy.Enemyhp -= BaseDamage;
            UnitEnemy.staticSTEnemyHP = UnitEnemy.Enemyhp.ToString();
        }

        if (UnitEnemy.Enemyhp <= 0)
        {
            UnitEnemy.Enemyhp = 0;
        }
    }

    // hpが0だとエラーが起きるので仮の数字を入力
    public void 仮Player_load()
    {
        Playerhp = 2;
        PlayerhpMax = 2;
        Playerat = 2;
        Playerdef = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
