
namespace VirtualPets.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMood = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnGiveLove = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmotionButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PetGame = new System.Windows.Forms.Panel();
            this.labelMood = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelHungry = new System.Windows.Forms.ProgressBar();
            this.levelBored = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.levelHealthy = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.levelHappy = new System.Windows.Forms.ProgressBar();
            this.imageListMoods = new System.Windows.Forms.ImageList(this.components);
            this.timerUpdateMood = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMood)).BeginInit();
            this.EmotionButtonsPanel.SuspendLayout();
            this.PetGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMood
            // 
            this.pictureBoxMood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMood.Location = new System.Drawing.Point(116, 137);
            this.pictureBoxMood.Name = "pictureBoxMood";
            this.pictureBoxMood.Size = new System.Drawing.Size(501, 420);
            this.pictureBoxMood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMood.TabIndex = 3;
            this.pictureBoxMood.TabStop = false;
            
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(225, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pet Emotion Game";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.AutoSize = true;
            this.ResetButton.Location = new System.Drawing.Point(489, 90);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(138, 41);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset Pet Game";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.AutoSize = true;
            this.btnFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFeed.Location = new System.Drawing.Point(3, 3);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(165, 36);
            this.btnFeed.TabIndex = 6;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPlay.Location = new System.Drawing.Point(174, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(165, 36);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnGiveLove
            // 
            this.btnGiveLove.AutoSize = true;
            this.btnGiveLove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiveLove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveLove.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGiveLove.Location = new System.Drawing.Point(345, 3);
            this.btnGiveLove.Name = "btnGiveLove";
            this.btnGiveLove.Size = new System.Drawing.Size(165, 36);
            this.btnGiveLove.TabIndex = 8;
            this.btnGiveLove.Text = "Give Love";
            this.btnGiveLove.UseVisualStyleBackColor = true;
            this.btnGiveLove.Click += new System.EventHandler(this.btnGiveLove_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.AutoSize = true;
            this.btnMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMedicine.Location = new System.Drawing.Point(516, 3);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(168, 36);
            this.btnMedicine.TabIndex = 9;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(112, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "What would you like to do with your Pet to improve it\'s Mood?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmotionButtonsPanel
            // 
            this.EmotionButtonsPanel.ColumnCount = 4;
            this.EmotionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmotionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmotionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmotionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EmotionButtonsPanel.Controls.Add(this.btnFeed, 0, 0);
            this.EmotionButtonsPanel.Controls.Add(this.btnPlay, 1, 0);
            this.EmotionButtonsPanel.Controls.Add(this.btnMedicine, 3, 0);
            this.EmotionButtonsPanel.Controls.Add(this.btnGiveLove, 2, 0);
            this.EmotionButtonsPanel.Location = new System.Drawing.Point(23, 605);
            this.EmotionButtonsPanel.Name = "EmotionButtonsPanel";
            this.EmotionButtonsPanel.RowCount = 1;
            this.EmotionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmotionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.EmotionButtonsPanel.Size = new System.Drawing.Size(687, 42);
            this.EmotionButtonsPanel.TabIndex = 12;
            // 
            // PetGame
            // 
            this.PetGame.Controls.Add(this.labelMood);
            this.PetGame.Controls.Add(this.label6);
            this.PetGame.Controls.Add(this.label5);
            this.PetGame.Controls.Add(this.levelHungry);
            this.PetGame.Controls.Add(this.levelBored);
            this.PetGame.Controls.Add(this.label4);
            this.PetGame.Controls.Add(this.levelHealthy);
            this.PetGame.Controls.Add(this.label1);
            this.PetGame.Controls.Add(this.levelHappy);
            this.PetGame.Controls.Add(this.label2);
            this.PetGame.Controls.Add(this.EmotionButtonsPanel);
            this.PetGame.Controls.Add(this.label3);
            this.PetGame.Controls.Add(this.ResetButton);
            this.PetGame.Controls.Add(this.pictureBoxMood);
            this.PetGame.Location = new System.Drawing.Point(212, 30);
            this.PetGame.Name = "PetGame";
            this.PetGame.Size = new System.Drawing.Size(728, 873);
            this.PetGame.TabIndex = 13;
            this.PetGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PetGame_Paint);
            // 
            // labelMood
            // 
            this.labelMood.Location = new System.Drawing.Point(142, 510);
            this.labelMood.Name = "labelMood";
            this.labelMood.Size = new System.Drawing.Size(459, 36);
            this.labelMood.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 834);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Not Hungry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 785);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Not Bored";
            // 
            // levelHungry
            // 
            this.levelHungry.Location = new System.Drawing.Point(185, 825);
            this.levelHungry.Name = "levelHungry";
            this.levelHungry.Size = new System.Drawing.Size(510, 30);
            this.levelHungry.TabIndex = 19;
            // 
            // levelBored
            // 
            this.levelBored.Location = new System.Drawing.Point(185, 774);
            this.levelBored.Name = "levelBored";
            this.levelBored.Size = new System.Drawing.Size(510, 31);
            this.levelBored.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Healthy Level";
            // 
            // levelHealthy
            // 
            this.levelHealthy.Location = new System.Drawing.Point(185, 722);
            this.levelHealthy.Name = "levelHealthy";
            this.levelHealthy.Size = new System.Drawing.Size(510, 34);
            this.levelHealthy.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Happiness Level";
            // 
            // levelHappy
            // 
            this.levelHappy.Location = new System.Drawing.Point(185, 662);
            this.levelHappy.Name = "levelHappy";
            this.levelHappy.Size = new System.Drawing.Size(510, 33);
            this.levelHappy.TabIndex = 13;
            // 
            // imageListMoods
            // 
            this.imageListMoods.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMoods.ImageStream")));
            this.imageListMoods.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMoods.Images.SetKeyName(0, "happy.png");
            this.imageListMoods.Images.SetKeyName(1, "Sick.PNG");
            this.imageListMoods.Images.SetKeyName(2, "BoredPNG.PNG");
            this.imageListMoods.Images.SetKeyName(3, "Hungry.PNG");
            this.imageListMoods.Images.SetKeyName(4, "Sad.PNG");
            this.imageListMoods.Images.SetKeyName(5, "FeelingBetter.PNG");
            this.imageListMoods.Images.SetKeyName(6, "FeelingLoved.PNG");
            this.imageListMoods.Images.SetKeyName(7, "NotfeelingBored.PNG");
            this.imageListMoods.Images.SetKeyName(8, "BeingFed.PNG");
            this.imageListMoods.Images.SetKeyName(9, "Dead.PNG");
            // 
            // timerUpdateMood
            // 
            this.timerUpdateMood.Enabled = true;
            this.timerUpdateMood.Interval = 1000;
            this.timerUpdateMood.Tick += new System.EventHandler(this.timerUpdateMood_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 947);
            this.Controls.Add(this.PetGame);
            this.Name = "Form1";
            this.Text = "Virtual Pet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMood)).EndInit();
            this.EmotionButtonsPanel.ResumeLayout(false);
            this.EmotionButtonsPanel.PerformLayout();
            this.PetGame.ResumeLayout(false);
            this.PetGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnGiveLove;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel EmotionButtonsPanel;
        private System.Windows.Forms.Panel PetGame;
        private System.Windows.Forms.ImageList imageListMoods;
        private System.Windows.Forms.Timer timerUpdateMood;
        private System.Windows.Forms.ProgressBar levelHappy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar levelHealthy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar levelHungry;
        private System.Windows.Forms.ProgressBar levelBored;
        private System.Windows.Forms.Label labelMood;
    }
}

