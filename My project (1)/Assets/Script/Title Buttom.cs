using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleButtom : MonoBehaviour
{
    public AudioSource audioSource; //ボタンクリック効果音

    private void Start()
    {
        Application.targetFrameRate = 50;
    }
    IEnumerator done0_Scene()//効果音が鳴ってからシーン変更
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("StoryScene");

    }
    IEnumerator done1_Scene()//効果音が鳴ってからシーン変更
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");

    }

    public void NextScene()
    {
        int done = PlayerPrefs.GetInt("TutorialDone", 0);
        audioSource.Play();

        if (done == 0)
        {
            StartCoroutine(done0_Scene());
        }
        else
        {
            StartCoroutine(done1_Scene());
        }
        Debug.Log(done);

        Time.timeScale = 1;
    }

    public void FinishTutorial()
    {
        PlayerPrefs.SetInt("TutorialDone", 1);
        PlayerPrefs.Save();
    }
}
