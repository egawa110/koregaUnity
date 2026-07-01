using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtom : MonoBehaviour
{
    public string SceneName; //移動したいシーン名

    private void Start()
    {
        Application.targetFrameRate = 50;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneName); //シーン移動
        Time.timeScale = 1;

    }
}
