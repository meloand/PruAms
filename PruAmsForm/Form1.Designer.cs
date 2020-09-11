namespace PruAmsForm
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
        protected override void Dispose( bool disposing )
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenuSPAJ = new System.Windows.Forms.Button();
            this.buttonMenuAgent = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(256, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency Management System";
            // 
            // buttonMenuSPAJ
            // 
            this.buttonMenuSPAJ.Location = new System.Drawing.Point(304, 78);
            this.buttonMenuSPAJ.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenuSPAJ.Name = "buttonMenuSPAJ";
            this.buttonMenuSPAJ.Size = new System.Drawing.Size(128, 29);
            this.buttonMenuSPAJ.TabIndex = 1;
            this.buttonMenuSPAJ.Text = "SPAJ";
            this.buttonMenuSPAJ.UseVisualStyleBackColor = true;
            this.buttonMenuSPAJ.Click += new System.EventHandler(this.buttonMenuSPAJ_Click);
            // 
            // buttonMenuAgent
            // 
            this.buttonMenuAgent.Location = new System.Drawing.Point(304, 154);
            this.buttonMenuAgent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenuAgent.Name = "buttonMenuAgent";
            this.buttonMenuAgent.Size = new System.Drawing.Size(128, 27);
            this.buttonMenuAgent.TabIndex = 2;
            this.buttonMenuAgent.Text = "Agents";
            this.buttonMenuAgent.UseVisualStyleBackColor = true;
            this.buttonMenuAgent.Click += new System.EventHandler(this.buttonMenuAgent_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.label49);
            this.groupBoxMenu.Controls.Add(this.buttonMenuSPAJ);
            this.groupBoxMenu.Controls.Add(this.buttonMenuAgent);
            this.groupBoxMenu.Location = new System.Drawing.Point(-4, 65);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMenu.Size = new System.Drawing.Size(758, 341);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(242, 29);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(279, 20);
            this.label49.TabIndex = 3;
            this.label49.Text = "What Do You Want To Do Today?";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(696, -1);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(58, 21);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 393);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AMS Home";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuSPAJ;
        private System.Windows.Forms.Button buttonMenuAgent;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label49;
    }
}

