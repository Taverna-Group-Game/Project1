using UnityEngine;


public class Player : MonoBehaviour
{
    public Vector2 DirectionInput;
    public float Speed;
    private Rigidbody2D rig;


    private void Awake()
    {
        
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        
    }


}
