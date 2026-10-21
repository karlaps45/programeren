using UnityEngine;
using System.Collections;

public class Elf : Enemy
{
   
    private Renderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 10;
        speed = 3;
        renderer = GetComponent<Renderer>();
        StartCoroutine(ToggleVisibility());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ToggleVisibility()
    {
        while (true)
        {
           
            yield return new WaitForSeconds(3f);

           
            renderer.enabled = false;

            
            yield return new WaitForSeconds(0.5f);

            
            renderer.enabled = true;
        }
    }
}
