using UnityEngine;

public class OrbitSystemGenerator : MonoBehaviour
{
    public Material orbitMaterial;
    public int segments = 100;

    [System.Serializable]
    public class PlanetOrbit
    {
        public string name;
        public float radius;
        public float tilt;
    }

    public PlanetOrbit[] orbits;

    void Start()
    {
        foreach (var orbit in orbits)
        {
            GameObject orbitObj = new GameObject("Orbit_" + orbit.name);
            orbitObj.transform.parent = this.transform;
            LineRenderer lr = orbitObj.AddComponent<LineRenderer>();
            lr.material = orbitMaterial;
            lr.widthMultiplier = 0.03f;
            lr.loop = true;
            lr.useWorldSpace = false;
            lr.positionCount = segments;

            Quaternion tiltRot = Quaternion.Euler(orbit.tilt, 0, 0);
            for (int i = 0; i < segments; i++)
            {
                float angle = (360f / segments) * i * Mathf.Deg2Rad;
                float x = Mathf.Cos(angle) * orbit.radius;
                float z = Mathf.Sin(angle) * orbit.radius;
                Vector3 pos = tiltRot * new Vector3(x, 0, z);
                lr.SetPosition(i, pos);
            }
        }
    }
}