using UnityEngine;
using UnityEngine.EventSystems; // UIイベント用
using UnityEngine.UI;           // ButtonなどUIコンポーネント用

public class Button_Action : MonoBehaviour,
      IPointerEnterHandler, IPointerExitHandler
{
    private RawImage image; //画像

    public Color normalColor = Color.white;
    public Color hoverColor = Color.yellow;

    private void Start()
    {
        image = GetComponent<RawImage>();
        image.color = normalColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("マウスを載せてる");
        image.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        image.color = normalColor;
    }
}
