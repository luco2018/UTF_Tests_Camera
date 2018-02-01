using UnityEngine;

public class DynamicCulling_SkinnedMeshRenderer : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform spawnPoints;
    private int count = 0;
    private Vector3 offset = Vector3.zero;
    public int noOfitem = 10;
    public float spacing = 0.2f;
    public int maxNoOfSpheres = 100;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(count < maxNoOfSpheres)
        {
            if (count % noOfitem == 0)
            {
                offset.z += spacing;
                offset.x = 0;
            }
            else
            {
                offset.x += (count - Mathf.Floor(count / noOfitem) * noOfitem) * spacing * 0.5f;
            }
            Instantiate(enemy, spawnPoints.position + offset, spawnPoints.rotation);
            count++;
        }

    }
}
