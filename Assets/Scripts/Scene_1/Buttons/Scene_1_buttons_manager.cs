using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_1_buttons_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject button_continue_active;
    [SerializeField]
    private GameObject button_continue_not_active;

    private bool button_activeted;
    void Start()
    {
        button_activeted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Coin_moveset.motion_is_finished && !button_activeted)
        {
            button_continue_active.SetActive(true);
            button_continue_not_active.SetActive(false);
            button_activeted = true;
        }
    }
}
