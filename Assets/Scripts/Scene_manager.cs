using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene_manager : MonoBehaviour
{
    public void Change_scene(string scene_name) 
    { 
        SceneManager.LoadScene(scene_name); 
    }
}
