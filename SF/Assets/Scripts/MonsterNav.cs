using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterNav : MonoBehaviour
{
    private Transform _monster;
    private Transform _player;
    private UnityEngine.AI.NavMeshAgent nvAgent;

    private Rigidbody monsterRigidbody;
    public float rotateSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        monsterRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _monster = gameObject.GetComponent<Transform>();
        _player = GameObject.FindWithTag("Player").GetComponent<Transform>();

        nvAgent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

        nvAgent.destination = _player.position;

        _monster.rotation = Quaternion.LookRotation(_player.position - _monster.position);
    }
}
