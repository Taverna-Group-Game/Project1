using UnityEngine;

public class Movement
{
    /// <summary>
    /// Current Object Atributts
    /// </summary>
    public AtributtsMovement Atributts { private get; set; }

    /// <summary>
    /// Move Object based a direction in X axis/>
    /// </summary>
    /// <param name="direction"> direction to movement in X</param>
    /// <param name="rigidbody2D"> rigidi body of the object </param>
    public void MoveObject(int direction, Rigidbody2D rigidbody2D)
    {
        rigidbody2D.velocity = Atributts.velocity * direction * Vector2.right;
    }

    /// <summary>
    /// Move Object based a direction in X axis/>
    /// </summary>
    /// <param name="atributts"> atributts to move object </param>
    /// <param name="direction"> direction to movement in X</param>
    /// <param name="rigidbody2D"> rigidi body of the object </param>
    public void MoveObject(AtributtsMovement atributts, int direction, Rigidbody2D rigidbody2D)
    {
        rigidbody2D.velocity = atributts.velocity * direction * Vector2.right;
    }
}
