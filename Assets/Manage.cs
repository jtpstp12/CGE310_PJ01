using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // ����¹��ѧ Scene ��� 2 (GameScene)
        SceneManager.LoadScene("SampleScene");
    }
}
