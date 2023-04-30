namespace W8_THA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBox_Team = new System.Windows.Forms.ComboBox();
            this.comboBox_Player = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_owngoal = new System.Windows.Forms.Label();
            this.lbl_goal = new System.Windows.Forms.Label();
            this.lbl_rcard = new System.Windows.Forms.Label();
            this.lbl_ycard = new System.Windows.Forms.Label();
            this.lbl_nation = new System.Windows.Forms.Label();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_Pos = new System.Windows.Forms.Label();
            this.lbl_playername = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_penmis = new System.Windows.Forms.Label();
            this.lbl_pengoal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 26);
            this.toolStripMenuItem1.Text = " ";
            // 
            // ComboBox_Team
            // 
            this.ComboBox_Team.FormattingEnabled = true;
            this.ComboBox_Team.Location = new System.Drawing.Point(10, 91);
            this.ComboBox_Team.Name = "ComboBox_Team";
            this.ComboBox_Team.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Team.TabIndex = 1;
            this.ComboBox_Team.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Team_SelectedIndexChanged);
            this.ComboBox_Team.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Team_SelectionChangeCommitted);
            // 
            // comboBox_Player
            // 
            this.comboBox_Player.FormattingEnabled = true;
            this.comboBox_Player.Location = new System.Drawing.Point(165, 91);
            this.comboBox_Player.Name = "comboBox_Player";
            this.comboBox_Player.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Player.TabIndex = 2;
            this.comboBox_Player.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Player_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Team Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Team Nationality:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yellow Card:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Red Card:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Goal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Own Goal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 13;
            // 
            // lbl_owngoal
            // 
            this.lbl_owngoal.AutoSize = true;
            this.lbl_owngoal.Location = new System.Drawing.Point(138, 352);
            this.lbl_owngoal.Name = "lbl_owngoal";
            this.lbl_owngoal.Size = new System.Drawing.Size(0, 16);
            this.lbl_owngoal.TabIndex = 22;
            // 
            // lbl_goal
            // 
            this.lbl_goal.AutoSize = true;
            this.lbl_goal.Location = new System.Drawing.Point(138, 325);
            this.lbl_goal.Name = "lbl_goal";
            this.lbl_goal.Size = new System.Drawing.Size(0, 16);
            this.lbl_goal.TabIndex = 21;
            // 
            // lbl_rcard
            // 
            this.lbl_rcard.AutoSize = true;
            this.lbl_rcard.Location = new System.Drawing.Point(138, 300);
            this.lbl_rcard.Name = "lbl_rcard";
            this.lbl_rcard.Size = new System.Drawing.Size(0, 16);
            this.lbl_rcard.TabIndex = 20;
            // 
            // lbl_ycard
            // 
            this.lbl_ycard.AutoSize = true;
            this.lbl_ycard.Location = new System.Drawing.Point(138, 274);
            this.lbl_ycard.Name = "lbl_ycard";
            this.lbl_ycard.Size = new System.Drawing.Size(0, 16);
            this.lbl_ycard.TabIndex = 19;
            // 
            // lbl_nation
            // 
            this.lbl_nation.AutoSize = true;
            this.lbl_nation.Location = new System.Drawing.Point(138, 248);
            this.lbl_nation.Name = "lbl_nation";
            this.lbl_nation.Size = new System.Drawing.Size(0, 16);
            this.lbl_nation.TabIndex = 18;
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(138, 222);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(0, 16);
            this.lbl_teamname.TabIndex = 17;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(138, 196);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(0, 16);
            this.lbl_num.TabIndex = 16;
            // 
            // lbl_Pos
            // 
            this.lbl_Pos.AutoSize = true;
            this.lbl_Pos.Location = new System.Drawing.Point(138, 169);
            this.lbl_Pos.Name = "lbl_Pos";
            this.lbl_Pos.Size = new System.Drawing.Size(0, 16);
            this.lbl_Pos.TabIndex = 15;
            // 
            // lbl_playername
            // 
            this.lbl_playername.AutoSize = true;
            this.lbl_playername.Location = new System.Drawing.Point(138, 144);
            this.lbl_playername.Name = "lbl_playername";
            this.lbl_playername.Size = new System.Drawing.Size(0, 16);
            this.lbl_playername.TabIndex = 14;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 26);
            this.toolStripMenuItem2.Text = " Player Data";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Penalty Missed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Penalty Goal:";
            // 
            // lbl_penmis
            // 
            this.lbl_penmis.AutoSize = true;
            this.lbl_penmis.Location = new System.Drawing.Point(138, 379);
            this.lbl_penmis.Name = "lbl_penmis";
            this.lbl_penmis.Size = new System.Drawing.Size(0, 16);
            this.lbl_penmis.TabIndex = 25;
            // 
            // lbl_pengoal
            // 
            this.lbl_pengoal.AutoSize = true;
            this.lbl_pengoal.Location = new System.Drawing.Point(138, 407);
            this.lbl_pengoal.Name = "lbl_pengoal";
            this.lbl_pengoal.Size = new System.Drawing.Size(0, 16);
            this.lbl_pengoal.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Choose Team:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Choose Player:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_pengoal);
            this.Controls.Add(this.lbl_penmis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_owngoal);
            this.Controls.Add(this.lbl_goal);
            this.Controls.Add(this.lbl_rcard);
            this.Controls.Add(this.lbl_ycard);
            this.Controls.Add(this.lbl_nation);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_Pos);
            this.Controls.Add(this.lbl_playername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Player);
            this.Controls.Add(this.ComboBox_Team);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox ComboBox_Team;
        private System.Windows.Forms.ComboBox comboBox_Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_owngoal;
        private System.Windows.Forms.Label lbl_goal;
        private System.Windows.Forms.Label lbl_rcard;
        private System.Windows.Forms.Label lbl_ycard;
        private System.Windows.Forms.Label lbl_nation;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_Pos;
        private System.Windows.Forms.Label lbl_playername;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_penmis;
        private System.Windows.Forms.Label lbl_pengoal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

