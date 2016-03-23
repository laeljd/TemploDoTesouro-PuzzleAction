using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	public float velocityX;
	public float velocityY;
	public float aceleration;
	// Use this for initialization
	void Start () {
		aceleration = 20f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.S )|| Input.GetKey( KeyCode.A )||Input.GetKey( KeyCode.D )){
			if( Input.GetKey( KeyCode.W ) ){
				velocityY += aceleration*Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.S)){
				velocityY -= aceleration*Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.A)){
				velocityX -= aceleration*Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.D)){
				velocityX += aceleration*Time.deltaTime;
			}
		}else{
			if(Mathf.Abs (velocityX) > 1){
				var sign = Mathf.Sign (velocityX); 
				velocityX = sign*(Mathf.Abs(velocityX) - aceleration*Time.deltaTime);

			}else{
				velocityX = 0;
			}
			if(Mathf.Abs (velocityY) > 1){
				var sign = Mathf.Sign (velocityY); 
				velocityY= sign*(Mathf.Abs(velocityY) - aceleration*Time.deltaTime);
				
			}else{
				velocityY = 0;
			}
		}
		transform.Translate(velocityX*Time.deltaTime,velocityY*Time.deltaTime,0);
	}
}
