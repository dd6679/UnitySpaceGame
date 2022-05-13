using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody bulletRigidbody;
    public GameObject Explosion;
   
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger !" + other.gameObject.name + "tag: " + other.tag);

        if (other.tag == "Player")
        {
            Debug.Log("Bullet Trigger Enter");
            Instantiate(Explosion, bulletRigidbody.position, Quaternion.identity); //충돌하면 폭발
            Destroy(Explosion, 3f);
            AsteroidController pController = other.GetComponent<AsteroidController>();
            if (pController != null) pController.Die();
        }
    }
}
