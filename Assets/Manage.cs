using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // เปลี่ยนไปยัง Scene ที่ 2 (GameScene)
        SceneManager.LoadScene("SampleScene");
    }
}
