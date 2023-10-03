using System;
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
        _direction = direction;
        rigidbody2D.velocity = Velocity * direction * Vector2.right;
    }

    /// <summary>
    /// Move Object based a direction in X axis/>
    /// </summary>
    /// <param name="atributts"> atributts to move object </param>
    /// <param name="direction"> direction to movement in X</param>
    /// <param name="rigidbody2D"> rigidi body of the object </param>
    public void MoveObject(AtributtsMovement atributts, int direction, Rigidbody2D rigidbody2D)
    {
        Atributts = atributts;
        MoveObject(direction, rigidbody2D);
    }

    private int _direction = 0;
    private float _velocity = 0;

    /// <summary>
    /// Returns the current const movement velocity
    /// </summary>
    public float Velocity
    {
        get
        {
            _velocity = _direction == 0 ? _velocity -= Atributts.acceleration * Time.deltaTime : _velocity += Atributts.acceleration * Time.deltaTime;
            _velocity = Math.Clamp(_velocity, 0, Atributts.maxVelocity);
            return _velocity;
        }
    }
}
