using UnityEngine;

[CreateAssetMenu(fileName = "AtributtsMovement", menuName = "Movement/Atributts")]
public class AtributtsMovement : ScriptableObject
{
    public float maxVelocity;
    public float acceleration, deceleration;
}
