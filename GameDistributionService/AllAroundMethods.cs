using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDistributionService
{
    class AllAroundMethods
    {
        public static void ClearParameters(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = String.Empty;
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = 0;
                }
                if (ctrl is GroupBox)
                {
                    foreach (RadioButton radioButton in (ctrl as GroupBox).Controls)
                    {
                        if (radioButton.Text == "Standard")
                            radioButton.Checked = true;
                    }
                }
                if (ctrl is FlowLayoutPanel)
                {
                    foreach (CheckBox chbox in (ctrl as FlowLayoutPanel).Controls)
                    {
                        chbox.Checked = false;
                    }
                }
                if (ctrl is NumericUpDown)
                {
                    (ctrl as NumericUpDown).Value = 1;
                }
            }
        }

        public static ListViewItem AddItemToOrderListView(Order order)
        {
            ListViewItem li = new ListViewItem(order.Quantity.ToString());
            try
            {
                li.SubItems.Add(order.Game.Name);
                li.SubItems.Add(order.Edition.ToString());
                li.SubItems.Add(order.TotalPrice.ToString());
                li.SubItems.Add(order.Game.Publisher.PublisherName);

                string dlcList = "";
                if (order.SelectedDLCs != null)
                {
                    foreach (var dlc in order.SelectedDLCs)
                    {
                        dlcList += dlc.Name + " $" + dlc.Price + ", ";
                    }
                    dlcList = dlcList.Trim(' ', ',');
                    if (dlcList.Length == 0)
                        dlcList = "None";
                }
                else
                {
                    dlcList = "None";
                }
                li.SubItems.Add(dlcList);
                li.SubItems.Add(order.OrderTime.ToString("dd/MM/yyyy"));
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return li;
        }
    }
}
