using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using static UnityEditor.PlayerSettings;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Rigidbody associated with conveyer belt.
    [SerializeField]  
    private Rigidbody rgb;

    //  Velocity of the conveyer belt.
    [SerializeField]
    private float velocity;

    //  Conveyer Belt Material.
    [SerializeField]
    private Material material;

    // Local direction does this push objects.
    [SerializeField]
    private RelativeDirection direction;

    //  Relative direction to face from a local transform.
    public enum RelativeDirection
    {
        //Up,
        //Down,
        Left,
        Right,
        Forward,
        Backward
    }

    // List of GameObject on the belt.
    [SerializeField]
    private List<GameObject> onBelt;

    private void Start()
    {
        // Accessing the Rigidbody component of the GameObject this script is attached to.
        rgb = GetComponent<Rigidbody>();
        // Enable gravity and kinematic for the Rigidbody.
        rgb.useGravity = true;
        rgb.isKinematic= true;

        // Apply Conveyer Belt Material onto GameObjects.
        GetComponent<Renderer>().material = material;
    }
    void Update()
    {
        if (direction == RelativeDirection.Forward)
        {
            Debug.Log("Forward");
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetVector("_Direction", new Vector2(0f, -1.0f));
            rend.material.SetFloat("_Rotation", 180.0f);
        }
        if (direction == RelativeDirection.Backward)
        {
            Debug.Log("Backward");
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetVector("_Direction", new Vector2(0f, 1.0f));
            rend.material.SetFloat("_Rotation", 180.0f);
        }
        if (direction == RelativeDirection.Right)
        {
            Debug.Log("Right");
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetVector("_Direction", new Vector2(0f, -1.0f));
            rend.material.SetFloat("_Rotation", 90.0f);
        }
        if (direction == RelativeDirection.Left)
        {
            Debug.Log("Left");
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetVector("_Direction", new Vector2(0f, 1.0f));
            rend.material.SetFloat("_Rotation", 90.0f);
        }
    }
        public void OnCollisionStay(Collision other)
    {
        if (other.rigidbody)
        {
            // Calculate the movement direction and speed.
            Vector3 movement = velocity * GetDirection() * Time.deltaTime;

            // Move the other Rigidbody's position based on the calculated movement
            other.rigidbody.MovePosition(other.transform.position + movement);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Add GameObjects to the list when it enters teh collison.
        onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        //Remove GameObjects from the list when it leaves the collision.
        onBelt.Remove(collision.gameObject);
    }
    public Vector3 GetDirection()
    {
        //Switch to different transform based to "RelativeDirection".
        switch (this.direction)
        {
            //case RelativeDirection.Up:
                //return transform.up;
            //case RelativeDirection.Down:
                //return -transform.up;
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
    ///Summary///
    ///This conveyer belt script is created throguh using reference from muultiple conveyer belt scrips found in Youtube.

    ///List Storage || 3D Conveyor Belts Tutorial for Unity | 2023 Update///
    ///I refer their "OnCollisionEnter" and "OnCollisionExit" for the GameObjects to add and remove from the list.
    ///This function is added so that the developer would know what is on the conveyer belt throguh the Inspector instead of looking at the scene itself.

    ///Conveyer Belt Transform Direction & Collisions || Conveyer Belts Explained///
    ///I refer their "GetDirection" functions to have multipe option of how the conveyer belt will move.
    ///I refer their "OnCollisionStay" for the GameObjects to move.
}
