﻿namespace Verstoppertje_App
{
    partial class gameSettings_Page
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
            this.gameTime_comboBox = new System.Windows.Forms.ComboBox();
            this.gameTime_label = new System.Windows.Forms.Label();
            this.hideTime_label = new System.Windows.Forms.Label();
            this.hidingTime_comboBox = new System.Windows.Forms.ComboBox();
            this.difficulty_label = new System.Windows.Forms.Label();
            this.difficulty_comboBox = new System.Windows.Forms.ComboBox();
            this.returnMain_btn = new System.Windows.Forms.Button();
            this.mainGame_panel = new System.Windows.Forms.Panel();
            this.startGame_btn = new System.Windows.Forms.Button();
            this.endGame_btn = new System.Windows.Forms.Button();
            this.LogWindow_rBox = new System.Windows.Forms.RichTextBox();
            this.userSetting_grBox = new System.Windows.Forms.GroupBox();
            this.DomoticzLog_grBox = new System.Windows.Forms.GroupBox();
            this.userSetting_grBox.SuspendLayout();
            this.DomoticzLog_grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTime_comboBox
            // 
            this.gameTime_comboBox.FormattingEnabled = true;
            this.gameTime_comboBox.Location = new System.Drawing.Point(73, 21);
            this.gameTime_comboBox.Name = "gameTime_comboBox";
            this.gameTime_comboBox.Size = new System.Drawing.Size(121, 21);
            this.gameTime_comboBox.TabIndex = 0;
            // 
            // gameTime_label
            // 
            this.gameTime_label.AutoSize = true;
            this.gameTime_label.Location = new System.Drawing.Point(3, 24);
            this.gameTime_label.Name = "gameTime_label";
            this.gameTime_label.Size = new System.Drawing.Size(61, 13);
            this.gameTime_label.TabIndex = 1;
            this.gameTime_label.Text = "Game Time";
            // 
            // hideTime_label
            // 
            this.hideTime_label.AutoSize = true;
            this.hideTime_label.Location = new System.Drawing.Point(3, 66);
            this.hideTime_label.Name = "hideTime_label";
            this.hideTime_label.Size = new System.Drawing.Size(63, 13);
            this.hideTime_label.TabIndex = 2;
            this.hideTime_label.Text = "Hiding Time";
            // 
            // hidingTime_comboBox
            // 
            this.hidingTime_comboBox.FormattingEnabled = true;
            this.hidingTime_comboBox.Location = new System.Drawing.Point(73, 66);
            this.hidingTime_comboBox.Name = "hidingTime_comboBox";
            this.hidingTime_comboBox.Size = new System.Drawing.Size(121, 21);
            this.hidingTime_comboBox.TabIndex = 3;
            // 
            // difficulty_label
            // 
            this.difficulty_label.AutoSize = true;
            this.difficulty_label.Location = new System.Drawing.Point(3, 111);
            this.difficulty_label.Name = "difficulty_label";
            this.difficulty_label.Size = new System.Drawing.Size(47, 13);
            this.difficulty_label.TabIndex = 4;
            this.difficulty_label.Text = "Difficulty";
            // 
            // difficulty_comboBox
            // 
            this.difficulty_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty_comboBox.FormattingEnabled = true;
            this.difficulty_comboBox.Items.AddRange(new object[] {
            "Easy",
            "Meduim",
            "Hard"});
            this.difficulty_comboBox.Location = new System.Drawing.Point(73, 111);
            this.difficulty_comboBox.Name = "difficulty_comboBox";
            this.difficulty_comboBox.Size = new System.Drawing.Size(121, 21);
            this.difficulty_comboBox.TabIndex = 5;
            // 
            // returnMain_btn
            // 
            this.returnMain_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMain_btn.Location = new System.Drawing.Point(1013, 519);
            this.returnMain_btn.Name = "returnMain_btn";
            this.returnMain_btn.Size = new System.Drawing.Size(115, 59);
            this.returnMain_btn.TabIndex = 6;
            this.returnMain_btn.Text = "Return";
            this.returnMain_btn.UseVisualStyleBackColor = true;
            this.returnMain_btn.Click += new System.EventHandler(this.returnMain_btn_Click);
            // 
            // mainGame_panel
            // 
            this.mainGame_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainGame_panel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mainGame_panel.Location = new System.Drawing.Point(224, 28);
            this.mainGame_panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainGame_panel.Name = "mainGame_panel";
            this.mainGame_panel.Size = new System.Drawing.Size(588, 393);
            this.mainGame_panel.TabIndex = 7;
            // 
            // startGame_btn
            // 
            this.startGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame_btn.Location = new System.Drawing.Point(12, 456);
            this.startGame_btn.Name = "startGame_btn";
            this.startGame_btn.Size = new System.Drawing.Size(100, 58);
            this.startGame_btn.TabIndex = 8;
            this.startGame_btn.Text = "Start Game";
            this.startGame_btn.UseVisualStyleBackColor = true;
            this.startGame_btn.Click += new System.EventHandler(this.startGame_btn_Click);
            // 
            // endGame_btn
            // 
            this.endGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGame_btn.Location = new System.Drawing.Point(12, 520);
            this.endGame_btn.Name = "endGame_btn";
            this.endGame_btn.Size = new System.Drawing.Size(100, 58);
            this.endGame_btn.TabIndex = 9;
            this.endGame_btn.Text = "End Game";
            this.endGame_btn.UseVisualStyleBackColor = true;
            // 
            // LogWindow_rBox
            // 
            this.LogWindow_rBox.Location = new System.Drawing.Point(9, 15);
            this.LogWindow_rBox.Name = "LogWindow_rBox";
            this.LogWindow_rBox.Size = new System.Drawing.Size(284, 393);
            this.LogWindow_rBox.TabIndex = 10;
            this.LogWindow_rBox.Text = "";
            // 
            // userSetting_grBox
            // 
            this.userSetting_grBox.Controls.Add(this.difficulty_comboBox);
            this.userSetting_grBox.Controls.Add(this.difficulty_label);
            this.userSetting_grBox.Controls.Add(this.hidingTime_comboBox);
            this.userSetting_grBox.Controls.Add(this.hideTime_label);
            this.userSetting_grBox.Controls.Add(this.gameTime_label);
            this.userSetting_grBox.Controls.Add(this.gameTime_comboBox);
            this.userSetting_grBox.Location = new System.Drawing.Point(9, 26);
            this.userSetting_grBox.Name = "userSetting_grBox";
            this.userSetting_grBox.Size = new System.Drawing.Size(202, 147);
            this.userSetting_grBox.TabIndex = 11;
            this.userSetting_grBox.TabStop = false;
            this.userSetting_grBox.Text = "Game Settings";
            // 
            // DomoticzLog_grBox
            // 
            this.DomoticzLog_grBox.Controls.Add(this.LogWindow_rBox);
            this.DomoticzLog_grBox.Location = new System.Drawing.Point(820, 13);
            this.DomoticzLog_grBox.Name = "DomoticzLog_grBox";
            this.DomoticzLog_grBox.Size = new System.Drawing.Size(302, 420);
            this.DomoticzLog_grBox.TabIndex = 12;
            this.DomoticzLog_grBox.TabStop = false;
            this.DomoticzLog_grBox.Text = "Log";
            // 
            // gameSettings_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 590);
            this.Controls.Add(this.DomoticzLog_grBox);
            this.Controls.Add(this.userSetting_grBox);
            this.Controls.Add(this.endGame_btn);
            this.Controls.Add(this.startGame_btn);
            this.Controls.Add(this.mainGame_panel);
            this.Controls.Add(this.returnMain_btn);
            this.Name = "gameSettings_Page";
            this.Text = "Game settings";
            this.userSetting_grBox.ResumeLayout(false);
            this.userSetting_grBox.PerformLayout();
            this.DomoticzLog_grBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox gameTime_comboBox;
        private System.Windows.Forms.Label gameTime_label;
        private System.Windows.Forms.Label hideTime_label;
        private System.Windows.Forms.ComboBox hidingTime_comboBox;
        private System.Windows.Forms.Label difficulty_label;
        private System.Windows.Forms.ComboBox difficulty_comboBox;
        private System.Windows.Forms.Button returnMain_btn;
        private System.Windows.Forms.Panel mainGame_panel;
        private System.Windows.Forms.Button startGame_btn;
        private System.Windows.Forms.Button endGame_btn;
        private System.Windows.Forms.RichTextBox LogWindow_rBox;
        private System.Windows.Forms.GroupBox userSetting_grBox;
        private System.Windows.Forms.GroupBox DomoticzLog_grBox;
    }
}