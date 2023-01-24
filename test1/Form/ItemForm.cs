using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using test1.Database;

namespace test1.Form
{
    public partial class ItemForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OptDataContext dataContext = new OptDataContext();

        public int code { get; set; }
        public bool IsExist { get; set; }
        public bool IsNew { get; set; }

        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }


        private void clear()
        {

            ItemDesc.Text="";
            ItemBarcode.Text = "";
            BuyPrice.EditValue = null;
            SellPrice.EditValue = null;
            SoldSellPrice.EditValue = null;
            SoldQuantity.EditValue = null;
            GroupId.EditValue = null;
            ItemTypeId.EditValue = null;
            SphStrenth.Text = "";
            CylStrenth.Text = "";
            DoubleSellPrice.EditValue = null;
            SingleSellPrice.EditValue = null;
            SignalTypeId.EditValue = null;
            BeginingBalance.EditValue = null;
            ItemISActive.Checked = true;
            
            code = 0;
            IsExist = false;
            IsNew = true;
            var Item = dataContext.Items.ToList();
            gridControl1.DataSource = Item;
            GroupId.Properties.DataSource = dataContext.Groups.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void InsertOrUpdate()
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            if (IsExist)
            {
                var i = dataContext.Items.Where(member => member.ItemId == code).FirstOrDefault();
                i.ItemDesc = ItemDesc.Text;
                i.ItemBarcode=ItemBarcode.Text;
                i.BuyPrice = Convert.ToDecimal(BuyPrice.EditValue);
                i.SellPrice = Convert.ToDecimal(SellPrice.EditValue);
                i.SoldSellPrice = Convert.ToDecimal(SoldSellPrice.EditValue);
                i.SoldQuantity = Convert.ToInt32(SoldQuantity.EditValue);
                i.GroupId = Convert.ToInt32(GroupId.EditValue);
                i.ItemTypeId = Convert.ToInt32(ItemTypeId.EditValue);
                i.SphStrenth = SphStrenth.Text;
                i.CylStrenth = CylStrenth.Text;
                i.DoubleSellPrice = Convert.ToDecimal(DoubleSellPrice.EditValue);
                i.SingleSellPrice = Convert.ToDecimal(SingleSellPrice.EditValue);
                i.SignalTypeId = Convert.ToInt32(SignalTypeId.EditValue);
                i.BeginingBalance = Convert.ToInt32(BeginingBalance.EditValue);
                i.ItemISActive = Convert.ToBoolean(ItemISActive.Checked);

                dataContext.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                clear();

            }
            else if (IsNew)
            {
                try
                {
                    Item item=new Item
                    {
                    ItemDesc = ItemDesc.Text,
                    ItemBarcode = ItemBarcode.Text,
                    BuyPrice = Convert.ToDecimal(BuyPrice.EditValue),
                    SellPrice = Convert.ToDecimal(SellPrice.EditValue),
                    SoldSellPrice = Convert.ToDecimal(SoldSellPrice.EditValue),
                    SoldQuantity = Convert.ToInt32(SoldQuantity.EditValue),
                    GroupId = Convert.ToInt32(GroupId.EditValue),
                    ItemTypeId = Convert.ToInt32(ItemTypeId.EditValue),
                    SphStrenth = SphStrenth.Text,
                    CylStrenth = CylStrenth.Text,
                    DoubleSellPrice = Convert.ToDecimal(DoubleSellPrice.EditValue),
                    SingleSellPrice = Convert.ToDecimal(SingleSellPrice.EditValue),
                    SignalTypeId = Convert.ToInt32(SignalTypeId.EditValue),
                    BeginingBalance = Convert.ToInt32(BeginingBalance.EditValue),
                    ItemISActive = Convert.ToBoolean(ItemISActive.Checked),

                };
                    dataContext.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    clear();
                }
                catch
                {
                    MessageBox.Show("من فضلك البيانات المطلوبة", "خطا");
                }


            }

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            code = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemId"));
            var i = dataContext.Items.Where(member => member.ItemId == code).FirstOrDefault();
            ItemDesc.Text = i.ItemDesc;
            ItemBarcode.Text = i.ItemBarcode;
            BuyPrice.EditValue = i.BuyPrice;
            SellPrice.EditValue = i.SellPrice;
            SoldSellPrice.EditValue = i.SoldSellPrice;
            SoldQuantity.EditValue = i.SoldQuantity;
            GroupId.EditValue = i.GroupId;
            ItemTypeId.EditValue = i.ItemTypeId;
            SphStrenth.Text = i.SphStrenth;
            CylStrenth.Text = i.CylStrenth;
            DoubleSellPrice.EditValue = i.DoubleSellPrice;
            SingleSellPrice.EditValue = i.SingleSellPrice;
            SignalTypeId.EditValue = i.SingleSellPrice;
            BeginingBalance.EditValue = i.BeginingBalance;
            ItemISActive.Checked = Convert.ToBoolean(ItemISActive); 

            IsExist = true;
            IsNew = false;
        }



        private void EditItemSelect(int Id)

        {
            code = Id;
            var i = dataContext.Items.Where(member => member.ItemId == code).FirstOrDefault();

            ItemDesc.Text = i.ItemDesc;
            ItemBarcode.Text = i.ItemBarcode;
            BuyPrice.EditValue = i.BuyPrice;
            SellPrice.EditValue = i.SellPrice;
            SoldSellPrice.EditValue = i.SoldSellPrice;
            SoldQuantity.EditValue = i.SoldQuantity;
            GroupId.EditValue = i.GroupId;
            ItemTypeId.EditValue = i.ItemTypeId;
            SphStrenth.Text = i.SphStrenth;
            CylStrenth.Text = i.CylStrenth;
            DoubleSellPrice.EditValue = i.DoubleSellPrice;
            SingleSellPrice.EditValue = i.SingleSellPrice;
            SignalTypeId.EditValue = i.SingleSellPrice;
            BeginingBalance.EditValue = i.BeginingBalance;
            ItemISActive.Checked = Convert.ToBoolean(ItemISActive);

            IsExist = true;
            IsNew = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}