using UnityEngine;

public class Buddy_collision_manager : MonoBehaviour
{
    private Animator anim;
    private Buddy_moveset ms;

    private AudioSource audio;

    void Start()
    {
        anim = GetComponent<Animator>();
        ms = GetComponent<Buddy_moveset>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            anim.SetBool("Is_finished", true);
            ms.enabled = false;
            Invoke("audio_enable", 0.5f);
        }
    }

    private void audio_enable()
    {
        audio.enabled = true;
    }
}
