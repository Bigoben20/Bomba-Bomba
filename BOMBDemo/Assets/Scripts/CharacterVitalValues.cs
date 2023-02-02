using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVitalValues : MonoBehaviour
{   
    
    public float HealtPoint = 100f;
    public float MagicPoint = 100f;
    
    public HP_MP_StatsBar statsBar;
    

    public bool revive;

    public void HeroicReborn(){
        HealtPoint = 100f;
        MagicPoint = 100f;
        HPChanger();
        MPChanger();


    }
    
    public void HPChanger(){
        statsBar.SetHP(HealtPoint);
        
    }
    public void MPChanger(){
        statsBar.SetMP(MagicPoint);
        
    }
    public void GetHit(float hp){
        HealtPoint -=hp;
        HPChanger();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Debug.Log("hitted");
            GetHit(20f);
            
        }
        
        if(HealtPoint<=0){
            HeroicReborn();
        }
        

    }

    
    
    
}
