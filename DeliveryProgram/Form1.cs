using System;
using System.Linq;
using System.Windows.Forms;
using DeliveryProgram.UcSprControll;

namespace DeliveryProgram
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            foreach (var doc in tabbedView1.Documents)
            {
                if (doc.Control is ucSprUsers)
                {
                    tabbedView1.ActivateDocument(doc.Control);
                    isExist = true;
                }
            }
            if (!isExist)
            {
                ucSprUsers users = new ucSprUsers();
                tabbedView1.AddDocument(users);
                tabbedView1.ActivateDocument(users);
            }

        }

        private void btn_Positions_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            foreach (var doc in tabbedView1.Documents)
            {
                if (doc.Control is ucSprPositions)
                {
                    tabbedView1.ActivateDocument(doc.Control);
                    isExist = true;
                }
            }
            if (!isExist)
            {
                ucSprPositions positions = new ucSprPositions();
                tabbedView1.AddDocument(positions);
                tabbedView1.ActivateDocument(positions);
            }

        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            foreach (var doc in tabbedView1.Documents)
            {
                if (doc.Control is ucSprCategory)
                {
                    tabbedView1.ActivateDocument(doc.Control);
                    isExist = true;
                }
            }
            if (!isExist)
            {
                ucSprCategory category = new ucSprCategory();
                tabbedView1.AddDocument(category);
                tabbedView1.ActivateDocument(category);
            }

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            foreach (var doc in tabbedView1.Documents)
            {
                if (doc.Control is ucSprProducts)
                {
                    tabbedView1.ActivateDocument(doc.Control);
                    isExist = true;
                }
            }
            if (!isExist)
            {
                ucSprProducts products = new ucSprProducts();
                tabbedView1.AddDocument(products);
                tabbedView1.ActivateDocument(products);
            }

        }
    }
}
