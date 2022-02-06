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
    public partial class AddPublisher : Form
    {

        public AddPublisher()
        {
            InitializeComponent();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            AddThePublisher();
        }

        void AddThePublisher()
        {
            if (txtPublisherName.Text != "")
            {
                if (!IsExist())
                {
                    StorePage.publishers.Add(new Publisher(txtPublisherName.Text));
                    AllAroundMethods.ClearParameters(this);
                    MessageBox.Show("The new publisher added to our store successfully.");
                }
                else
                {
                    MessageBox.Show("The publisher already exists in our store.");
                    AllAroundMethods.ClearParameters(this);
                }
                    
            }
            else
            {
                MessageBox.Show("Please fill the Namespace for the publisher.");
            }

        }

        bool IsExist()
        {
            try
            {
                return StorePage.publishers.Exists(x => x.PublisherName == txtPublisherName.Text);
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
