using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_2_buttons_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject button_active;
    [SerializeField]
    private GameObject button_not_active;

    private bool button_activeted;
    void Start()
    {
        button_activeted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Monster_click_receiver.event_is_done && Knight_click_receiver.event_is_done && !button_activeted)
        {
            button_active.SetActive(true);
            button_not_active.SetActive(false);
            button_activeted = true;
        }
    }
}
