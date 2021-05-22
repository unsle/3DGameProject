using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public void Scene()
    {
        string name = gameObject.name;
        SceneManager.LoadScene(name);
    }
}
