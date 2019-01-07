using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject[] mainPanels;

	public OverviewManager overviewManager;
	public PemasukanManager pemasukanManager;
	public PengeluaranManager pengeluaranManager;
	public AsetManager asetManager;	

	public bool isPHK = false;

	

	public void ButtonPHKOnClick(bool phk)
	{
		isPHK = phk;
	}

	public void ShowPanelMain(int index)
	{
		for(int i = 0; i < mainPanels.Length;i++){
			if(i == index) mainPanels[i].SetActive(true);
			else mainPanels[i].SetActive(false);
		}

		// if( index == 0) overviewManager.UpdateContent();
		// else if(index == 1) pemasukanManager.UpdateContent();
		// else if(index == 2) pengeluaranManager.UpdateContent();
		// else if(index == 3) asetManager.UpdateContent();

	}

	
}
