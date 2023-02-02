using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_MP_StatsBar : MonoBehaviour
{
    
    [SerializeField] Slider HPSlider;
    [SerializeField] Slider MPSlider;

    
    
    
    public void SetHP(float hp){
        HPSlider.value = hp;
    }

    public void SetMP(float mp){
        MPSlider.value = mp;
    }
}
