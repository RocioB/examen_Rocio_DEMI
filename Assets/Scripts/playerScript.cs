using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public int moveForce=100; //Fuerza horizontal al mover
	public int maxSpeed=50; //Velocidad maxima horizontal


	

	
	// Update is called once per frame
	void Update () {
		


			
			
				if (Input.GetKey ("a")) { //cuando se pulsa a se mueva a la izquierda
						mover (moveForce * -1); //multiplicamos negativo para ir a la izquierda
						
				}
				if (Input.GetKey ("d")) { //si se pulsa d se mueve a la derecha
						mover (moveForce);
						
				}
		}
		void mover(int fuerza) {
			// creamos una variable para guardar la velocidad actual
			float velocity = rigidbody2D.velocity.x;
			//Mathf.abs nos devuelve el valor absoluto de una variable
			//Si hacemos Mathf.Abs (-10) nos devuelve 10 / -30=30
			if ((fuerza > 0 & velocity < 0) || (fuerza < 0 & velocity > 0))
				rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			if (Mathf.Abs (velocity) < maxSpeed)
				//si la velocidad absoluta es menos de maxSpeed
				//aplicamos una fuerza horizontal
				rigidbody2D.AddForce (new Vector2 (fuerza, 0)); //tambien funciona escribiendo rigidbody2D.AddForce(Vector2.right*fuerza);
		}

			}