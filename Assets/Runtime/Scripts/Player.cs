using UnityEngine;


public class Player : MonoBehaviour
{
    private Movement movement;
    private Rigidbody2D rig;

    public AtributtsMovement atributtsMovement;

    private void Start()
    {
        movement = new();
        rig = GetComponent<Rigidbody2D>();
        movement.Atributts = atributtsMovement;
    }

    private void Update()
    {
        int plyer = (int)Input.GetAxis("Horizontal");
        
        movement.MoveObject(plyer, rig);

    }

}
