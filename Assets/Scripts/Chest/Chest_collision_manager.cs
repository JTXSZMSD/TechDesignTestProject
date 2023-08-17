using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest_collision_manager : MonoBehaviour
{
    private Animator anim;
    private Transform tr;
    [SerializeField]
    private GameObject coin;

    private bool coin_spawned;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        tr = GetComponent<Transform>();
        coin_spawned = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.enabled = true;
            if (!coin_spawned) 
            {
                coin_spawned = true;
                Instantiate(coin, tr.position, tr.rotation);
            }
        }
    }
}
