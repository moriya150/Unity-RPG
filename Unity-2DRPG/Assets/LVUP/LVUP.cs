using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVUP : MonoBehaviour
{
    public int LVUP変数 = 1;
    public int LVUP倍数 = 100;

    

    void LVUPP()
    {
        LVUP変数 = int.Parse(PHPLoad.LoadLV);

        if (BattleMainSystem.ALLEXP >= LVUP変数 * LVUP倍数) 
        {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
