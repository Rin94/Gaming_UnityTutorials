using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VidaScript : MonoBehaviour {
	
    public static int life = 5;
    //public TextMesh Vida;
    public Text Vida;
	
	// Use this for initialization
	public void Start () {
        //life = 5;
		NotificationCenter.DefaultCenter().AddObserver(this, "DecrementarPuntos");
		ActualizarMarcador();
	}
	
    /*
	public void DecrementarPuntos(Notification notificacion){
		//int puntosADecrementar = (int)notificacion.data;
		if (SaludScript.ps == 0) {
			life=0;
			ActualizarMarcador();
			Application.LoadLevel ("PantallaScene");

		} 
        //else {
          //  if(life==5 && puntosADecrementar<0 ){

           // }
            //else{
                //life = life - puntosADecrementar;

           // }
	//}
		ActualizarMarcador();
	}
*/
	
	public void ActualizarMarcador(){
        Vida.text = SaludScript.ps.ToString();
	}
	
	// Update is called once per frame
	public void Update () {
        if (SaludScript.ps <= 0){
            life = 0;
            ActualizarMarcador();
            Application.LoadLevel("PantallaScene");

        }
        //else {
        //  if(life==5 && puntosADecrementar<0 ){

        // }
        //else{
        //life = life - puntosADecrementar;

        // }
        //}
        ActualizarMarcador();


    }
}
