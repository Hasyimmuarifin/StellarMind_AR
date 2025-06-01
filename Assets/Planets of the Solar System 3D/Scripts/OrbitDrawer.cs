using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitDrawer : MonoBehaviour
{
    public int segments = 100; // Semakin banyak, semakin halus lingkarannya
    public float radius = 5f; // Radius orbit
    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.loop = true;
        line.positionCount = segments;

        DrawOrbit();
    }

    void DrawOrbit()
    {
        float angle = 0f;
        for (int i = 0; i < segments; i++)
        {
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;
            line.SetPosition(i, new Vector3(x, y, 0f));
            angle += 2 * Mathf.PI / segments;
        }
    }
}