using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CastomButton : MonoBehaviour
{
    public Text castomAttack;
    public Text castomMaxHP;
    public Text castomSpeed;
    public Text castomRightClickAvilityNumber;
    public Text castomQAvilityNumber;

    public Text castomBarrierTime;

    // Start is called before the first frame update
    void Start()
    {
        ChengeText();
    }

    public void ChengeText(){
        castomAttack.text = "攻撃力:" + (GlovalValue.attack * 10).ToString() + "%";
        castomMaxHP.text = "HP:" + GlovalValue.MaxHP.ToString();
        castomSpeed.text = "速さ:" + (GlovalValue.speed * 10).ToString() + "%";
        
        if(GlovalValue.rightClickAvilityNumber == 1){
            castomRightClickAvilityNumber.text = "バリア";
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 10).ToString() + "%";
        }else{
            castomRightClickAvilityNumber.text = "防御用ボム";
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 0.1).ToString() + "秒増";
        }
        
        if(GlovalValue.qAvilityNumber == 1){
            castomQAvilityNumber.text = "レーザー";
        }else{
            castomQAvilityNumber.text = "ミサイル";
        }
        
    }
    public void AttackChengeButton(bool flag){//アタックをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            GlovalValue.attack++;
        }else{
            if(GlovalValue.attack > 0){
                GlovalValue.attack--;
            }
        }
        castomAttack.text = "攻撃力:" + (GlovalValue.attack * 10).ToString() + "%";
    }

    public void MaxHPChengeButton(bool flag){//HPをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            GlovalValue.MaxHP++;
        }else{
            if(GlovalValue.MaxHP > 1){
                GlovalValue.MaxHP--;
            }
        }
        castomMaxHP.text = "HP:" + GlovalValue.MaxHP.ToString();
    }

    public void SpeedChengeButton(bool flag){//スピードをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            GlovalValue.speed++;
        }else{
            if(GlovalValue.speed > -10){
                GlovalValue.speed--;
            }
        }
        castomSpeed.text = "速さ:" + (GlovalValue.speed * 10).ToString() + "%";
    }

    public void RightClickAvilityNumberChengeButton(){//RightClickAvilityを変更する
        if(GlovalValue.rightClickAvilityNumber == 2){
            GlovalValue.rightClickAvilityNumber = 1;
            castomRightClickAvilityNumber.text = "バリア";
        }else{
            GlovalValue.rightClickAvilityNumber = 2;
            castomRightClickAvilityNumber.text = "防御用ボム";
        }
    }

    public void QAvilityNumberChengeButton(){//QAvilityを変更する
        if(GlovalValue.qAvilityNumber == 2){
            GlovalValue.qAvilityNumber = 1;
            castomQAvilityNumber.text = "レーザー";
        }else{
            GlovalValue.qAvilityNumber = 2;
            castomQAvilityNumber.text = "ミサイル";
        }
    }

    public void BarrierTimeChengeButton(bool flag){
        if(flag){
            GlovalValue.barrierTime++;
        }else{
            GlovalValue.barrierTime--;
        }

        if(GlovalValue.rightClickAvilityNumber == 1){
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 10).ToString() + "%";
        }else{
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 0.1).ToString() + "秒増";
        }
    }
}
