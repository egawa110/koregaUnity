using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    public string SceneName; //移動したいシーン名
    public AudioSource audioSource; //ボタンクリック効果音

    IEnumerator Scene()//効果音が鳴ってからシーン変更
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneName); //シーン移動

    }

    public void ChengeScene()
    {
        audioSource.Play();
        StartCoroutine(Scene());
        Time.timeScale = 1;

    }
}
