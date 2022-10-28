using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public int hp;
    public int hpMax = 100;
    public int at;

    public Slider HPSlider;

    // Start is called before the first frame update
    void Start()
    {
        hp = hpMax;
        HPSlider.maxValue = hpMax;
        HPSlider.value = hpMax;
        at = 10;
    }

    


    public void OnDamage(int _damage)
    {
        hp -= _damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        HPSlider.value = hp;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
