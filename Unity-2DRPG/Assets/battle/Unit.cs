using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int hp;
    public int hpMax = 100;
    public int at;

    // Start is called before the first frame update
    void Start()
    {
        hp = hpMax;
        at = 10;
    }

    public void OnDamage(int _damage)
    {
        hp -= _damage;
        Debug.Log(hp);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
