using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Tetap hidup di semua scene
        }
        else
        {
            Destroy(gameObject); // Cegah duplikat
        }
    }

    public void TambahSkor()
    {
        score++;
    }

    public void ResetSkor()
    {
        score = 0;
    }
}
