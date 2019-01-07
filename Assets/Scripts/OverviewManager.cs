using UnityEngine;
using UnityEngine.UI;

public class OverviewManager : MonoBehaviour {
	[HeaderAttribute("Content")]
	public Text textName;
	public Text textMeja;
	public Text textHartaBersih;
	public Text textKas;
	public Text textGaji;

	int profit;

	[HeaderAttribute("Other Reference")]
	public PemasukanManager pemasukanManager;
	public PengeluaranManager pengeluaranManager;

	public void UpdateContent()
	{
		int totalPemasukan = pemasukanManager.totalPemasukan;
		int totalPengeluaran = pengeluaranManager.totalPengeluaran;

		profit = totalPemasukan - totalPengeluaran;
		textGaji.text = profit.ToString();

	}

	public void ButtonGajianOnClick()
	{
		
	}

	public void ButtonBeliOnClick()
	{

	}

	public void ButtonBayarOnClick()
	{

	}

	public void ButtonPinjamOnClick()
	{
		
	}
}
