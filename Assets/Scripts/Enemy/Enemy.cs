using System.Numerics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector2 velocity = new Vector2(5,0); //velocidade nos eixos x e y (x, y)
    public bool isFacingRight = true;
    public RigidBody2D rb;


    private void Awake() {
        rb = GetComponent<RigidBody2D>();
    }
    private void Update() {
        if(isFacingRight)
    }

}
