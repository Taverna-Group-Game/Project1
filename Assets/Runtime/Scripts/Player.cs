using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private AtributtsMovement atributtsMovement;
    
    private const string AxisHorizontal = "Horizontal";

    Movement movement;
    Rigidbody2D rig;

    // called in the fisrt freame of object
    private void Start()
    {
        movement = new();
        rig = GetComponent<Rigidbody2D>();
     
        movement.Atributts = atributtsMovement;
    }

    // called by freame
    private void Update()
    {
        movement.MoveObject((int)Input.GetAxis(AxisHorizontal), rig);
    }
}
