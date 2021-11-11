using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Rock : MonoBehaviour
{
    public enum RockState { Idle, Thrown, HitSomething }
    public GameObject Parent;
    public Rigidbody RigidBody;
    public SphereCollider Collider;

    public UnityAction OnRockDestroyed = delegate { };
    public UnityAction<Rock> OnRockShot = delegate { };

    public RockState State { get { return _state; } }
    private RockState _state;

    private float _minVelocity = 0.05f;
    private bool _flagDestroy = false;

    public float _splashRadius = 1.5f;

    public virtual void OnTap()
    {
        //Do nothing
    }

    void OnDestroy()
    {
        if (_state == RockState.Thrown || _state == RockState.HitSomething)
            OnRockDestroyed();
    }

    void OnCollisionEnter(Collision col)
    {
        _state = RockState.HitSomething;
        //Tambahan agar ada efek explosion damage, tapi sebenarnya langsung meremove object saja
        if (_splashRadius > 0)
        {
           // GameController.Instance.ExplodeAt(transform.position, _splashRadius);
        }
    }

    void Start()
    {
        Collider.enabled = false;
        _state = RockState.Idle;
    }

    void FixedUpdate()
    {
        if (_state == RockState.Idle &&
            RigidBody.velocity.sqrMagnitude >= _minVelocity)
        {
            _state = RockState.Thrown;
        }

        if ((_state == RockState.Thrown || _state == RockState.HitSomething) &&
            RigidBody.velocity.sqrMagnitude < _minVelocity &&
            !_flagDestroy)
        {
            //Hancurkan gameobject setelah 2 detik
            //jika kecepatannya sudah kurang dari batas minimum
            _flagDestroy = true;
            StartCoroutine(DestroyAfter(2));
        }

    }

    private IEnumerator DestroyAfter(float second)
    {
        yield return new WaitForSeconds(second);
        Destroy(gameObject);
    }

    public void MoveTo(Vector3 target, GameObject parent)
    {
        gameObject.transform.SetParent(parent.transform);
        gameObject.transform.position = target;
    }

    public void Shoot(Vector3 velocity, float distance, float speed)
    {
        Collider.enabled = true;
        RigidBody.velocity = velocity * speed * distance;
        OnRockShot(this);
    }


}
