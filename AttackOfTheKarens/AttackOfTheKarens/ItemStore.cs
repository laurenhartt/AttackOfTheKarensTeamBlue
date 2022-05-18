using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KarenLogic;

namespace AttackOfTheKarens
{
    public partial class ItemStore : Form
    {
        public List<Store> storeUpgrades;
        public ItemStore()
        {
            this.storeUpgrades = null;
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public void addStores(List<Store> stores)
        {
            this.storeUpgrades = stores;
        }

        public event EventHandler BuyManagerEvent;

        public void BuyManagerClicked(EventArgs e)
        {
            BuyManagerEvent?.Invoke(this, e);
        }
        private void BuyManager_Click(object sender, EventArgs e)
        {
            BuyManagerClicked(e);
        }
        public event EventHandler rateUpgradeEvent;

        public void rateUpgradeClicked(EventArgs e)
        {
            rateUpgradeEvent?.Invoke(this, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rateUpgradeClicked(e);
        }

        public event EventHandler attackUpgradeEvent;

        public void attackUpgradeClicked(EventArgs e)
        {
            attackUpgradeEvent?.Invoke(this, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            attackUpgradeClicked(e);
        }
    }

    
}
