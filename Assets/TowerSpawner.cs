using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-3f, 3f);

            Vector3 positie = new Vector3(x, y, 0f);

            Instantiate(towerPrefab, positie, Quaternion.identity);
        }
    }
}