using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtom : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 50;
    }

    public void NextScene()
    {
        int done = PlayerPrefs.GetInt("TutorialDone", 0);

        if (done == 0)
        {
            SceneManager.LoadScene("StoryScene");

        }
        else
        {
            SceneManager.LoadScene("Menu");

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
