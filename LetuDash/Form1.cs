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
            InitializeHelpControls();
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
            loadHelpInfo();
        }

        private class HelpInfo
        {
            public string title { get; set; }
            public string content { get; set; }
        }
        private Label helpTitle;
        private TextBox helpContent;
        private void InitializeHelpControls()
        {
            if (helpPanel == null)
            {
                helpPanel = new Panel
                {
                    Name = "helpPanel",
                    Location = new Point(0, 0),
                    Size = new Size(500, 300),
                    Visible = false,
                };
                this.Controls.Add(helpPanel);
            }

            helpTitle = new Label
            {
                Name = "helpTitle",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };
            helpPanel.Controls.Add(helpTitle);

            helpContent = new TextBox
            {
                Name = "helpContent",
                Location = new Point(10, 40),
                Size = new Size(300, 200),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };
            helpPanel.Controls.Add(helpContent);
        }
        public void loadHelpInfo()
        {
            using (StreamReader r = new StreamReader("..\\..\\databases\\help_info.json"))
            {
                string json = r.ReadToEnd();
                HelpInfo data = JsonConvert.DeserializeObject<HelpInfo>(json);

                helpTitle.Text = data.title;
                helpContent.Text = data.content;
            }
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

        private class Event
        {
            public string name { get; set; }
            public string location { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }

        private void upcomingEventsButton_Click(object sender, EventArgs e)
        {
            loadPanel(upcomingEventsPanel);
            loadUpcomingEvents();
        }

        private void loadUpcomingEvents()
        {
            Label[] upcomingEventsHeaders = new Label[3]
            {
                upcomingEventsHeader1,
                upcomingEventsHeader2,
                upcomingEventsHeader3,
            };

            Label[] upcomingEventsLocations = new Label[3]
            {
                upcomingEventsLocation1,
                upcomingEventsLocation2,
                upcomingEventsLocation3
            };

            Label[] upcomingEventsDates = new Label[3]
            {
                upcomingEventsDate1,
                upcomingEventsDate2,
                upcomingEventsDate3,
            };

            Label[] upcomingEventsTimes = new Label[3]
            {
                upcomingEventsTime1,
                upcomingEventsTime2,
                upcomingEventsTime3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\upcoming_events.json"))
            {
                string json = r.ReadToEnd();
                List<Event> data = JsonConvert.DeserializeObject<List<Event>>(json);
                int i = 0;
                foreach (Event E in data)
                {
                    upcomingEventsHeaders[i].Text = E.name;
                    upcomingEventsLocations[i].Text = E.location;
                    upcomingEventsDates[i].Text = E.date;
                    upcomingEventsTimes[i].Text = E.time;
                    i++;
                }
            }
        }

        private class Menu
        {
            public string name { get; set; }
            public string item1 { get; set; }
            public string item2 { get; set; }
            public string item3 { get; set; }
        }

        private void sagaMenuButton_Click(object sender, EventArgs e)
        {
            loadPanel(sagaMenuPanel);
            loadSagaMenu();
        }

        private void loadSagaMenu()
        {
            Label[] sagaMenuHeaders = new Label[3]
            {
                sagaMenuHeader1,
                sagaMenuHeader2,
                sagaMenuHeader3,
            };

            Label[] sagaMenuItem1s = new Label[3]
            {
                sagaMenuItem1_1,
                sagaMenuItem1_2,
                sagaMenuItem1_3,
            };

            Label[] sagaMenuItem2s = new Label[3]
            {
                sagaMenuItem2_1,
                sagaMenuItem2_2,
                sagaMenuItem2_3,
            };

            Label[] sagaMenuItem3s = new Label[3]
            {
                sagaMenuItem3_1,
                sagaMenuItem3_2,
                sagaMenuItem3_3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\saga_menu.json"))
            {
                string json = r.ReadToEnd();
                List<Menu> data = JsonConvert.DeserializeObject<List<Menu>>(json);
                int i = 0;
                foreach (Menu M in data)
                {
                    sagaMenuHeaders[i].Text = M.name;
                    sagaMenuItem1s[i].Text = M.item1;
                    sagaMenuItem2s[i].Text = M.item2;
                    sagaMenuItem3s[i].Text = M.item3;
                    i++;
                }
            }
        }

        private class Yak
        {
            public string name { get; set; }
            public string location { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }

        private void allThingsYakButton_Click(object sender, EventArgs e)
        {
            loadPanel(allThingsYakPanel);
            loadAllThingsYak();
        }

        private void loadAllThingsYak()
        {
            Label[] allThingsYakHeaders = new Label[3]
            {
                allThingsYakHeader1,
                allThingsYakHeader2,
                allThingsYakHeader3,
            };

            Label[] allThingsYakLocations = new Label[3]
            {
                allThingsYakLocation1,
                allThingsYakLocation2,
                allThingsYakLocation3,
            };

            Label[] allThingsYakDates = new Label[3]
            {
                allThingsYakDate1,
                allThingsYakDate2,
                allThingsYakDate3,
            };

            Label[] allThingsYakTimes = new Label[3]
            {
                allThingsYakTime1,
                allThingsYakTime2,
                allThingsYakTime3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\all_things_yak.json"))
            {
                string json = r.ReadToEnd();
                List<Yak> data = JsonConvert.DeserializeObject<List<Yak>>(json);
                int i = 0;
                foreach (Yak Y in data)
                {
                    allThingsYakHeaders[i].Text = Y.name;
                    allThingsYakLocations[i].Text = Y.location;
                    allThingsYakDates[i].Text = Y.date;
                    allThingsYakTimes[i].Text = Y.time;
                    i++;
                }
            }
        }

        private class Sting
        {
            public string name { get; set; }
            public string location { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }

        private void fearTheStingButton_Click(object sender, EventArgs e)
        {
            loadPanel(fearTheStingPanel);
            loadFearTheSting();
        }

        private void loadFearTheSting()
        {
            Label[] fearTheStingHeaders = new Label[3]
            {
                fearTheStingHeader1,
                fearTheStingHeader2,
                fearTheStingHeader3,
            };

            Label[] fearTheStingLocations = new Label[3]
            {
                fearTheStingLocation1,
                fearTheStingLocation2,
                fearTheStingLocation3,
            };

            Label[] fearTheStingDates = new Label[3]
            {
                fearTheStingDate1,
                fearTheStingDate2,
                fearTheStingDate3,
            };

            Label[] fearTheStingTimes = new Label[3]
            {
                fearTheStingTime1,
                fearTheStingTime2,
                fearTheStingTime3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\fear_the_sting.json"))
            {
                string json = r.ReadToEnd();
                List<Sting> data = JsonConvert.DeserializeObject<List<Sting>>(json);
                int i = 0;
                foreach (Sting S in data)
                {
                    fearTheStingHeaders[i].Text = S.name;
                    fearTheStingLocations[i].Text = S.location;
                    fearTheStingDates[i].Text = S.date;
                    fearTheStingTimes[i].Text = S.time;
                    i++;
                }
            }
        }

        private class Ims
        {
            public string name { get; set; }
            public string date { get; set; }
        }

        private void solheimScheduleButton_Click(object sender, EventArgs e)
        {
            loadPanel(imSchedulePanel);
            loadImSchedule();
        }

        private void loadImSchedule()
        {
            Label[] imScheduleHeaders = new Label[3]
            {
                imScheduleHeader1,
                imScheduleHeader2,
                imScheduleHeader3,
            };

            Label[] imScheduleDates = new Label[3]
            {
                imScheduleDate1,
                imScheduleDate2,
                imScheduleDate3,
            };


            using (StreamReader r = new StreamReader("..\\..\\databases\\im_schedule.json"))
            {
                string json = r.ReadToEnd();
                List<Ims> data = JsonConvert.DeserializeObject<List<Ims>>(json);
                int i = 0;
                foreach (Ims Im in data)
                {
                    imScheduleHeaders[i].Text = Im.name;
                    imScheduleDates[i].Text = Im.date;
                    i++;
                }
            }
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
                Properties.Settings.Default.Save();
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
                    loadUpcomingEvents();
                    break;
                case "SAGA Menu":
                    loadPanel(sagaMenuPanel);
                    loadSagaMenu();
                    break;
                case "All Things YAK":
                    loadPanel(allThingsYakPanel);
                    loadAllThingsYak();
                    break;
                case "Fear the Sting":
                    loadPanel(fearTheStingPanel);
                    loadFearTheSting();
                    break;
                case "IM Schedule":
                    loadPanel(imSchedulePanel);
                    loadImSchedule();
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
