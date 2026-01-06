using UnityEngine;
using UnityEngine.UI;

public class Start_Game : MonoBehaviour
{
    public GameObject targetImage; // 表示したいImageオブジェクト

    public void ShowImage()
    {
        targetImage.SetActive(false); // 画像を表示
    }


}
