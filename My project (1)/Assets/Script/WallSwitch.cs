using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    public GameObject[] DisappearWalls; //消える壁の配列
    //効果音
    AudioSource audioSource;
    public AudioClip switchsound;

    void Start()
    {
        //効果音
        audioSource = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject DWall in DisappearWalls) //スイッチを踏んでいる間消える壁
            {
                DWall.SetActive(false);
                audioSource.PlayOneShot(switchsound);//効果音

            }

        }
    }
}
