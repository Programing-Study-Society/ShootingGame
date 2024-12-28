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
    public Text statasPointText;

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
        StatasPoint();
    }
    public void AttackChengeButton(bool flag){//アタックをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            if(NotStatasUp()){
                return;
            }
            GlovalValue.attack++;
        }else{
            if(GlovalValue.attack > 0){
                GlovalValue.attack--;
                GlovalValue.addStatasPoint--;
            }
        }
        castomAttack.text = "攻撃力:" + (GlovalValue.attack * 10).ToString() + "%";
        StatasPoint();
    }

    public void MaxHPChengeButton(bool flag){//HPをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            if(NotStatasUp()){
                return;
            }
            GlovalValue.MaxHP++;
        }else{
            if(GlovalValue.MaxHP > 1){
                GlovalValue.MaxHP--;
                GlovalValue.addStatasPoint--;
            }
        }
        castomMaxHP.text = "HP:" + GlovalValue.MaxHP.ToString();
        StatasPoint();
    }

    public void SpeedChengeButton(bool flag){//スピードをflagがfalseなら1下げるtrueなら1あげる
        if(flag){
            if(NotStatasUp()){
                return;
            }
            GlovalValue.speed++;
        }else{
            if(GlovalValue.speed > -10){
                GlovalValue.speed--;
                GlovalValue.addStatasPoint--;
            }
        }
        castomSpeed.text = "速さ:" + (GlovalValue.speed * 10).ToString() + "%";
        StatasPoint();
    }

    public void RightClickAvilityNumberChengeButton(){//RightClickAvilityを変更する
        if(GlovalValue.rightClickAvilityNumber == 2){
            GlovalValue.rightClickAvilityNumber = 1;
            castomRightClickAvilityNumber.text = "バリア";
        }else{
            GlovalValue.rightClickAvilityNumber = 2;
            castomRightClickAvilityNumber.text = "防御用ボム";
        }
        if(GlovalValue.rightClickAvilityNumber == 1){
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 10).ToString() + "%";
        }else{
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 0.1).ToString() + "秒増";
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
            if(NotStatasUp()){
                return;
            }
            GlovalValue.barrierTime++;
        }else{
            if(GlovalValue.barrierTime < 1){
                return;
            }
            GlovalValue.barrierTime--;
            GlovalValue.addStatasPoint--;
        }

        if(GlovalValue.rightClickAvilityNumber == 1){
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 10).ToString() + "%";
        }else{
            castomBarrierTime.text = "継続時間:" + (GlovalValue.barrierTime * 0.1).ToString() + "秒増";
        }
        StatasPoint();
    }

    public bool NotStatasUp(){
        if(GlovalValue.addStatasPoint + 1 > GlovalValue.playerLevel){
            return true;
        }else{
            GlovalValue.addStatasPoint++;
            return false;
        }
    }
    public void StatasPoint(){
        statasPointText.text = ((GlovalValue.playerLevel) - GlovalValue.addStatasPoint).ToString();
    }
}
