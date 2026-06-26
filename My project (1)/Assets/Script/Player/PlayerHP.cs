using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public Player player;
    public HPBar hpb;
    private const int abyssdamage = 10;  //奈落に落ちた時のダメージ

    private void OnTriggerEnter(Collider other)
    {
        //ThrustEnemyの攻撃
        if (other.CompareTag("ThrustAttack")) 
        {
            player.hp -= ThrustEnemy.power; 
        }
        //TacklEnemyの攻撃
        if (other.CompareTag("TacklAttack")) 
        {
            player.hp -= TacklEnemy.power; 
        }
        //BulletEnemyの攻撃
        if (other.CompareTag("BulletAttack")) 
        {
            player.hp -= BulletEnemy.power; 
        }
        //BOSSの攻撃
        if (other.CompareTag("BossThrust")) 
        {
            player.hp -= BossEnemy.thrust_power; 
        }
        if (other.CompareTag("BossAround")) 
        {
            player.hp -= BossEnemy.around_power; 
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
