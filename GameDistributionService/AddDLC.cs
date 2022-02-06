using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDistributionService
{
    public partial class AddDLC : Form
    {

        public AddDLC()
        {
            InitializeComponent();
        }

        private void btnAddDLC_Click(object sender, EventArgs e)
        {
            AddTheDLC();
        }

        private void AddDLC_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        void LoadPage()
        {
            try
            {
                foreach (Game game in StorePage.games)
                {
                    combGame.Items.Add(game.Name);
                }
                combGame.SelectedIndex = 0;
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AddTheDLC()
        {
            if (txtDLCName.Text != "")
            {
                if (!IsExist())
                {
                    StorePage.dlcs.Add(new DLC(txtDLCName.Text, Convert.ToDouble(nudPrice.Value)));
                    StorePage.games[combGame.SelectedIndex].DLCs.Add(StorePage.dlcs[StorePage.dlcs.Count - 1]);
                    AllAroundMethods.ClearParameters(this);
                    MessageBox.Show("DLC added your game successfully.");
                }
                else
                {
                    MessageBox.Show("This DLC already exists.");
                    AllAroundMethods.ClearParameters(this);
                }
            }
            else
            {
                MessageBox.Show("Please fill the Name for the DLC.");
            }

        }

        bool IsExist()
        {
            try
            {
                return StorePage.dlcs.Exists(x => x.Name == txtDLCName.Text);
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
