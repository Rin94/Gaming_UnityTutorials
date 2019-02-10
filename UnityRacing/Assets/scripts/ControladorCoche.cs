using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCoche : MonoBehaviour {

	public GameObject goCarretera;
	public MotorPrincipal motorScript;

	public GameObject goCoche;
	public Coche cocheScript;

	public float anguloDeGiro;//
	public float velocidad;//velocidad de desplaze de izquierda, derecha
    public Rigidbody2D rb;
    



	// Use this for initialization
	void Start () {
        //goCarretera = GameObject.Find ("MotorCarreteras");
        //motorScript = goCarretera.GetComponent<MotorPrincipal> ();
        //velocidad = motorScript.velociad;
        GameObject ob = GameObject.Find("Azul");
        rb = ob.GetComponent<Rigidbody2D>();
		goCoche = GameObject.FindObjectOfType<Coche> ().gameObject;
		cocheScript = goCoche.GetComponent<Coche> ();
		velocidad = 15;
		anguloDeGiro = 45;




		
	}

    // Update is called once per frame

	public void Update () {
        /*try{
			
		float giroZ = 0;
		transform.Translate
		(Vector2.right * Input.GetAxis ("Horizontal")*velocidad*Time.deltaTime);

		//quaternion euler, convierte valores decimales a grados
		giroZ=Input.GetAxis("Horizontal")*anguloDeGiro*-1;
		goCoche.transform.rotation = Quaternion.Euler (0,0,giroZ);
		}
		catch {
		}
		*/

        TouchMove();

	}

    public void TouchMove(){
        if (Input.touchCount>0){
            Touch touch = Input.GetTouch(0);
            float middle = Screen.width / 2;
            if(touch.position.x<middle&& touch.phase == TouchPhase.Began){
                MoveIzquierda();
            }
            if (touch.position.x > middle && touch.phase == TouchPhase.Began)
            {
                MoveDerecha();
            }
        }
    }



    public void MoveDerecha(){
        try
        {
            rb.velocity = new Vector2(velocidad, 0);

        }
        catch{
        }
    }

    public void MoveIzquierda()
    {
        try
        {

            //#float giroZ = 0;
            //transform.Translate
            //       (-1*Vector2.right * velocidad * Time.deltaTime);
            //goCoche.transform.Translate(-1 * Vector2.right * velocidad * Time.deltaTime);

            rb.velocity = new Vector2(-velocidad, 0);

            //quaternion euler, convierte valores decimales a grados
            //giroZ = anguloDeGiro * -1;
            //goCoche.transform.rotation = Quaternion.Euler(0, 0, giroZ);
        }
        catch
        {
        }
    }

    public void setVelocity(){
        try{
            rb.velocity = Vector2.zero;
        }
        catch{

        }

    }

}
