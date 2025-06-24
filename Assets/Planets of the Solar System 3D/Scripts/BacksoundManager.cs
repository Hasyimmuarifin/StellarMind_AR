using UnityEngine;
using UnityEngine.SceneManagement;

public class BacksoundManager : MonoBehaviour
{
    private static BacksoundManager instance;
    private AudioSource audioSource;

    // Daftar nama scene yang diizinkan memiliki backsound
    private string[] quizScenes = { "quiz 1", "quiz 2", "quiz 3", "quiz 4", "quiz 5", "ending" };

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject); // Hapus duplikat jika sudah ada instance sebelumnya
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        bool shouldPlay = false;

        foreach (string quizScene in quizScenes)
        {
            if (scene.name == quizScene)
            {
                shouldPlay = true;
                break;
            }
        }

        if (shouldPlay)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
