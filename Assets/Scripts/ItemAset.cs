using UnityEngine;
using UnityEngine.UI;

public class ItemAset : MonoBehaviour {

	public Text textName;
	public Text textJumlah;
	public Button buttonJual;

	void Enable()
	{
		buttonJual.onClick.AddListener( ()=> ButtonJualOnClick() );
	}

	public void UpdateContent(string name, int jumlah)
	{
		textName.text = name;
		textJumlah.text = jumlah.ToString("{0:C}");
	}

	public void ButtonJualOnClick()
	{

	}
}
