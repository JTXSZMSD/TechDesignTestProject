using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_1_buttons_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject button_continue_active;
    [SerializeField]
    private GameObject button_continue_not_active;

    public static bool button_activated;

    private void Start()
    {
        button_activated = false;
    }

    void Update()
    {
        if (Coin_moveset.motion_is_finished && button_activated)
        {
            button_continue_active.SetActive(true);
            button_continue_not_active.SetActive(false);
        }
    }

}
