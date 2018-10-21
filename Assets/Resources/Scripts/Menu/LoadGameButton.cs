using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoadGameButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Material LoadGameButtonMaterial;

	public void OnPointerEnter( PointerEventData eventData ){
		LoadGameButtonMaterial.color = Color.red;

	}

	public void OnPointerExit( PointerEventData eventData ){
		LoadGameButtonMaterial.color = Color.white;
	}
}
