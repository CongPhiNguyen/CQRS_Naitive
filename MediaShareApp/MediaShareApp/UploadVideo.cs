using MediaShareApp.SQLHandler.SQL_Write;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaShareApp
{
	public partial class UploadVideo : Form
	{
		String imageLoc;
		public UploadVideo()
		{
			InitializeComponent();
			pbPic.SizeMode = PictureBoxSizeMode.Zoom;
			imageLoc = null;
		}

		private void btBrowse_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dlg = new OpenFileDialog();
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					imageLoc = dlg.FileName.ToString();
					pbPic.ImageLocation = imageLoc;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		bool checkCorrectForm()
		{
			if (tbName.Text.Length == 0 || imageLoc == null)
			{
				return false;
			}
			else return true;
		}
		private void btUpload_Click_1(object sender, EventArgs e)
		{
			bool k = checkCorrectForm();
			if(k==false)
			{
				MessageBox.Show("Your must fill all the form");
				return;
			}	
			try
			{
				byte[] img = null;
				FileStream fs = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
				BinaryReader br = new BinaryReader(fs);
				img = br.ReadBytes((int)fs.Length);
				SQL_Write sql = new SQL_Write();
				sql.insertPic(tbName.Text, img);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

//private void btGetPic_Click(object sender, EventArgs e)
//{
//	sqltest sql = new sqltest();
//	pics = sql.getPic();
//	if (pics.Count > 0)
//	{
//		MemoryStream ms = new MemoryStream(pics[0]);
//		pbShowPic.Image = Image.FromStream(ms);
//		index = 0;
//	}
//	else
//	{
//		pbShowPic.Image = null;
//	}

//}
