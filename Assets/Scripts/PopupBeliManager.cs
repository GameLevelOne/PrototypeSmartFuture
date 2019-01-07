using UnityEngine.UI;
using UnityEngine;

public class PopupBeliManager : MonoBehaviour {

	public Image imageFormTitle;
	public Sprite[] sprTypes;

	public void ButtonTypeOnClick(int index)
	{
		imageFormTitle.sprite = sprTypes[index];
	}
}
