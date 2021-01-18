using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

	public GameObject who; //объект у которого вызывается ф-я
	public string funcName = "MoveUp"; //имя ф-ии 

	bool pressing = false; //флаг признак того, что кнопка зажимается

	public void Down(){
		pressing = true; //устанавливаем флаг
	}

	public void Up(){
		pressing = false; //сбрасываем флаг
	}
		
	void Update () {
		if ( pressing == true ){
			who.SendMessage( funcName ); //если кнопка сейчас зажата, то вызываем ф-ю
		}
	}
}
