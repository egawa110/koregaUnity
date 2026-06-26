using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryText : MonoBehaviour
{
    public TMP_Text messageText;
    [TextArea(2, 5)]
    public string[] sentences; // 文章リスト
    int index = 0;
    public string SceneName; //移動したいシーン名

    void Start()
    {
        messageText.text = sentences[index];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            index++;

            if (index < sentences.Length)
            {
                messageText.text = sentences[index];
            }
            else
            {
                SceneManager.LoadScene(SceneName); //シーン移動
            }
        }
    }
}
