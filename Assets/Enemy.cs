using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 100;
    public int damage = 100;
    public float speed = 2f;

    void Update()
    {
        if (hp > 0)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            hp -= damage;   
            Destroy(other.gameObject);
        }
    }

}