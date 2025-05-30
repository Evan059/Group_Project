using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Fire : MonoBehaviour
{
    // Bullet speed
    private float bulletSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move bullet up
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * bulletSpeed);
        // Delete bullet when it reaches the top of the screen
        if (transform.position.y > 6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
