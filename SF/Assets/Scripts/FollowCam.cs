﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
<<<<<<< HEAD
    public Transform _player;        // 따라다닐 타겟 오브젝트의 Transform
    private Transform _camera;                // 카메라 자신의 Transform

    void Start()
    {
        _camera = GetComponent<Transform>();
=======
    public Transform Player; // 따라다닐 타겟 오브젝트의 Transform
    private Transform Camera; // 카메라 자신의 Transform

    void Start()
    {
        Camera = GetComponent<Transform>();
>>>>>>> Seo
    }

    void LateUpdate()
    {
<<<<<<< HEAD
        _camera.position = new Vector3(_player.position.x - 0.52f, _camera.position.y , _player.position.z - 6.56f);

        _camera.LookAt(_player);
=======
        Camera.position = new Vector3(Player.position.x - 0.52f, Camera.position.y , Player.position.z - 6.56f);

        Camera.LookAt(Player);
>>>>>>> Seo
    }
}

