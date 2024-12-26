using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CastomButton : MonoBehaviour
{
    [HideInInspector]public Text castomAttack;
    [HideInInspector]public Text castomMaxHP;
    [HideInInspector]public Text castomSpeed;
    [HideInInspector]public Text castomRightClickAvilityNumber;
    [HideInInspector]public Text castomQAvilityNumber;
    public List<Text> castomTextList;
    // Start is called before the first frame update
    void Start()
    {
        // castomAttack = GlovalValue.attack;
        // castomMaxHP = GlovalValue.MaxHP;
        // castomSpeed = GlovalValue.speed;
        // castomRightClickAvilityNumber = GlovalValue.rightClickAvilityNumber;
        // castomQAvilityNumber = GlovalValue.qAvilityNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextChenge(){
        castomTextList[0].text = castomAttack.ToString() + "%";

    }
    public void AttackChengeButton(bool flag){
        if(flag){
            GlovalValue.attack++;
        }else{
            GlovalValue.attack--;
        }
        castomAttack.text = "攻撃力:" + GlovalValue.attack.ToString() + "%";
    }

    public void MaxHPChengeButton(bool flag){
        if(flag){
            GlovalValue.MaxHP++;
        }else{
            GlovalValue.MaxHP--;
        }
        castomMaxHP.text = "HP:" + GlovalValue.MaxHP.ToString() + "%";
    }

    public void SpeedChengeButton(bool flag){
        if(flag){
            GlovalValue.speed++;
        }else{
            GlovalValue.speed--;
        }
        castomSpeed.text = "速さ:" + GlovalValue.speed.ToString() + "%";
    }

    public void RightClickAvilityNumberChengeButton(){
        if(GlovalValue.rightClickAvilityNumber == 2){
            GlovalValue.rightClickAvilityNumber = 1;
            castomRightClickAvilityNumber.text = "レーザー";
        }else{
            GlovalValue.rightClickAvilityNumber = 2;
            castomRightClickAvilityNumber.text = "ミサイル";
        }
    }
}
