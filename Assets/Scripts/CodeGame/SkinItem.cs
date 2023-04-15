using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinItem : MonoBehaviour
{
    private bool isUnlock;
    
    public GameObject lockObj;
    public Image iconImage;
    public TextMeshProUGUI state;

    
    public void UnChoose()
    {
        if (isUnlock)
        {
            state.SetText("Select");
        }
        else
            state.SetText("100 <sprite=0>");
    }
    
    public void Init(Sprite sprite,bool isLock)
    {
        
    }


    public void Unlock()
    {
        isUnlock = true;
        lockObj.SetActive(false);
    }
    
    public void Choose()
    {
        state.SetText("Choose");
    }
}
