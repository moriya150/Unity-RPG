using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVUP : MonoBehaviour
{
    public int LVUP�ϐ� = 1;
    public int LVUP�{�� = 100;

    

    void LVUPP()
    {
        LVUP�ϐ� = int.Parse(PHPLoad.LoadLV);

        if (BattleMainSystem.ALLEXP >= LVUP�ϐ� * LVUP�{��) 
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
