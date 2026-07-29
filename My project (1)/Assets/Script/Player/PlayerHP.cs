using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public Player player;
    public HPBar hpb;
    private const int abyssdamage = 10;  //奈落に落ちた時のダメージ
    //効果音
    AudioSource audioSource;
    public AudioClip damagesound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //ThrustEnemyの攻撃
        if (other.CompareTag("ThrustAttack")) 
        {
            player.hp -= ThrustEnemy.power;
            audioSource.PlayOneShot(damagesound);//効果音

        }
        //TacklEnemyの攻撃
        if (other.CompareTag("TacklAttack")) 
        {
            player.hp -= TacklEnemy.power;
            audioSource.PlayOneShot(damagesound);//効果音

        }
        //BulletEnemyの攻撃
        if (other.CompareTag("BulletAttack")) 
        {
            player.hp -= BulletEnemy.power;
            audioSource.PlayOneShot(damagesound);//効果音

        }
        //BOSSの攻撃
        if (other.CompareTag("BossThrust")) 
        {
            player.hp -= BossEnemy.thrust_power;
            audioSource.PlayOneShot(damagesound);//効果音

        }
        if (other.CompareTag("BossAround")) 
        {
            player.hp -= BossEnemy.around_power;
            audioSource.PlayOneShot(damagesound);//効果音

        }

        if (other.CompareTag("Abyss"))
        {
            player.abyssflag = true;
            if (player.hp != 0) //プレイヤーが生きている時
            {
                player.hp -= abyssdamage; //奈落ダメージ
                Debug.Log("１０ダメージ受けた");
                //hpb.HPbar(player.hp);//HPバーにダメージを反映

            }
        }

    }

    private void Update()
    {
        hpb.HPbar(player.hp);//HPバーにダメージを反映

    }
}
