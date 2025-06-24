using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneAkhir : MonoBehaviour
{
    public Image hasilGambar;
    public Sprite bagusSprite;
    public Sprite cukupSprite;
    public Sprite gagalSprite;

    void Start()
    {
        int skor = ScoreManager.Instance.score;

        if (skor == 5)
        {
            hasilGambar.sprite = bagusSprite;
        }
        else if (skor >= 3)
        {
            hasilGambar.sprite = cukupSprite;
        }
        else
        {
            hasilGambar.sprite = gagalSprite;
        }
    }

    public void UlangiQuiz()
    {
        ScoreManager.Instance.ResetSkor();
        SceneManager.LoadScene("quiz 1"); // Ganti dengan nama scene pertama kamu
    }
}
