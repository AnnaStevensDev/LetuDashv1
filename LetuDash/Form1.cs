using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LetuDash.Properties;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LetuDash
{

    public partial class LetuDash : Form
    {
        Panel currentPanel = new Panel();
        Panel[] feedPanels;
        Label[] feedHeaders;
        Label[] feedBodies;
        Dictionary<string, Image> pinImage;
        PictureBox[] feedImages;
        bool removalActive = false;
        int numFeeds = 0;
    
        Dictionary<string, Image[]> themeImages = new Dictionary<string, Image[]>()
    {
        {"homeButton", new Image[] {Properties.Resources.homeButton,Properties.Resources.homeButtonDark} },
        {"feedsButton", new Image[] {Properties.Resources.feedsIcon,Properties.Resources.feedIconsDark} },
        {"helpButton", new Image[] {Properties.Resources.help,Properties.Resources.helpDark} },
        {"settingsButton", new Image[] {Properties.Resources.settingsGear,Properties.Resources.settingsGearDark} },
        {"campusPicture", new Image[]{Properties.Resources.campus, Properties.Resources.campusDark} }
    };

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
            if (Properties.Settings.Default.pinnedFeeds != null) { 
                numFeeds = Properties.Settings.Default.pinnedFeeds.Count;
            }
            

            setUIMode(this);


            // initializing pinned feed information 
            if (Properties.Settings.Default.pinnedFeeds == null)
            {
                Properties.Settings.Default.pinnedFeeds = new List<string>();
                Properties.Settings.Default.pinnedBodies = new List<string>();

            }

            pinImage = new Dictionary<string, Image>()
            {
                {buildingHoursPanel.Tag.ToString(), Properties.Resources.clock},
                {contactPanel.Tag.ToString(), Properties.Resources.phone},
                {upcomingEventsPanel.Tag.ToString(), Properties.Resources.calendar},
                {sagaMenuPanel.Tag.ToString(), Properties.Resources.pizza},
                {allThingsYakPanel.Tag.ToString(), Properties.Resources.yak},
                {fearTheStingPanel.Tag.ToString(), Properties.Resources.basketball},
                {imSchedulePanel.Tag.ToString(), Properties.Resources.volleyball},
                {faqPanel.Tag.ToString(), Properties.Resources.question}
            };

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

            for (int i = 0; i < numFeeds; i++)
            {
                Console.WriteLine("Loading saved panels...");
                Console.WriteLine("numfeeds = " + numFeeds);
                feedPanels[i].Visible = true;
                Console.WriteLine("Feed panel = " + feedPanels[numFeeds].Name);
                feedHeaders[i].Text = Properties.Settings.Default.pinnedFeeds[i];
                Console.WriteLine("Feed header = " + feedHeaders[numFeeds].Text);
                feedBodies[i].Text = Properties.Settings.Default.pinnedBodies[i];
                feedImages[i].Image = pinImage[Properties.Settings.Default.pinnedFeeds[i]];
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
                getWeather();
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
                try
                {
                    string url;
                    if (Properties.Settings.Default.measurementUnit == 'F')
                    {
                         url = "https://api.openweathermap.org/data/2.5/weather?lat=32.46&lon=-94.72&appid=5a1265d42a4947a39654e1730ae1f12b&units=imperial";
                    }
                    else
                    {
                         url = "https://api.openweathermap.org/data/2.5/weather?lat=32.46&lon=-94.72&appid=5a1265d42a4947a39654e1730ae1f12b&units=metric";
                    }
                    
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    weatherPicture.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    degrees.Text = Convert.ToInt32(Info.main.temp).ToString() + "°" + Properties.Settings.Default.measurementUnit;
                   
                    
                    Console.Write("Degrees: " + Info.main.temp + "\n");
                    Properties.Settings.Default.Save();
                }
                catch (System.Net.WebException)
                {
                    degrees.Text = "--°F";
                }
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
            loadBuildingHours();
        }

        private class Building
        {
            public string name { get; set; }
            public string times { get; set; }
        }

        private void loadBuildingHours()
        {
            Label[] buildingBodies = new Label[3]
            {
                buildingBody1,
                buildingBody2,
                buildingBody3,
            };

            Label[] buildingHeaders = new Label[3]
            {
                buildingHeader1,
                buildingHeader2,
                buildingHeader3,
            };

            using (StreamReader r = new StreamReader("..\\..\\databases\\building_hours.json"))
            {
                string json = r.ReadToEnd();
                List<Building> data = JsonConvert.DeserializeObject<List<Building>>(json);
                int i = 0;
                foreach(Building B in data)
                {
                    buildingHeaders[i].Text = B.name;
                    buildingBodies[i].Text = B.times;
                    i++;
                }
            }
        }

        private void contactLETUButton_Click(object sender, EventArgs e)
        {
            loadPanel(contactPanel);
            loadContactLETU();
        }

        private class Contact
        {
            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string link { get; set; }
        }

        private void loadContactLETU()
        {
            Label[] contactHeaders = new Label[3]
            {
                contactHeader1,
                contactHeader2,
                contactHeader3,
            };

            Label[] contactPhones = new Label[3]
            {
                contactPhone1,
                contactPhone2,
                contactPhone3,
            };

            Label[] contactEmails = new Label[3]
            {
                contactEmail1,
                contactEmail2,
                contactEmail3,
            };

            Label[] contactLinks = new Label[3]
            {
                contactLink1,
                contactLink2,
                contactLink3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\contact_letu.json"))
            {
                string json = r.ReadToEnd();
                List<Contact> data = JsonConvert.DeserializeObject<List<Contact>>(json);
                int i = 0;
                foreach (Contact C in data)
                {
                    contactHeaders[i].Text = C.name;
                    contactPhones[i].Text = C.phone;
                    contactEmails[i].Text = C.email;
                    contactLinks[i].Text = C.link;
                    i++;
                }
            }
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
            if (! Properties.Settings.Default.pinnedFeeds.Contains(header))
            {
                Properties.Settings.Default.pinnedFeeds.Add(header);
                Properties.Settings.Default.pinnedBodies.Add(body);
                feedPanels[numFeeds].Visible = true;
                feedHeaders[numFeeds].Text = header;
                feedBodies[numFeeds].Text = body;
                feedImages[numFeeds].Image = pinImage[header];
                numFeeds++;

                //Console.Write("Added " + header.ToUpper() + "\n");
                Properties.Settings.Default.Save();
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

        private void pinFAQ_Click(object sender, EventArgs e)
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
                try
                {
                    feedImages[i].Image = pinImage[feedHeaders[i].Text];
                }
                catch (KeyNotFoundException)
                {
                    //pass
                }
            }
            removalActive = false;
        }

        private bool removePinnedFeed(Panel panel, string header, string body)
        {
            if (removalActive)
            {
                numFeeds--;
                Properties.Settings.Default.pinnedFeeds.Remove(header);
                Properties.Settings.Default.pinnedBodies.Remove(body);
                panel.Visible = false;
                cancelRemoval();
                Console.Write("Removed " + header + "\n");
                return true;
            }
            else
                return false;
        }

        private void feedImage1_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel1, feedTextHeader1.Text, feedTextBody1.Text))
                pinnedFeedOpen(feedTextHeader1.Text);
        }

        private void feedImage2_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel2, feedTextHeader2.Text, feedTextBody2.Text))
                pinnedFeedOpen(feedTextHeader2.Text);
        }

        private void feedImage3_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel3, feedTextHeader3.Text, feedTextBody3.Text))
                pinnedFeedOpen(feedTextHeader3.Text);
        }

        private void feedImage4_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel4, feedTextHeader4.Text, feedTextBody4.Text))
                pinnedFeedOpen(feedTextHeader4.Text);
        }

        private void feedImage5_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel5, feedTextHeader5.Text, feedTextBody5.Text))
                pinnedFeedOpen(feedTextHeader5.Text);
        }

        private void feedImage6_Click(object sender, EventArgs e)
        {
            if(!removePinnedFeed(feedPanel6, feedTextHeader6.Text, feedTextBody6.Text))
                pinnedFeedOpen(feedTextHeader6.Text);
        }

        private void feedImage7_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel7, feedTextHeader7.Text, feedTextBody7.Text))
                pinnedFeedOpen(feedTextHeader7.Text);
        }

        private void feedImage8_Click(object sender, EventArgs e)
        {
            if (!removePinnedFeed(feedPanel8, feedTextHeader8.Text, feedTextBody8.Text))
                pinnedFeedOpen(feedTextHeader8.Text);
        }

        private void setUIMode(Control control)
        {
            string tag = "modifiable";
            if (control.Tag != null)
            {
                tag = control.Tag.ToString();
            }

            if (tag == "notModifiable")
            {
                return;
            }

            if (Properties.Settings.Default.theme == "light")
            {
                control.BackColor = SystemColors.Control;
                if (control.Text != null)
                {
                    control.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    control.ForeColor = SystemColors.Control;
                }
                this.campusPicture.Image = Properties.Resources.campus;
                if (control.BackgroundImage != null)
                {
                    try
                    {
                        control.BackgroundImage = themeImages[control.Name][0];
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("Image not found.\n");
                    }
                }
            }
            else
            {
                control.BackColor = Color.FromArgb(24, 24, 24);
                if (control.Text != null)
                {
                    control.ForeColor = SystemColors.Control;
                }
                else
                {
                    control.ForeColor = Color.FromArgb(24,24,24);
                }
                this.campusPicture.Image = Properties.Resources.campusDark1;
                if (control.BackgroundImage != null)
                {
                    try
                    {
                        control.BackgroundImage = themeImages[control.Name][1];
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("Image not found.\n");
                    }
                }
            }

                if (control.HasChildren)
                {
                    foreach (Control child in control.Controls)
                    {
                        setUIMode(child);
                    }
                }

            Properties.Settings.Default.Save();
        }



        private void debugList()
        {
            foreach(String panel in  Properties.Settings.Default.pinnedFeeds)
            {
                Console.Write(panel + "\n");
            }
        }

        private void lightButton_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.theme == "light")
            {
                return;
            }
           Properties.Settings.Default.theme= "light";
            setUIMode(this);
        }

        private void darkButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.theme == "dark")
            {
                return;
            }
           Properties.Settings.Default.theme= "dark";
            setUIMode(this);
        }

        private void fahrenheitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.measurementUnit = 'F';
            getWeather();
        }

        private void celsiusButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.measurementUnit = 'C';
            getWeather();
        }


        private void pinnedFeedOpen(string feedName)
        {
           switch (feedName){
                case "Building Hours":
                    loadPanel(buildingHoursPanel);
                    loadBuildingHours();
                    break;
                case "Contact LETU":
                    loadPanel(contactPanel);
                    loadContactLETU();
                    break;
                case "Upcoming Events":
                    loadPanel(upcomingEventsPanel);
                    break;
                case "SAGA Menu":
                    loadPanel(sagaMenuPanel);
                    break;
                case "All Things YAK":
                    loadPanel(allThingsYakPanel);
                    break;
                case "Fear the Sting":
                    loadPanel(fearTheStingPanel);
                    break;
                case "IM Schedule":
                    loadPanel(imSchedulePanel);
                    break;
                case "FAQ":
                    loadPanel(faqPanel);
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
    }

}
