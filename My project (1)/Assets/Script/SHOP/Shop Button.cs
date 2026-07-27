using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Threading;
using System.Collections;

public class ShopButton : MonoBehaviour
{
    public GameObject[] HealPanel;
    public GameObject[] StatusPanel;

    public static bool heal_flag;
    public static bool status_flag;

    public AudioSource audioSource; //ボタンクリック効果音

    private void Start()
    {
        heal_flag = true;
        status_flag = false;
    }
    IEnumerator heal_bgm()//効果音が鳴ってからPanel変更
    {
        yield return new WaitForSeconds(0.3f);
        heal_flag = true;
        status_flag = false;

    }
    IEnumerator status_bgm()//効果音が鳴ってからPanel変更
    {
        yield return new WaitForSeconds(0.3f);
        status_flag = true;
        heal_flag = false;

    }

    public void OpenHealPanel() //ヒールパネル
    {
        audioSource.Play();
        StartCoroutine(heal_bgm());
    }

    public void OpenStatusPanel() //ステータスパネル
    {
        audioSource.Play();
        StartCoroutine(status_bgm());
    }

    private void Update()
    {
        foreach (var hp in HealPanel)
            hp.gameObject.SetActive(heal_flag);


        foreach (var sp in StatusPanel)
            sp.gameObject.SetActive(status_flag);


    }
}
