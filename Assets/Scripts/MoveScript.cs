using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(2,2);
	public Vector2 direction = new Vector2(-1, 0);
	private Vector2 movement;
    // Update is called once per frame
    void Update()
    {

		movement = new Vector2(
		speed.x * direction.x,
		speed.y * direction.y);
    }
	void FixedUpdate()
{
	GetComponent<Rigidbody2D>().velocity = movement;
}
}
