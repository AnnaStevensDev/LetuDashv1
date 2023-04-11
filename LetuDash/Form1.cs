using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetuDash
{

    public partial class LetuDash : Form
    {
        Panel currentPanel = new Panel();
        public LetuDash()
        {
            InitializeComponent();
        }

        

        private void letuDash_Load(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            formPanel.Visible = false;
            feedsPanel.Visible = false;
            helpPanel.Visible = false;
            settingsPanel.Visible = false;
            faqPanel.Visible = false;
            solheimSchedulePanel.Visible = false;   
            fearTheStingPanel.Visible = false;
            allThingsYakPanel.Visible = false;
            sagaMenuPanel.Visible = false;
            upcomingEventsPanel.Visible = false;
            contactPanel.Visible = false;  
            buildingHoursPanel.Visible = false;

            currentPanel = homePanel;
            feedName.Text = currentPanel.Tag.ToString();
        }


        private void loadPanel(Panel newPanel) 
        {
            if (newPanel.Tag.ToString() != "Home")
            {
                formPanel.Visible = true;
            }
            else
            {
                formPanel.Visible = false;
            }

            currentPanel.Visible = false;

            newPanel.Visible = true;
            currentPanel = newPanel;
            feedName.Text = currentPanel.Tag.ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            loadPanel(homePanel);
        }

        private void feedsButton_Click(object sender, EventArgs e)
        {
            loadPanel(feedsPanel);
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            loadPanel(settingsPanel);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            loadPanel(helpPanel);
        }

        private void buildingHoursButton_Click(object sender, EventArgs e)
        {
            loadPanel(buildingHoursPanel);
        }

        private void contactLETUButton_Click(object sender, EventArgs e)
        {
            loadPanel(contactPanel);
        }

        private void upcomingEventsButton_Click(object sender, EventArgs e)
        {
            loadPanel(upcomingEventsPanel);
        }

        private void sagaMenuButton_Click(object sender, EventArgs e)
        {
            loadPanel(sagaMenuPanel);
        }

        private void allThingsYakButton_Click(object sender, EventArgs e)
        {
            loadPanel(allThingsYakPanel);
        }

        private void fearTheStingButton_Click(object sender, EventArgs e)
        {
            loadPanel(fearTheStingPanel);
        }

        private void solheimScheduleButton_Click(object sender, EventArgs e)
        {
            loadPanel(solheimSchedulePanel);
        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            loadPanel(faqPanel);
        }
    }

}
