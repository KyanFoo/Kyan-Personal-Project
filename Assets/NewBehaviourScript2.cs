using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using static UnityEditor.PlayerSettings;

public class NewBehaviourScript2 : MonoBehaviour
{
    /// <summary>
    /// Rigidbody associated with conveyer belt.
    /// /// <summary>
    [SerializeField]  
    private Rigidbody rgb;

    /// <summary>
    ///  Velocity of the conveyer belt.
    ///  /// <summary>
    [SerializeField]
    private float velocity;

    /// <summary>
    /// Local direction does this push objects.
    /// </summary>
    private RelativeDirection direction;

    /// /// <summary>
    ///  Relative direction to face from a local transform.
    /// </summary>
    public enum RelativeDirection
    {
        Up,
        Down,
        Left,
        Right,
        Forward,
        Backward
    }

    /// <summary>
    /// List of GameObject on the belt.
    /// </summary>
    [SerializeField]
    private List<GameObject> onBelt;

    private void Start()
    {
        rgb = GetComponent<Rigidbody>();
        rgb.useGravity = true;
        rgb.isKinematic= true;
    }

    public void OnCollisionStay(Collision other)
    {
        if (other.rigidbody)
        {
            Vector3 movement = velocity * GetDirection() * Time.deltaTime;
            other.rigidbody.MovePosition(other.transform.position + movement);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onBelt.Add(collision.gameObject);
    }

    // When something leaves the belt
    private void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }
    public Vector3 GetDirection()
    {
        switch (this.direction)
        {
            case RelativeDirection.Up:
                return transform.up;
            case RelativeDirection.Down:
                return -transform.up;
            case RelativeDirection.Left:
                return -transform.right;
            case RelativeDirection.Right:
                return transform.right;
            case RelativeDirection.Forward:
                return transform.forward;
            case RelativeDirection.Backward:
                return -transform.forward;
        }
        return transform.forward;
    }
}
