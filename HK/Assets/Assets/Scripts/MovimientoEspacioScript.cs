
using UnityEngine;
using System.Collections;

/// <summary>
/// Comportamiento del cohete
/// </summary>
public class MovimientoEspacioScript : MonoBehaviour {
	
	/// La velocidad del personaje
	public Vector2 velocidad = new Vector2(5, 0);
	
	// Guardamos el movimiento
	private Vector2 movimiento;
	float forwardSpeed = 70f;
	
	private Animator animator;
	private bool moveLeft;
	private bool moveRight;
	
	void Start()
	{
		animator = GetComponent<Animator> ();
	}
	
	/// <summary>
	/// Se ejecuta en cada frame del juego (fps)
	/// </summary>
	void Update()
	{
		// Recibimos la informacion del eje X, Y segun presionamos el teclado
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// Movemos segun la direccion
		movimiento = new Vector2(
			velocidad.x * inputX,
			velocidad.y * inputY);
		if(moveLeft && !moveRight){
			GetComponent<Rigidbody2D>().AddForce(Vector3.left*forwardSpeed);
			transform.localScale = new Vector3(-15,20,1);
			animator.SetInteger ("animWalkState", 1);
			
		}
		if(moveRight && !moveLeft){
			GetComponent<Rigidbody2D>().AddForce(Vector2.right*forwardSpeed);
			transform.localScale = new Vector3(15,20,1);
			animator.SetInteger ("animWalkState", 1);
		}
		
		//		if (Input.GetKey ("right")) {
		//			transform.localScale = new Vector3(-15,20,1);
		//		} else if (Input.GetKey ("left")) {
		//			transform.localScale = new Vector3(15,20,1);
		//		}
		
		
	}
	
	public void MoveMeLeft(){
		moveLeft = true;
	}
	public void MoveMeRight(){
		moveRight=true;
		
		//transform.localScale = new Vector3(0,20,1);
	}
	public void StopMeLeft(){
		moveLeft = false;
		animator.SetInteger ("animWalkState", 0);
		GetComponent<Rigidbody2D>().Sleep();
		
		//transform.localScale = new Vector3(0,20,1);
	}
	public void StopMeRight(){
		moveRight = false;
		animator.SetInteger ("animWalkState",0);
		GetComponent<Rigidbody2D>().Sleep ();
		
	}
	
	/// <summary>
	/// Igual que update pero se ejectua por cada frame fijo, se utiliza cuando trabajas con fisicas
	/// </summary>
	/// 
	void FixedUpdate()
	{
		//Movemos el cohete en el juego
		//GetComponent<Rigidbody2D>().velocity = movimiento;
		if (movimiento.x != 0) {
			animator.SetInteger ("animWalkState", 1);
		} else {
			animator.SetInteger ("animWalkState", 0);
		}
	}
	
	/// <summary>
	/// Se ejecuta una vez se crea el objeto, es el constructor en poo
	/// </summary>
	void Awake()
	{
	}
	
	/// <summary>
	/// Se ejecuta despues de Awake, la diferencia es que solo se ejecuta si el script esta activo
	/// </summary>
	
	
	/// <summary>
	/// Se ejecuta cuando se destruye el objeto, aqui puedes colocar codigo final si fuese necesario
	/// </summary>
	void Destroy()
	{
	}
	
	/// <summary>
	/// Se ejecuta cuando hay una colision con un objeto colisionador
	/// </summary>
	void OnCollisionEnter2D(Collision2D colision)
	{
	}
	
	/// <summary>
	/// Se ejecuta cuando el objeto colisionador dejo de colisionar
	/// </summary>
	void OnCollisionExit2D(Collision2D colision)
	{
	}
	
	/// <summary>
	/// Se ejecuta cuando hay una colision con un objeto colisionador marcado como Trigger (Disparador)
	/// </summary>
	void OnTriggerEnter2D(Collider2D colisionador)
	{
	}
	
	/// <summary>
	/// Se ejecuta cuando el objeto colisionador marcado como Trigger (disparador) dejo de colisionar
	/// </summary>
	void OnTriggerExit2D(Collider2D colisionador)
	{
	}
}
