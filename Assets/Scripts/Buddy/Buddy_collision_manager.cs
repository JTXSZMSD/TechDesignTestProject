using UnityEngine;

public class Buddy_collision_manager : MonoBehaviour
{
    private Animator anim;
    private Buddy_moveset ms;

    void Start()
    {
        anim = GetComponent<Animator>();
        ms = GetComponent<Buddy_moveset>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            anim.SetBool("Is_finished", true);
            ms.enabled = false;
        }
    }
}
