using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //ポーズ画面
    public GameObject Pause;
    private bool isVisible = false;

    //タイマーとかHPとか
    public GameObject TimePanel;
    public Text TimeText;
    private float TimeCount;
    //所持金とアイテム
    public Text Money_Text;
    public Text potion1_Text;
    public Text potion2_Text;
    public Text potion3_Text;

    //ゴール時
    public GameObject GoalPanel;
    public Text GoalTime;
    //プレイヤー死亡時
    public GameObject DethPanel;
    private bool isplayd = false;
    //効果音
    AudioSource audioSource;
    public AudioClip moneysound;
    public AudioClip dethsound;

    public GoalManager goal;
    public Player player;
    void Start()
    {
        TimeCount = 0f;
        //効果音
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        var current = Keyboard.current;  //現在のキーボード情報
        if (current == null) return;     //キーボード接続チェック

        var escKey = current.escapeKey;  //Wキーの入力状態取得

        //UIパネル
        if (!goal.isGoal)
        {
            //タイマー
            TimeCount += Time.deltaTime;
            TimeText.text = "Time : " + TimeCount. ToString ("F1");
            //所持金
            Money_Text.text = "G:" + Money_text.money;
            if (Money_text.oldmoney != Money_text.money)
            {
                Money_text.oldmoney = Money_text.money;
                audioSource.PlayOneShot(moneysound);//効果音

            }
            //回復薬
            potion1_Text.text = "×" + HealButton.potion1;
            potion2_Text.text = "×" + HealButton.potion2;
            potion3_Text.text = "×" + HealButton.potion3;

        }

        //ポーズ画面
        if (escKey.wasPressedThisFrame)
        {
            isVisible = !isVisible;
            Pause.SetActive(isVisible);
            Time.timeScale = 0; //ポーズ画面中は時間停止

        }
        if (!isVisible)
        {
            Time.timeScale = 1;
        }

        //ゴール
        if (goal.isGoal)
        {
            GoalPanel.SetActive(true);
            TimePanel.SetActive(false);
            GoalTime.text = "クリアタイム:" + TimeCount.ToString("F1") + " 秒";
        }

        //死亡時
        if(player.PlayerDeth == true)
        {
            DethPanel.SetActive(true);
            TimePanel.SetActive(false);
            if (player.PlayerDeth == true && isplayd == false)
            {
                audioSource.PlayOneShot(dethsound);//効果音
                isplayd = true;
            }
        }
    }
}
