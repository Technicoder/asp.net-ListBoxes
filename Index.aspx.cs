using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox_Example
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Team_Click(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;

            for (int x = lstMembers.Items.Count - 1; x >= 0; x--)
            {
                if (lstMembers.Items[x].Selected)
                {
                    if (dlTeam.SelectedValue == "1")
                    {
                        selectedValue = lstMembers.Items[x].Text;
                        lstMembers.Items.Remove(selectedValue);
                        lstGreenTeam.Items.Add(new ListItem(selectedValue));
                    }

                    if (dlTeam.SelectedValue == "2") 
                    {
                        selectedValue = lstMembers.Items[x].Text;
                        lstMembers.Items.Remove(selectedValue);
                        lstRedTeam.Items.Add(new ListItem(selectedValue));
                    }             

                 }

             }

          }
         
         protected void btnClearSelection_Click(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;
            for (int x = lstMembers.Items.Count - 1; x >= 1; x--)
            {
                if (lstMembers.Items[x].Selected)
                {
                    selectedValue = lstMembers.Items[x].Text;
                    lstMembers.Items.Remove(selectedValue);
                }
            }
        }

        protected void btnResetLists_Click(object sender, EventArgs e)
        {
            string selectedValue = string.Empty;
             for (int x = lstGreenTeam.Items.Count - 1; x >= 1; x--)
            {       
                    selectedValue = lstGreenTeam.Items[x].Text;
                    lstGreenTeam.Items.Remove(selectedValue);
                    lstMembers.Items.Add(new ListItem(selectedValue));            
            }
             for (int x = lstRedTeam.Items.Count - 1; x >= 1; x--)
             {
                 selectedValue = lstRedTeam.Items[x].Text;
                 lstRedTeam.Items.Remove(selectedValue);
                 lstMembers.Items.Add(new ListItem(selectedValue));
             }
        }
    }
}