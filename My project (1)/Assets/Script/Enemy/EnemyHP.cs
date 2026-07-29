using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class EnemyHP : MonoBehaviour
{
    public Enemy enemy;
    public Player player;
    //å¯â âπ
    AudioSource audioSource;
    public AudioClip damagesound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!enemy.invincible)
        {
            if (other.CompareTag("LightAttack"))
            {
                enemy.enemyhp -= DamageCalculator.AttackDamage;
                Debug.Log("ìGÇ…ÇPÇOÉ_ÉÅÅ[ÉWó^Ç¶ÇΩ");
                audioSource.PlayOneShot(damagesound);//å¯â âπ

            }
            else if (other.CompareTag("StrongAttack"))
            {
                enemy.enemyhp -= DamageCalculator.AttackDamage;
                Debug.Log("ìGÇ…ÇQÇOÉ_ÉÅÅ[ÉWó^Ç¶ÇΩ");
                audioSource.PlayOneShot(damagesound);//å¯â âπ

            }
        }
    }
}
