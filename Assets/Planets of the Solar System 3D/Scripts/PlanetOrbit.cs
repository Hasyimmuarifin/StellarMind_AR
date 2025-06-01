using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform orbitCenter;     // Biasanya Matahari
    public float orbitRadius = 5f;    // Jarak ke Matahari
    public float orbitSpeed = 10f;    // Kecepatan mengelilingi
    public float rotationSpeed = 30f; // Rotasi di poros sendiri (opsional)

    private float angle;

    void Update()
    {
        // Mengorbit
        angle += orbitSpeed * Time.deltaTime;
        float rad = angle * Mathf.Deg2Rad;
        float x = Mathf.Cos(rad) * orbitRadius;
        float z = Mathf.Sin(rad) * orbitRadius;

        transform.position = orbitCenter.position + new Vector3(x, 0, z);

        // Rotasi planet itu sendiri
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}