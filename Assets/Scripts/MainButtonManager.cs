using UnityEngine;
using UnityEngine.UI;

public class MainButtonManager : MonoBehaviour {
	
	//0 = Overview
	//1 = Pemasukan
	//2 = Pengeluaran
	//3 = Aset
	public GameManager gameManager;
	public Button[] buttons;
	
	void Start()
	{
		ButtonMainOnClick(0);
	}

	public void ButtonMainOnClick(int index){
		for(int i = 0;i < buttons.Length;i++){
			if(i == index) buttons[i].interactable = false;
			else buttons[i].interactable = true;

			//show corresponding panel
			gameManager.ShowPanelMain(index);
		}
	}

	
}
