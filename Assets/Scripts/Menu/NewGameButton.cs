using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Material NewGameButtonMaterial;

	public void OnPointerEnter( PointerEventData eventData ){
		NewGameButtonMaterial.color = Color.red;

	}

	public void OnPointerExit( PointerEventData eventData ){
		NewGameButtonMaterial.color = Color.white;
	}

	public void OnClick(){
		NewGameButtonMaterial.color = Color.white;
		SceneManager.LoadScene ( "CharacterCreation" );
	}
}
