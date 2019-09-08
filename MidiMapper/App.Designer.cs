﻿namespace MidiMapper
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.pressKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.selectInputBox = new System.Windows.Forms.ListBox();
            this.refreshInputButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.eventLog = new System.Windows.Forms.TextBox();
            this.clearEventLogButton = new System.Windows.Forms.Button();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.createMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pressKeyTimer
            // 
            this.pressKeyTimer.Enabled = true;
            this.pressKeyTimer.Tick += new System.EventHandler(this.PressKeyTimer_Tick);
            // 
            // selectInputBox
            // 
            resources.ApplyResources(this.selectInputBox, "selectInputBox");
            this.selectInputBox.FormattingEnabled = true;
            this.selectInputBox.Name = "selectInputBox";
            this.selectInputBox.SelectedIndexChanged += new System.EventHandler(this.SelectInput_SelectedIndexChanged);
            // 
            // refreshInputButton
            // 
            resources.ApplyResources(this.refreshInputButton, "refreshInputButton");
            this.refreshInputButton.Name = "refreshInputButton";
            this.refreshInputButton.UseVisualStyleBackColor = true;
            this.refreshInputButton.Click += new System.EventHandler(this.RefreshInputButton_Click);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // eventLog
            // 
            resources.ApplyResources(this.eventLog, "eventLog");
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            // 
            // clearEventLogButton
            // 
            resources.ApplyResources(this.clearEventLogButton, "clearEventLogButton");
            this.clearEventLogButton.Name = "clearEventLogButton";
            this.clearEventLogButton.UseVisualStyleBackColor = true;
            this.clearEventLogButton.Click += new System.EventHandler(this.ClearEventLogButton_Click);
            // 
            // profileNameTextBox
            // 
            resources.ApplyResources(this.profileNameTextBox, "profileNameTextBox");
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.ReadOnly = true;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // createProfileButton
            // 
            resources.ApplyResources(this.createProfileButton, "createProfileButton");
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.CreateProfileButton_Click);
            // 
            // createMacroButton
            // 
            resources.ApplyResources(this.createMacroButton, "createMacroButton");
            this.createMacroButton.Name = "createMacroButton";
            this.createMacroButton.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createMacroButton);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.clearEventLogButton);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.refreshInputButton);
            this.Controls.Add(this.selectInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer pressKeyTimer;
        private System.Windows.Forms.ListBox selectInputBox;
        private System.Windows.Forms.Button refreshInputButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox eventLog;
        private System.Windows.Forms.Button clearEventLogButton;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.Button createMacroButton;
    }
}

