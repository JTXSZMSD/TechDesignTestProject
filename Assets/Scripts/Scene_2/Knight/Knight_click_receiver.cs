using UnityEngine;
using UnityEngine.EventSystems;

public class Knight_click_receiver : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;
    
    public static bool event_is_done;


    private void Start()
    {

        anim = GetComponent<Animator>();
        event_is_done = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!event_is_done)
        {
            anim.Play("buff");
            event_is_done = true;
        }
    }
}
