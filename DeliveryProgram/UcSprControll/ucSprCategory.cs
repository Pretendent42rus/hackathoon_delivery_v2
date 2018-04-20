using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryProgram.UcSprControll
{
    public partial class ucSprCategory : UserControl
    {
        Category selCategory = new Category();
        BindingList<Category> category = new BindingList<Category>()
        {
                new Category() { ID = "1", Name = "Напитки"},
                new Category() { ID = "2", Name = "Горячие блюда"},
                new Category() { ID = "3", Name = "Прочее"}
        };

    public ucSprCategory()
        {
            Text = "Справочник: Категории товаров";
            
            InitializeComponent();
            gridControl1.DataSource = category;
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selRow = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID");
            selCategory = category.Where(c => c.ID == selRow.ToString()).First();

        }

        private void ButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            var b = ButtonPanel.Buttons;
            if (e.Button == b[0])   //Add
                Add();
            if (e.Button == b[1])  //Edit
                Edit();
            if (e.Button == b[2])  // Remove
                Remove();
            
        }
        public void Add()
        {
            MessageBox.Show("Add");
        }
        public void Edit()
        {
            MessageBox.Show("Edit");
        }
        public void Remove()
        {
            MessageBox.Show("Remove");
        }
    }

    public class Category
    {
        public string ID { get; set; } 
        public string Name { get; set; } 
        
    }
}
