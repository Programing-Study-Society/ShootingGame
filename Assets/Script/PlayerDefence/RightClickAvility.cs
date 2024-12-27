using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightClickAvility : MonoBehaviour
{
    public Slider slider;
    public Text timeText;

    public List<GameObject> avirityList;

    public int avirityNumber;

    public GameObject atkObj1;

    // Start is called before the first frame update
    void Start()
    {
        if(avirityNumber == 1){
            slider.maxValue = 3.0f + ((float)(GlovalValue.barrierTime * 0.1) * 3.0f);
        }else if(avirityNumber == 2){
           slider.maxValue = 1;
        }
        
        avirityNumber = GlovalValue.rightClickAvilityNumber;
        slider.value = slider.maxValue;
    }

    void Update(){
        if(GlovalValue.pauseFlag){
            return;
        }

        if(avirityNumber == 1){
            BarrierAvility();
        }else if(avirityNumber == 2){
            BommAvility();
        }
        
    }

    public void BarrierAvility(){
        if (Input.GetMouseButton(1)){
            if(slider.value > 0){
                slider.value -= Time.deltaTime;
                avirityList[0].SetActive(true);
            }else{
                avirityList[0].SetActive(false);
            }
        }else{
            if(slider.value <= slider.maxValue){
                slider.value += Time.deltaTime / 10;
            }
            avirityList[0].SetActive(false);
        }
        timeText.text = "バリア：" + slider.value.ToString("f1");
    }

    public void BommAvility(){
        if (Input.GetMouseButton(1)){
            if(slider.value >= slider.maxValue){
                AttackInstant(avirityList[1]);
                slider.value = 0;
            }else{
                if(slider.value <= slider.maxValue){
                    slider.value += Time.deltaTime / 5;
                }
            }
        }else{
            if(slider.value <= slider.maxValue){
                slider.value += Time.deltaTime / 5;
            }
        }

        float onLaser = slider.value * (100 / slider.maxValue);
        timeText.text = "ボム：" + onLaser.ToString("f1") + "%";
    }
    private void AttackInstant(GameObject Attack){
         //攻撃オブジェクト生成
        atkObj1 = Instantiate(Attack, transform.position, transform.rotation);
        //攻撃オブジェクト生成初期位置値
        atkObj1.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
    }
}
