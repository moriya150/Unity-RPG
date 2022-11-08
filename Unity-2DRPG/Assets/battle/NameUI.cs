using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class NameUI : MonoBehaviour
{
    public Text Name;
    public int LV;
    public int HP;
    public int MAXHP;
    public int AT;
    public int DEF;
    


    // Start is called before the first frame update
    void Start()
    {
        Name = PHPLoadTest.LoadNAME;
        LV = int.Parse(PHPLoadTest.LoadLV);
        MAXHP = PHPLoadTest.LoadKISO_HP + PHPLoadTest.LoadSOUBI_HP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
