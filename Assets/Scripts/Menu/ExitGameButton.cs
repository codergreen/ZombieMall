using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitGameButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Material buttonMaterial;

	public void OnPointerEnter( PointerEventData eventData ){
		buttonMaterial.color = Color.red;

	}

	public void OnPointerExit( PointerEventData eventData ){
		buttonMaterial.color = Color.white;
	}

	public void OnClick( ){
		Application.Quit();
	}
}
