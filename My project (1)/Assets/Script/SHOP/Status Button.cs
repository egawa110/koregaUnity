using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusButton : MonoBehaviour
{
    public static int shop_hp;
    public static int shop_strongPower;
    public static int shop_lightPower;
    const int max_status = 1000;

    public static int hp_price = 100;
    public static int stp_price = 100;
    public static int lgp_price = 100;

    public TMP_Text[] hpText;
    public TMP_Text[] strongPowerText;
    public TMP_Text[] lightPowerText;

    public TMP_Text[] hp_priceText;
    public TMP_Text[] stp_priceText;
    public TMP_Text[] lgp_priceText;

    public AudioSource audioSource; //ボタンクリック効果音

    IEnumerator s1()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        if (Money_text.money >= hp_price &&
            shop_hp < max_status)
        {
            shop_hp += 10;
            Money_text.money -= hp_price;
            hp_price += 10;

        }

    }
    IEnumerator s2()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        if (Money_text.money >= stp_price &&
            shop_strongPower < max_status)
        {
            shop_strongPower += 10;
            Money_text.money -= stp_price;
            stp_price += 50;

        }
    }
    IEnumerator s3()//効果音が鳴ってから
    {
        yield return new WaitForSeconds(0.3f);
        if (Money_text.money >= lgp_price &&
            shop_lightPower < max_status)
        {
            shop_lightPower += 10;
            Money_text.money -= lgp_price;
            lgp_price += 20;

        }
    }

    public void Status_hp()
    {
        audioSource.Play();
        StartCoroutine(s1());

    }

    public void Status_strongpower()
    {
        audioSource.Play();
        StartCoroutine(s2());


    }

    public void Status_lightpower()
    {
        audioSource.Play();
        StartCoroutine(s3());

    }

    private void Update()
    {
        //強化
        foreach (var hp in hpText)
        {
            hp.text = "体力　 +" + shop_hp;

        }
        foreach (var sp in strongPowerText)
        {
            sp.text = "強攻撃 +" + shop_strongPower;

        }
        foreach (var lp in lightPowerText)
        {
            lp.text = "弱攻撃 +" + shop_lightPower;

        }
        //値段
        foreach (var hp in hp_priceText)
        {
            hp.text = "値段：" + hp_price;

        }
        foreach (var sp in stp_priceText)
        {
            sp.text = "値段：" + stp_price;

        }
        foreach (var lp in lgp_priceText)
        {
            lp.text = "値段：" + lgp_price;

        }


    }

}
