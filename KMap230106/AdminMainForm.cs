using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using KMap230106.HttpServer;
using System.Data;
using System;

namespace KMap230106
{

    public partial class AdminMainForm : Form
    {

        private ImageForm ImgForm = new ImageForm();
        private List<MapData> datas = new List<MapData>();
        public Httpwebrequest httprequest = new Httpwebrequest();


        public AdminMainForm()
        {
            InitializeComponent();
        }

        private async void allPrint()
        {
            LV_MarkData.Items.Clear();
            datas = await httprequest.RecData();
            if (datas != null)
            {
                foreach (MapData md in datas)
                {
                    ListViewItem item = new ListViewItem(md.id.ToString());
                    item.SubItems.Add(md.name);
                    item.SubItems.Add(md.imgName);
                    item.SubItems.Add(md.address);
                    item.SubItems.Add(md.description);
                    item.SubItems.Add(md.tag);
                    item.SubItems.Add(md.latitude.ToString());
                    item.SubItems.Add(md.longtitude.ToString());
                    LV_MarkData.Items.Add(item);
                }
            }
        }

        #region ��ư ������

        private void Btn_on()
        {
            btn_delete.Enabled = true;
            btn_update.Enabled = true;

        }
        private void Btn_off()
        {
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
        }
        private void TextBoxClear()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_imgname.Text = "";
            tb_address.Text = "";
            tb_description.Text = "";
            tb_tag.Text = "";
            tb_latitude.Text = "";
            tb_longtitude.Text =  "";
            Btn_off();
        }
        private async void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_name.Text;
                string imgname = tb_imgname.Text;
                string address = tb_address.Text;
                string description = tb_description.Text;
                string tag = tb_tag.Text;
                double lat = Double.Parse(tb_latitude.Text);
                double lng = Double.Parse(tb_longtitude.Text);
                tb_result.Text = await httprequest.CreateMarkerPost(name, imgname, address, description, tag, lat, lng);
                TextBoxClear();
                allPrint();
                tb_tureFalse.Text = "����";

            }
            catch(Exception ex )
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }
       

        }
        
        private async void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_id.Text);
                string name = tb_name.Text;
                string imgname = tb_imgname.Text;
                string address = tb_address.Text;
                string description = tb_description.Text;
                string tag = tb_tag.Text;
                double lat = Double.Parse(tb_latitude.Text);
                double lng = Double.Parse(tb_longtitude.Text);
                tb_result.Text = await httprequest.UpdateDataPost(id, name, imgname, address, description, tag, lat, lng);
                TextBoxClear();
                allPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
               
            }
  
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_id.Text);
                tb_result.Text = await httprequest.DeleteMarkerPost(id);
                TextBoxClear();
                allPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}" ,ex.ToString());
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                allPrint();
                TextBoxClear();
                tb_tureFalse.Text = "����";
            }catch(Exception ex)
            {
                MessageBox.Show("������ ������ �����߽��ϴ�..");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }

        }

        private void LV_MarkData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (LV_MarkData.FocusedItem.Index >= 0)
                {
                    int index = LV_MarkData.FocusedItem.Index;
                    tb_id.Text = datas[index].id.ToString();
                    tb_name.Text=datas[index].name.ToString(); ;
                    tb_imgname.Text = datas[index].imgName.ToString();
                    tb_address.Text= datas[index].address.ToString();
                    tb_description.Text = datas[index].description.ToString();
                    tb_tag.Text = datas[index].tag.ToString();
                    tb_latitude.Text = datas[index].latitude.ToString();
                    tb_longtitude.Text = datas[index].longtitude.ToString();
                    Btn_on();   //��ư Ȱ��ȭ ������Ʈ�� �������
                    ImgForm.ImageLord(tb_imgname.Text = datas[index].imgName.ToString());
                }


                tb_tureFalse.Text = "����";

            }
            catch (Exception ex)
            {
                MessageBox.Show("�̹����� �ùٸ��� �ʽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }

        }
        #endregion

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            ImgForm.StartPosition = FormStartPosition.Manual;
            ImgForm.Location = new Point(120,10);
            ImgForm.Show();
            ImgForm.Focus();
        }
    }
}