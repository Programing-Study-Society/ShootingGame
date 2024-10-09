using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelect : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void setDifficulty()
    {
        //buttonの名前["Easy","Nomal","Hard","Master"]
        //文字列返還で難易度に対応
        gameManager.StartGame(button.name.Replace("Button",""));
        Debug.Log(button.gameObject.name + "was clicked");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
