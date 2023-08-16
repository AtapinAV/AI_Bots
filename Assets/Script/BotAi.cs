using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;

public class BotAi : MonoBehaviour
{
    [SerializeField]
    private ConfigUnit _configUnit;
    [SerializeField] private GameObject _botEnemy;
    [SerializeField] private float _radius;
    [SerializeField, ReadOnly] private float _dist;
    [SerializeField, ReadOnly] protected float _hp;

    private int _idleTriggerHach = Animator.StringToHash("Idle");
    private int _sprintTriggerHach = Animator.StringToHash("Sprint");
    private int _attackTriggerHach = Animator.StringToHash("Attack");

    NavMeshAgent _nMA;

    private void Start()
    {
        _hp = _configUnit.GetHeal;
        _nMA = GetComponent<NavMeshAgent>();
        _nMA.speed = _configUnit.GetMovespeed;
    }

    private void Update()
    {
        _dist = Vector3.Distance(_botEnemy.transform.position, transform.position);
        if(_dist > _radius)
        {
            _nMA.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger(_idleTriggerHach);
        }

        else
        {
            _nMA.enabled = true;
            _nMA.SetDestination(_botEnemy.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger(_sprintTriggerHach);
        }

        if (_dist < 2)
        {
            gameObject.GetComponent<Animator>().SetTrigger(_attackTriggerHach);
        }
        if(_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sword"))
        {
            _hp -= _configUnit.GetStrongdamage;
        }
        if (other.CompareTag("Sword2"))
        {
            _hp -= _configUnit.GetWeakdamage;
        }
    }
}