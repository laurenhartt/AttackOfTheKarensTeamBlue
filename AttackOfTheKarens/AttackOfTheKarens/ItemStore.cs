using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttackOfTheKarens
{
    public partial class ItemStore : Form
    {
        public ItemStore()
        {
            InitializeComponent();
        }

        private void BuyManager_Click(object sender, EventArgs e)
        {
            
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
    }

    
}
