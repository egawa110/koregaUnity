using UnityEngine;
using System.Collections;

public class BreakWall : MonoBehaviour
{
    const int m_WallHP = 20;
    private int m_HP;
    //å¯â âπ
    AudioSource audioSource;
    public AudioClip breaksound;

    public Player player;
    void Start()
    {
        m_HP = m_WallHP;
        //å¯â âπ
        audioSource = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LightAttack"))
        {
            audioSource.PlayOneShot(breaksound);//å¯â âπ

            m_HP -= DamageCalculator.AttackDamage;
            Debug.Log("ï«Ç…ÇPÇOÉ_ÉÅÅ[ÉWó^Ç¶ÇΩ");


        }
        if (other.CompareTag("StrongAttack"))
        {
            audioSource.PlayOneShot(breaksound);//å¯â âπ

            m_HP -= DamageCalculator.AttackDamage;
            Debug.Log("ï«Ç…ÇQÇOÉ_ÉÅÅ[ÉWó^Ç¶ÇΩ");

        }
    }

    void Update()
    {
        if (m_HP <= 0)
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
