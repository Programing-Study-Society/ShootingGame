using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QClickLaser : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private List<GameObject> Attack;

    [SerializeField, Header("レーダーオブジェクト")]
    public GameObject radar;
    public EnemyCollision radarEnemyCollision;

    public int attackNumber;

    public Slider slider;
    public Text timeText;

    public List<GameObject> colList;

    //攻撃オブジェクト生成用オブジェクト
    private GameObject atkObj1;

    private float oneHundred;

    // Start is called before the first frame update
    void Start()
    {
        attackNumber = GlovalValue.qAvilityNumber;
        slider.value = 0.0f;
        oneHundred = 100 / slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(attackNumber == 1){
            Raser();
        }
        else if(attackNumber == 2){
            Missile();
        }
    }

    public void Raser(){
        if(slider.value >= slider.maxValue){
            PressAttackControl();
        }else{
            if(slider.value <= slider.maxValue){
                slider.value += Time.deltaTime;
            }
        }
        float onLaser = slider.value * oneHundred;
        timeText.text = "レーザー:" + onLaser.ToString("f1") + "%"; 
    }

    public void Missile(){
        if(slider.value >= slider.maxValue){
            PressRadar();
            MissileAttackControl();
        }else{
            if(slider.value <= slider.maxValue){
                slider.value += Time.deltaTime;
            }
        }
        float onLaser = slider.value * oneHundred;
        timeText.text = "ミサイル:" + onLaser.ToString("f1") + "%"; 
    }

    private void PressRadar()
    {
        // Qクリックされたとき実行
        if (Input.GetKey (KeyCode.Q))
        {
            radar.SetActive(true);
        }
        else{
            radar.SetActive(false);
        }
    }

    //Qが押されたとき実行
    private void PressAttackControl()
    {
        // Qクリックされたとき実行
        if (Input.GetKeyDown (KeyCode.Q))
        {
            AttackInstant(attackNumber,transform);
            slider.value = 0.0f;
        }
    }

    //Qが離されたとき実行
    private void MissileAttackControl()
    {
        // Qクリックされたとき実行
        if (Input.GetKeyUp (KeyCode.Q))
        {
            for(int i = 0; i < radarEnemyCollision.colList.Count; i++){
                if (radarEnemyCollision.colList[i] != null){
                    AttackInstant(attackNumber,transform); 

                    Vector3 dir = radarEnemyCollision.colList[i].transform.position - atkObj1.transform.position;
                    atkObj1.transform.rotation = Quaternion.FromToRotation(atkObj1.transform.up, dir);

                    MissileAttack missileAttack = atkObj1.GetComponent<MissileAttack>();
                    missileAttack.searchEnemyNumber = i;
                    missileAttack.SearchObject = radarEnemyCollision.colList[i];
                }
            }
            radarEnemyCollision.colList.Clear();
            slider.value = 0.0f;
        }
    }

    private void AttackInstant(int attackNumber, Transform tf){
         //攻撃オブジェクト生成
        atkObj1 = Instantiate(Attack[attackNumber - 1], tf.position, tf.rotation);
        //攻撃オブジェクト生成初期位置値
        atkObj1.transform.position = tf.position +
            new Vector3(0f, tf.lossyScale.y / 2.0f, 0f);
    }
}
