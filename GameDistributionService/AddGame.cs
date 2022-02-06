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
    public partial class AddGame : Form
    {

        public AddGame()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            AddTheGame();
        }
        private void AddGame_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        void LoadPage()
        {
            try
            {
                foreach (Publisher publisher in StorePage.publishers)
                {
                    combPublisher.Items.Add(publisher.PublisherName);
                }
                combPublisher.SelectedIndex = 0;
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

        void AddTheGame()
        {
            if(txtGameName.Text != "")
            {
                if (!IsExist())
                {
                    StorePage.games.Add(new Game(txtGameName.Text, Convert.ToDouble(nudPrice.Value), StorePage.publishers[combPublisher.SelectedIndex], DateTime.Now));
                    StorePage.publishers[combPublisher.SelectedIndex].Games.Add(StorePage.games[StorePage.games.Count - 1]);
                    AllAroundMethods.ClearParameters(this);
                    MessageBox.Show("Game added to our store successfully.");
                }
                else
                {
                    MessageBox.Show("This game already exists.");
                    AllAroundMethods.ClearParameters(this);
                }       
            }
            else
            {
                MessageBox.Show("Please fill the Name for the game.");
            }
            
        }

        bool IsExist()
        {
            try
            {
                return StorePage.games.Exists(x => x.Name == txtGameName.Text);
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
