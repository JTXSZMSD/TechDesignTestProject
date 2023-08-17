using UnityEngine;
using UnityEngine.EventSystems;

public class Buddy_click_receiver : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;
    private Buddy_moveset ms;
    private bool event_is_done;
    

    private void Start()
    {
        
        anim = GetComponent<Animator>();
        ms = GetComponent<Buddy_moveset>();
        event_is_done = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!event_is_done) 
        {
            anim.SetBool("Click_received", true);
            event_is_done=true;
            ms.enabled = true;
        }
    }
}
