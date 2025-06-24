using UnityEngine;
using Vuforia;

public class EditorSimulation : MonoBehaviour
{
    public GameObject arObject; // Drag objek AR kamu ke sini

    void Start()
    {
#if UNITY_EDITOR
        // Disable Vuforia saat testing di Editor
        var vuforia = Object.FindFirstObjectByType<VuforiaBehaviour>();
        if (vuforia != null)
        {
            vuforia.enabled = false;
        }

        // Aktifkan objek AR secara manual
        if (arObject != null)
        {
            arObject.SetActive(true);
        }
#endif
    }
}
