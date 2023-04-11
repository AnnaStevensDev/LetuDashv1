using System.Drawing;

namespace LetuDash
{
    partial class LetuDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetuDash));
            this.topMenu = new System.Windows.Forms.TableLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.feedName = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.customFeedLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.feedPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.feedImage = new System.Windows.Forms.PictureBox();
            this.feedInformation = new System.Windows.Forms.TableLayoutPanel();
            this.feedInformationText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addFeedButton = new System.Windows.Forms.Button();
            this.weatherPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.degrees = new System.Windows.Forms.Label();
            this.weatherPicture = new System.Windows.Forms.PictureBox();
            this.campusPicture = new System.Windows.Forms.PictureBox();
            this.bottomOptions = new System.Windows.Forms.TableLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.feedsButton = new System.Windows.Forms.Button();
            this.feedsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildingHoursButton = new System.Windows.Forms.Button();
            this.contactLETUButton = new System.Windows.Forms.Button();
            this.upcomingEventsButton = new System.Windows.Forms.Button();
            this.sagaMenuButton = new System.Windows.Forms.Button();
            this.allThingsYakButton = new System.Windows.Forms.Button();
            this.fearTheStingButton = new System.Windows.Forms.Button();
            this.solheimScheduleButton = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.faqPanel = new System.Windows.Forms.Panel();
            this.solheimSchedulePanel = new System.Windows.Forms.Panel();
            this.fearTheStingPanel = new System.Windows.Forms.Panel();
            this.allThingsYakPanel = new System.Windows.Forms.Panel();
            this.sagaMenuPanel = new System.Windows.Forms.Panel();
            this.upcomingEventsPanel = new System.Windows.Forms.Panel();
            this.contactPanel = new System.Windows.Forms.Panel();
            this.buildingHoursPanel = new System.Windows.Forms.Panel();
            this.topMenu.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.customFeedLayout.SuspendLayout();
            this.feedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedImage)).BeginInit();
            this.feedInformation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusPicture)).BeginInit();
            this.bottomOptions.SuspendLayout();
            this.feedsPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.ColumnCount = 3;
            this.topMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenu.Controls.Add(this.settingsButton, 2, 0);
            this.topMenu.Controls.Add(this.helpButton, 0, 0);
            this.topMenu.Controls.Add(this.feedName, 1, 0);
            this.topMenu.Location = new System.Drawing.Point(2, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.RowCount = 1;
            this.topMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.topMenu.Size = new System.Drawing.Size(394, 64);
            this.topMenu.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::LetuDash.Properties.Resources.settingsGear;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Location = new System.Drawing.Point(298, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(93, 58);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.helpButton.Location = new System.Drawing.Point(3, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(92, 58);
            this.helpButton.TabIndex = 1;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // feedName
            // 
            this.feedName.AutoSize = true;
            this.feedName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedName.Location = new System.Drawing.Point(101, 0);
            this.feedName.Name = "feedName";
            this.feedName.Size = new System.Drawing.Size(191, 64);
            this.feedName.TabIndex = 2;
            this.feedName.Text = "FeedName";
            this.feedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.AutoScroll = true;
            this.homePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homePanel.Controls.Add(this.customFeedLayout);
            this.homePanel.Controls.Add(this.weatherPanel);
            this.homePanel.Controls.Add(this.campusPicture);
            this.homePanel.Location = new System.Drawing.Point(5, 67);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(391, 424);
            this.homePanel.TabIndex = 1;
            this.homePanel.Tag = "Home";
            // 
            // customFeedLayout
            // 
            this.customFeedLayout.AutoSize = true;
            this.customFeedLayout.Controls.Add(this.feedPanel1);
            this.customFeedLayout.Controls.Add(this.tableLayoutPanel1);
            this.customFeedLayout.Controls.Add(this.addFeedButton);
            this.customFeedLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.customFeedLayout.Location = new System.Drawing.Point(0, 319);
            this.customFeedLayout.Name = "customFeedLayout";
            this.customFeedLayout.Size = new System.Drawing.Size(369, 260);
            this.customFeedLayout.TabIndex = 2;
            this.customFeedLayout.WrapContents = false;
            // 
            // feedPanel1
            // 
            this.feedPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.feedPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.feedPanel1.ColumnCount = 2;
            this.feedPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedPanel1.Controls.Add(this.feedImage, 1, 0);
            this.feedPanel1.Controls.Add(this.feedInformation, 0, 0);
            this.customFeedLayout.SetFlowBreak(this.feedPanel1, true);
            this.feedPanel1.Location = new System.Drawing.Point(3, 3);
            this.feedPanel1.Name = "feedPanel1";
            this.feedPanel1.RowCount = 1;
            this.feedPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.feedPanel1.Size = new System.Drawing.Size(363, 100);
            this.feedPanel1.TabIndex = 0;
            // 
            // feedImage
            // 
            this.feedImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.feedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedImage.Image = global::LetuDash.Properties.Resources.calendar;
            this.feedImage.Location = new System.Drawing.Point(185, 4);
            this.feedImage.Name = "feedImage";
            this.feedImage.Size = new System.Drawing.Size(174, 92);
            this.feedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedImage.TabIndex = 0;
            this.feedImage.TabStop = false;
            // 
            // feedInformation
            // 
            this.feedInformation.ColumnCount = 1;
            this.feedInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedInformation.Controls.Add(this.feedInformationText, 0, 1);
            this.feedInformation.Controls.Add(this.label2, 0, 0);
            this.feedInformation.Location = new System.Drawing.Point(4, 4);
            this.feedInformation.Name = "feedInformation";
            this.feedInformation.RowCount = 2;
            this.feedInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedInformation.Size = new System.Drawing.Size(174, 92);
            this.feedInformation.TabIndex = 1;
            // 
            // feedInformationText
            // 
            this.feedInformationText.AutoSize = true;
            this.feedInformationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedInformationText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedInformationText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.feedInformationText.Location = new System.Drawing.Point(3, 46);
            this.feedInformationText.Name = "feedInformationText";
            this.feedInformationText.Size = new System.Drawing.Size(168, 46);
            this.feedInformationText.TabIndex = 4;
            this.feedInformationText.Text = "sample text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample feed text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.customFeedLayout.SetFlowBreak(this.tableLayoutPanel1, true);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LetuDash.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(185, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(174, 92);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "sample text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sample feed text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addFeedButton
            // 
            this.addFeedButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addFeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customFeedLayout.SetFlowBreak(this.addFeedButton, true);
            this.addFeedButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeedButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addFeedButton.Location = new System.Drawing.Point(3, 215);
            this.addFeedButton.Name = "addFeedButton";
            this.addFeedButton.Size = new System.Drawing.Size(41, 42);
            this.addFeedButton.TabIndex = 2;
            this.addFeedButton.Text = "+";
            this.addFeedButton.UseVisualStyleBackColor = false;
            // 
            // weatherPanel
            // 
            this.weatherPanel.BackColor = System.Drawing.Color.Transparent;
            this.weatherPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.weatherPanel.ColumnCount = 3;
            this.weatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.54822F));
            this.weatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.02538F));
            this.weatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.93401F));
            this.weatherPanel.Controls.Add(this.label1, 2, 0);
            this.weatherPanel.Controls.Add(this.degrees, 1, 0);
            this.weatherPanel.Controls.Add(this.weatherPicture, 0, 0);
            this.weatherPanel.Location = new System.Drawing.Point(92, 18);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.RowCount = 1;
            this.weatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weatherPanel.Size = new System.Drawing.Size(197, 66);
            this.weatherPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "°F";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // degrees
            // 
            this.degrees.AutoSize = true;
            this.degrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.degrees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degrees.Location = new System.Drawing.Point(76, 3);
            this.degrees.Name = "degrees";
            this.degrees.Size = new System.Drawing.Size(58, 60);
            this.degrees.TabIndex = 3;
            this.degrees.Text = "49";
            this.degrees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // weatherPicture
            // 
            this.weatherPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherPicture.Image = global::LetuDash.Properties.Resources.partlyCloudyIcon1;
            this.weatherPicture.Location = new System.Drawing.Point(6, 6);
            this.weatherPicture.Name = "weatherPicture";
            this.weatherPicture.Size = new System.Drawing.Size(61, 54);
            this.weatherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherPicture.TabIndex = 0;
            this.weatherPicture.TabStop = false;
            // 
            // campusPicture
            // 
            this.campusPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campusPicture.Image = ((System.Drawing.Image)(resources.GetObject("campusPicture.Image")));
            this.campusPicture.Location = new System.Drawing.Point(0, 3);
            this.campusPicture.Name = "campusPicture";
            this.campusPicture.Size = new System.Drawing.Size(366, 310);
            this.campusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.campusPicture.TabIndex = 0;
            this.campusPicture.TabStop = false;
            // 
            // bottomOptions
            // 
            this.bottomOptions.ColumnCount = 2;
            this.bottomOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bottomOptions.Controls.Add(this.homeButton, 0, 0);
            this.bottomOptions.Controls.Add(this.feedsButton, 1, 0);
            this.bottomOptions.Location = new System.Drawing.Point(2, 497);
            this.bottomOptions.Name = "bottomOptions";
            this.bottomOptions.RowCount = 1;
            this.bottomOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomOptions.Size = new System.Drawing.Size(394, 50);
            this.bottomOptions.TabIndex = 2;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = global::LetuDash.Properties.Resources.homeButton;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(191, 44);
            this.homeButton.TabIndex = 2;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // feedsButton
            // 
            this.feedsButton.BackColor = System.Drawing.Color.Transparent;
            this.feedsButton.BackgroundImage = global::LetuDash.Properties.Resources.feedsIcon1;
            this.feedsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.feedsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.feedsButton.Location = new System.Drawing.Point(200, 3);
            this.feedsButton.Name = "feedsButton";
            this.feedsButton.Size = new System.Drawing.Size(191, 44);
            this.feedsButton.TabIndex = 3;
            this.feedsButton.UseVisualStyleBackColor = false;
            this.feedsButton.Click += new System.EventHandler(this.feedsButton_Click);
            // 
            // feedsPanel
            // 
            this.feedsPanel.AutoScroll = true;
            this.feedsPanel.AutoSize = true;
            this.feedsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.feedsPanel.Controls.Add(this.buildingHoursButton);
            this.feedsPanel.Controls.Add(this.contactLETUButton);
            this.feedsPanel.Controls.Add(this.upcomingEventsButton);
            this.feedsPanel.Controls.Add(this.sagaMenuButton);
            this.feedsPanel.Controls.Add(this.allThingsYakButton);
            this.feedsPanel.Controls.Add(this.fearTheStingButton);
            this.feedsPanel.Controls.Add(this.solheimScheduleButton);
            this.feedsPanel.Controls.Add(this.faqButton);
            this.feedsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.feedsPanel.Location = new System.Drawing.Point(0, 0);
            this.feedsPanel.Name = "feedsPanel";
            this.feedsPanel.Size = new System.Drawing.Size(396, 429);
            this.feedsPanel.TabIndex = 3;
            this.feedsPanel.Tag = "Feeds";
            this.feedsPanel.WrapContents = false;
            // 
            // buildingHoursButton
            // 
            this.buildingHoursButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buildingHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.buildingHoursButton, true);
            this.buildingHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingHoursButton.Location = new System.Drawing.Point(3, 3);
            this.buildingHoursButton.Name = "buildingHoursButton";
            this.buildingHoursButton.Size = new System.Drawing.Size(390, 111);
            this.buildingHoursButton.TabIndex = 0;
            this.buildingHoursButton.Text = "Building Hours";
            this.buildingHoursButton.UseVisualStyleBackColor = false;
            this.buildingHoursButton.Click += new System.EventHandler(this.buildingHoursButton_Click);
            // 
            // contactLETUButton
            // 
            this.contactLETUButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contactLETUButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.contactLETUButton, true);
            this.contactLETUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLETUButton.Location = new System.Drawing.Point(3, 120);
            this.contactLETUButton.Name = "contactLETUButton";
            this.contactLETUButton.Size = new System.Drawing.Size(390, 111);
            this.contactLETUButton.TabIndex = 1;
            this.contactLETUButton.Text = "Contact LETU";
            this.contactLETUButton.UseVisualStyleBackColor = false;
            this.contactLETUButton.Click += new System.EventHandler(this.contactLETUButton_Click);
            // 
            // upcomingEventsButton
            // 
            this.upcomingEventsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.upcomingEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.upcomingEventsButton, true);
            this.upcomingEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEventsButton.Location = new System.Drawing.Point(3, 237);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(390, 111);
            this.upcomingEventsButton.TabIndex = 2;
            this.upcomingEventsButton.Text = "Upcoming Events";
            this.upcomingEventsButton.UseVisualStyleBackColor = false;
            this.upcomingEventsButton.Click += new System.EventHandler(this.upcomingEventsButton_Click);
            // 
            // sagaMenuButton
            // 
            this.sagaMenuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sagaMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.sagaMenuButton, true);
            this.sagaMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sagaMenuButton.Location = new System.Drawing.Point(3, 354);
            this.sagaMenuButton.Name = "sagaMenuButton";
            this.sagaMenuButton.Size = new System.Drawing.Size(390, 111);
            this.sagaMenuButton.TabIndex = 3;
            this.sagaMenuButton.Text = "SAGA Menu";
            this.sagaMenuButton.UseVisualStyleBackColor = false;
            this.sagaMenuButton.Click += new System.EventHandler(this.sagaMenuButton_Click);
            // 
            // allThingsYakButton
            // 
            this.allThingsYakButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allThingsYakButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.allThingsYakButton, true);
            this.allThingsYakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allThingsYakButton.Location = new System.Drawing.Point(3, 471);
            this.allThingsYakButton.Name = "allThingsYakButton";
            this.allThingsYakButton.Size = new System.Drawing.Size(390, 111);
            this.allThingsYakButton.TabIndex = 4;
            this.allThingsYakButton.Text = "All Things YAK";
            this.allThingsYakButton.UseVisualStyleBackColor = false;
            this.allThingsYakButton.Click += new System.EventHandler(this.allThingsYakButton_Click);
            // 
            // fearTheStingButton
            // 
            this.fearTheStingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fearTheStingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.fearTheStingButton, true);
            this.fearTheStingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fearTheStingButton.Location = new System.Drawing.Point(3, 588);
            this.fearTheStingButton.Name = "fearTheStingButton";
            this.fearTheStingButton.Size = new System.Drawing.Size(390, 111);
            this.fearTheStingButton.TabIndex = 5;
            this.fearTheStingButton.Text = "Fear the Sting";
            this.fearTheStingButton.UseVisualStyleBackColor = false;
            this.fearTheStingButton.Click += new System.EventHandler(this.fearTheStingButton_Click);
            // 
            // solheimScheduleButton
            // 
            this.solheimScheduleButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.solheimScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.solheimScheduleButton, true);
            this.solheimScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solheimScheduleButton.Location = new System.Drawing.Point(3, 705);
            this.solheimScheduleButton.Name = "solheimScheduleButton";
            this.solheimScheduleButton.Size = new System.Drawing.Size(390, 111);
            this.solheimScheduleButton.TabIndex = 6;
            this.solheimScheduleButton.Text = "Solheim Schedule";
            this.solheimScheduleButton.UseVisualStyleBackColor = false;
            this.solheimScheduleButton.Click += new System.EventHandler(this.solheimScheduleButton_Click);
            // 
            // faqButton
            // 
            this.faqButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.faqButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedsPanel.SetFlowBreak(this.faqButton, true);
            this.faqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqButton.Location = new System.Drawing.Point(3, 822);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(390, 111);
            this.faqButton.TabIndex = 7;
            this.faqButton.Text = "FAQ";
            this.faqButton.UseVisualStyleBackColor = false;
            this.faqButton.Click += new System.EventHandler(this.faqButton_Click);
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.feedsPanel);
            this.formPanel.Controls.Add(this.helpPanel);
            this.formPanel.Controls.Add(this.settingsPanel);
            this.formPanel.Controls.Add(this.faqPanel);
            this.formPanel.Controls.Add(this.solheimSchedulePanel);
            this.formPanel.Controls.Add(this.fearTheStingPanel);
            this.formPanel.Controls.Add(this.allThingsYakPanel);
            this.formPanel.Controls.Add(this.sagaMenuPanel);
            this.formPanel.Controls.Add(this.upcomingEventsPanel);
            this.formPanel.Controls.Add(this.contactPanel);
            this.formPanel.Controls.Add(this.buildingHoursPanel);
            this.formPanel.Location = new System.Drawing.Point(0, 67);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(396, 429);
            this.formPanel.TabIndex = 8;
            // 
            // helpPanel
            // 
            this.helpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpPanel.Location = new System.Drawing.Point(0, 0);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(396, 429);
            this.helpPanel.TabIndex = 17;
            this.helpPanel.Tag = "Help";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(396, 429);
            this.settingsPanel.TabIndex = 16;
            this.settingsPanel.Tag = "Settings";
            // 
            // faqPanel
            // 
            this.faqPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqPanel.Location = new System.Drawing.Point(0, 0);
            this.faqPanel.Name = "faqPanel";
            this.faqPanel.Size = new System.Drawing.Size(396, 429);
            this.faqPanel.TabIndex = 15;
            this.faqPanel.Tag = "FAQ";
            // 
            // solheimSchedulePanel
            // 
            this.solheimSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solheimSchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.solheimSchedulePanel.Name = "solheimSchedulePanel";
            this.solheimSchedulePanel.Size = new System.Drawing.Size(396, 429);
            this.solheimSchedulePanel.TabIndex = 14;
            this.solheimSchedulePanel.Tag = "Solheim Schedule";
            // 
            // fearTheStingPanel
            // 
            this.fearTheStingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fearTheStingPanel.Location = new System.Drawing.Point(0, 0);
            this.fearTheStingPanel.Name = "fearTheStingPanel";
            this.fearTheStingPanel.Size = new System.Drawing.Size(396, 429);
            this.fearTheStingPanel.TabIndex = 13;
            this.fearTheStingPanel.Tag = "Fear the Sting";
            // 
            // allThingsYakPanel
            // 
            this.allThingsYakPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allThingsYakPanel.Location = new System.Drawing.Point(0, 0);
            this.allThingsYakPanel.Name = "allThingsYakPanel";
            this.allThingsYakPanel.Size = new System.Drawing.Size(396, 429);
            this.allThingsYakPanel.TabIndex = 12;
            this.allThingsYakPanel.Tag = "All Things YAK";
            // 
            // sagaMenuPanel
            // 
            this.sagaMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sagaMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sagaMenuPanel.Name = "sagaMenuPanel";
            this.sagaMenuPanel.Size = new System.Drawing.Size(396, 429);
            this.sagaMenuPanel.TabIndex = 11;
            this.sagaMenuPanel.Tag = "SAGA Menu";
            // 
            // upcomingEventsPanel
            // 
            this.upcomingEventsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingEventsPanel.Location = new System.Drawing.Point(0, 0);
            this.upcomingEventsPanel.Name = "upcomingEventsPanel";
            this.upcomingEventsPanel.Size = new System.Drawing.Size(396, 429);
            this.upcomingEventsPanel.TabIndex = 10;
            this.upcomingEventsPanel.Tag = "Upcoming Events";
            // 
            // contactPanel
            // 
            this.contactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactPanel.Location = new System.Drawing.Point(0, 0);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(396, 429);
            this.contactPanel.TabIndex = 9;
            this.contactPanel.Tag = "Contact LETU";
            // 
            // buildingHoursPanel
            // 
            this.buildingHoursPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingHoursPanel.Location = new System.Drawing.Point(0, 0);
            this.buildingHoursPanel.Name = "buildingHoursPanel";
            this.buildingHoursPanel.Size = new System.Drawing.Size(396, 429);
            this.buildingHoursPanel.TabIndex = 8;
            this.buildingHoursPanel.Tag = "Building Hours";
            // 
            // LetuDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 545);
            this.Controls.Add(this.bottomOptions);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.formPanel);
            this.Name = "LetuDash";
            this.Load += new System.EventHandler(this.letuDash_Load);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.customFeedLayout.ResumeLayout(false);
            this.feedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedImage)).EndInit();
            this.feedInformation.ResumeLayout(false);
            this.feedInformation.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.weatherPanel.ResumeLayout(false);
            this.weatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusPicture)).EndInit();
            this.bottomOptions.ResumeLayout(false);
            this.feedsPanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topMenu;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox campusPicture;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label feedName;
        private System.Windows.Forms.TableLayoutPanel weatherPanel;
        private System.Windows.Forms.PictureBox weatherPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label degrees;
        private System.Windows.Forms.FlowLayoutPanel customFeedLayout;
        private System.Windows.Forms.TableLayoutPanel feedPanel1;
        private System.Windows.Forms.PictureBox feedImage;
        private System.Windows.Forms.TableLayoutPanel feedInformation;
        private System.Windows.Forms.Label feedInformationText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel bottomOptions;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button feedsButton;
        private System.Windows.Forms.FlowLayoutPanel feedsPanel;
        private System.Windows.Forms.Button contactLETUButton;
        private System.Windows.Forms.Button upcomingEventsButton;
        private System.Windows.Forms.Button sagaMenuButton;
        private System.Windows.Forms.Button allThingsYakButton;
        private System.Windows.Forms.Button fearTheStingButton;
        private System.Windows.Forms.Button solheimScheduleButton;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.Button buildingHoursButton;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addFeedButton;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel faqPanel;
        private System.Windows.Forms.Panel solheimSchedulePanel;
        private System.Windows.Forms.Panel fearTheStingPanel;
        private System.Windows.Forms.Panel allThingsYakPanel;
        private System.Windows.Forms.Panel sagaMenuPanel;
        private System.Windows.Forms.Panel upcomingEventsPanel;
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.Panel buildingHoursPanel;
    }
}

