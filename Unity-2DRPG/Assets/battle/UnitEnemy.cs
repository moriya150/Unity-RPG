using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitEnemy : MonoBehaviour
{
    public static int Enemyhp = 100;
    public static int EnemyhpMax = 100;
    public static int Enemyat = 10;
    public static int Enemydef = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void EnemyAttack()
    {

        Unit.Playerhp -= (Enemyat)- (Unit.Playerdef);
        if (Unit.Playerhp <= 0)
        {
            Unit.Playerhp = 0;
        }
        //NameUI.STHP = Unit.Playerhp.ToString();
       // NameUI.UIHP.GetComponent<Text>().text = NameUI.STHP;
    }


    // Update is called once per frame
    void Update()
    {
        //Enemyhp = NameUI.HP;
       // Enemyat = NameUI.AT;
    }
}