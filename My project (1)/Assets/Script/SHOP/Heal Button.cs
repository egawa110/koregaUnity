using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealButton : MonoBehaviour
{
    public static int potion1 = 5;
    public static int potion2 = 0;
    public static int potion3 = 0;

    public const int potion1_heal = 20;
    public const int potion2_heal = 50;
    public const int potion3_heal = 100;

    public static int potion1_price = 100;
    public static int potion2_price = 500;
    public static int potion3_price = 1000;

    public TMP_Text[] have_potion1_Text;
    public TMP_Text[] have_potion2_Text;
    public TMP_Text[] have_potion3_Text;

    public TMP_Text[] potion1_priceText;
    public TMP_Text[] potion2_priceText;
    public TMP_Text[] potion3_priceText;

    public AudioSource audioSource; //ボタンクリック効果音

    void Start()
    {
    }
    IEnumerator p1()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        potion1 += 1;
        Money_text.money -= potion1_price;

    }
    IEnumerator p2()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        potion2 += 1;
        Money_text.money -= potion2_price;

    }
    IEnumerator p3()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        potion3 += 1;
        Money_text.money -= potion3_price;

    }

    public void potion1_button()
    {
        if (Money_text.money >= potion1_price)
        {
            audioSource.Play();
            StartCoroutine(p1());

        }
    }
    public void potion2_button()
    {
        if (Money_text.money >= potion2_price)
        {
            audioSource.Play();
            StartCoroutine(p2());

        }
    }

    public void potion3_button()
    {
        if (Money_text.money >= potion3_price)
        {
            audioSource.Play();
            StartCoroutine(p3());

        }
    }


    void Update()
    {
        //所持数
        foreach (var p1 in have_potion1_Text)
        {
            p1.text = "×" + potion1;

        }
        foreach (var p2 in have_potion2_Text)
        {
            p2.text = "×" + potion2;

        }
        foreach (var p3 in have_potion3_Text)
        {
            p3.text = "×" + potion3;

        }

        //値段
        foreach (var pp1 in potion1_priceText)
        {
            pp1.text = "G：" + potion1_price;

        }
        foreach (var pp2 in potion2_priceText)
        {
            pp2.text = "G：" + potion2_price;

        }
        foreach (var pp3 in potion3_priceText)
        {
            pp3.text = "G：" + potion3_price;

        }

    }
}
