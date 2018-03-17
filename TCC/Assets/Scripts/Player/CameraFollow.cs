using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public float xMargin = 1f; // Distance in the x axis the player can move before the camera follows.
                               //public float yMargin = 1f; // Distance in the y axis the player can move before the camera follows.
    public float xSmooth = 8f; // How smoothly the camera catches up with it's target movement in the x axis.
    public float ySmooth = 8f; // How smoothly the camera catches up with it's target movement in the y axis.
    public Vector2 maxXAndY; // The maximum x and y coordinates the camera can have.
    public Vector2 minXAndY; // The minimum x and y coordinates the camera can have.

    private Transform m_Player; // Reference to the player's transform.
    public bool fixedCamera = false;


    private void Awake()
    {
        // Setting up the reference.
        m_Player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private bool CheckXMargin()
    {
        // Returns true if the distance between the camera and the player in the x axis is greater than the x margin.
        return (( transform.position.x - m_Player.position.x < xMargin ) || (transform.position.x - m_Player.position.x > xMargin));
    }


    //private bool CheckYMargin()
    //{
    // Returns true if the distance between the camera and the player in the y axis is greater than the y margin.
    //return Mathf.Abs(transform.position.y - m_Player.position.y) > yMargin;
    //}


    private void Update()
    {
        if (!fixedCamera)
        {
            TrackPlayer();
        }
    }


    private void TrackPlayer()
    {
        // By default the target x and y coordinates of the camera are it's current x and y coordinates.
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        // If the player has moved beyond the x margin...
        if (CheckXMargin())
        {
            // ... the target x coordinate should be a Lerp between the camera's current x position and the player's current x position.
            targetX = Mathf.Lerp(transform.position.x, m_Player.position.x, xSmooth * Time.deltaTime);
        }

        // If the player has moved beyond the y margin...
        //if (CheckYMargin())
        //{
        // ... the target y coordinate should be a Lerp between the camera's current y position and the player's current y position.
        //targetY = Mathf.Lerp(transform.position.y, m_Player.position.y, ySmooth * Time.deltaTime);
        //}

        // The target x and y coordinates should not be larger than the maximum or smaller than the minimum.
        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        //targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        // Set the camera's position to the target position with the same z component.
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }

    /*
        public Transform playerTransform;
        public float minPlayerPositionX;
        public float maxPlayerPositionX;
        public float minCameraPositionX;
        public float maxCameraPositionX;

        private Transform camTransform;


        // Use this for initialization
        void Start () {

            camTransform = GetComponent<Transform> ();

        }

        // Update is called once per frame
        void Update () {

            if (playerTransform.position.x < minPlayerPositionX) {
            //	camTransform.position = new Vector3 (minCameraPositionX, camTransform.position.y, camTransform.position.z);
            }

            if (playerTransform.position.x > maxPlayerPositionX) {
                //camTransform.position = new Vector3 (maxCameraPositionX, camTransform.position.y, camTransform.position.z);
            }

            if (playerTransform.position.x >= minPlayerPositionX && playerTransform.position.x <= maxPlayerPositionX) {
                camTransform.position = Vector3.Lerp (camTransform.position, 
                    new Vector3 (playerTransform.position.x, camTransform.position.y, camTransform.position.z),
                    1f);
            }

        }
        */
}
