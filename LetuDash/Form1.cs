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
        Panel[] feedPanels;
        Label[] feedHeaders;
        Label[] feedBodies;
        PictureBox[] feedImages;
        bool removalActive = false;

        int numFeeds = 0;
        List<string> currentlyPinnedFeeds= new List<string>();

        public LetuDash()
        {
            InitializeComponent();
        }

        

        private void letuDash_Load(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            formPanel.Visible = false;
            feedsPanel.Visible = false;
            feedSelectionPanel.Visible = false;
            helpPanel.Visible = false;
            settingsPanel.Visible = false;
            faqPanel.Visible = false;
            imSchedulePanel.Visible = false;   
            fearTheStingPanel.Visible = false;
            allThingsYakPanel.Visible = false;
            sagaMenuPanel.Visible = false;
            upcomingEventsPanel.Visible = false;
            contactPanel.Visible = false;  
            buildingHoursPanel.Visible = false;


            // initializing pinned feed information 

            feedPanels = new Panel[8]
            {
                feedPanel1,
                feedPanel2,
                feedPanel3,
                feedPanel4,
                feedPanel5,
                feedPanel6,
                feedPanel7,
                feedPanel8
            };

            feedBodies = new Label[8]
            {
                feedTextBody1,
                feedTextBody2,
                feedTextBody3,
                feedTextBody4,
                feedTextBody5,
                feedTextBody6,
                feedTextBody7,
                feedTextBody8
            };

            feedHeaders = new Label[8]
            {
                feedTextHeader1,
                feedTextHeader2,
                feedTextHeader3,
                feedTextHeader4,
                feedTextHeader5,
                feedTextHeader6,
                feedTextHeader7,
                feedTextHeader8
            };

            feedImages = new PictureBox[8]
            {
                feedImage1,
                feedImage2,
                feedImage3,
                feedImage4,
                feedImage5,
                feedImage6,
                feedImage7,
                feedImage8

            };

            foreach (Panel feed in feedPanels)
            {
                feed.Visible = false;
            }

            loadPanel(homePanel);
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

        private void getWeather()
        {
            // https://api.openweathermap.org/data/2.5/weather?lat=32.46&lon=-94.72&appid=5a1265d42a4947a39654e1730ae1f12b&units=imperial
            using (WebClient web = new WebClient()) 
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?lat=32.46&lon=-94.72&appid=5a1265d42a4947a39654e1730ae1f12b&units=imperial";
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root> (json);
                weatherPicture.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                degrees.Text = Convert.ToInt32(Info.main.temp).ToString() + "°F";
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
            }

            loadPanel(homePanel);
        }

        private void feedsButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
            }

            loadPanel(feedsPanel);
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
            }

            loadPanel(settingsPanel);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
            }

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
            loadPanel(imSchedulePanel);
        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            
            loadPanel(faqPanel);
        }

        private void addFeedButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
            }

            if (numFeeds >= 8)
            {
                return;
            }

            loadPanel(feedSelectionPanel);
        }

        private void pinFeed(string header, string body)
        {
            loadPanel(homePanel);
            if (!currentlyPinnedFeeds.Contains(header.ToUpper()))
            {
                currentlyPinnedFeeds.Add(header.ToUpper());
                feedPanels[numFeeds].Visible = true;
                feedHeaders[numFeeds].Text = header;
                feedBodies[numFeeds].Text = body;
                numFeeds++;

                //Console.Write("Added " + header.ToUpper() + "\n");
            }

            
            debugList();
        }

        private void pinBuildingHours_Click(object sender, EventArgs e)
        {
            pinFeed(buildingHoursPanel.Tag.ToString(), "AFSC Hours\n8am - 2am");
        }

        private void pinContact_Click(object sender, EventArgs e)
        {
            pinFeed(contactPanel.Tag.ToString(), "(903)-233-3000");
        }

        private void pinUpcomingEvents_Click(object sender, EventArgs e)
        {
            pinFeed(upcomingEventsPanel.Tag.ToString(), "Kahootenany - 4/14");
        }

        private void pinSagaMenu_Click(object sender, EventArgs e)
        {
            pinFeed(sagaMenuPanel.Tag.ToString(), "Undercooked chicken");
        }

        private void pinAllThingsYak_Click(object sender, EventArgs e)
        {
            pinFeed(allThingsYakPanel.Tag.ToString(), "Upcoming:\nMystery Bus Event");
        }

        private void pinFearTheSting_Click(object sender, EventArgs e)
        {
            pinFeed(fearTheStingPanel.Tag.ToString(), "Baseball Game plays 4/20");
        }

        private void pinIMSchedule_Click(object sender, EventArgs e)
        {
            pinFeed(imSchedulePanel.Tag.ToString(), "Stay tuned for\nIM Volleyball!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pinFeed(faqPanel.Tag.ToString(), "LETUDash v.1.0");
        }

        private void removeFeedButton_Click(object sender, EventArgs e)
        {
            if (removalActive)
            {
                cancelRemoval();
                return;
            }

            for (int i = 0; i < feedPanels.Length; i++ )
            {
                if (feedPanels[i].Visible == true)
                {
                    feedPanels[i].BackColor = Color.IndianRed;
                    feedImages[i].Image = Properties.Resources.removalImage;
                }
            }

            removalActive = true;
        }

        private void cancelRemoval()
        {
            for (int i = 0; i < feedPanels.Length; i++)
            {
                feedPanels[i].BackColor = SystemColors.ActiveBorder;
                feedImages[i].Image = Properties.Resources.calendar;
            }
            removalActive = false;
        }

        private void removePinnedFeed(Panel panel, string header)
        {
            if (removalActive)
            {
                numFeeds--;
                currentlyPinnedFeeds.Remove(header.ToUpper());
                panel.Visible = false;
                cancelRemoval();
                //Console.Write("Removed " + header.ToUpper() + "\n");
            }
        }

        private void feedImage1_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel1, feedTextHeader1.Text);
        }

        private void feedImage2_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel2, feedTextHeader2.Text);
        }

        private void feedImage3_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel3, feedTextHeader3.Text);
        }

        private void feedImage4_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel4, feedTextHeader4.Text);
        }

        private void feedImage5_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel5, feedTextHeader5.Text);
        }

        private void feedImage6_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel6, feedTextHeader6.Text);
        }

        private void feedImage7_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel7, feedTextHeader7.Text);
        }

        private void feedImage8_Click(object sender, EventArgs e)
        {
            removePinnedFeed(feedPanel8, feedTextHeader8.Text);
        }

        private void debugList()
        {
            foreach(String panel in currentlyPinnedFeeds)
            {
                Console.Write(panel + "\n");
            }
        }
    }

}
