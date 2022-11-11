using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public static int Playerhp = 100;
    public static int PlayerhpMax = 400;
    public static int Playerat = 6;
    public static int Playerdef = 4;

    public Slider HPSlider;

    // Start is called before the first frame update
    void Start()
    {
       Playerhp = 100;

    }

    /*public void OnDamage(int _damage)
    {
        
        hp -= _damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        //HPSlider.value = hp;

    }*/

    public void PlayerAttack()
    {

        UnitEnemy.Enemyhp -= (Playerat) - (UnitEnemy.Enemydef);
        if (UnitEnemy.Enemyhp <= 0)
        {
            UnitEnemy.Enemyhp = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
       // Playerhp = NameUI.HP;
       // Playerat = NameUI.AT;
       // Playerdef = NameUI.DEF;
    }
}
