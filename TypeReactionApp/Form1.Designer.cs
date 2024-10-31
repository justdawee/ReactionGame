namespace TypeReactionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_randomLetter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_reaction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_reactionTimes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_average = new System.Windows.Forms.Label();
            this.label_std = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askBeforeOverwriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_actualMeasurement = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_randomLetter
            // 
            this.label_randomLetter.Font = new System.Drawing.Font("Open Sans", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_randomLetter.Location = new System.Drawing.Point(12, 46);
            this.label_randomLetter.Name = "label_randomLetter";
            this.label_randomLetter.Size = new System.Drawing.Size(169, 199);
            this.label_randomLetter.TabIndex = 4;
            this.label_randomLetter.Text = "-";
            this.label_randomLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Betű:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBox_reaction
            // 
            this.txtBox_reaction.Location = new System.Drawing.Point(12, 263);
            this.txtBox_reaction.Name = "txtBox_reaction";
            this.txtBox_reaction.Size = new System.Drawing.Size(169, 22);
            this.txtBox_reaction.TabIndex = 0;
            this.txtBox_reaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_reaction_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szövegdoboz:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox_reactionTimes
            // 
            this.listBox_reactionTimes.FormattingEnabled = true;
            this.listBox_reactionTimes.ItemHeight = 15;
            this.listBox_reactionTimes.Location = new System.Drawing.Point(201, 46);
            this.listBox_reactionTimes.Name = "listBox_reactionTimes";
            this.listBox_reactionTimes.Size = new System.Drawing.Size(169, 199);
            this.listBox_reactionTimes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(201, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Átlag reakcióidő: ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(201, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Általános eloszlás: ";
            // 
            // label_average
            // 
            this.label_average.Location = new System.Drawing.Point(311, 250);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(59, 20);
            this.label_average.TabIndex = 4;
            this.label_average.Text = "0 ms";
            this.label_average.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_std
            // 
            this.label_std.Location = new System.Drawing.Point(311, 270);
            this.label_std.Name = "label_std";
            this.label_std.Size = new System.Drawing.Size(59, 20);
            this.label_std.TabIndex = 4;
            this.label_std.Text = "0 ms";
            this.label_std.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(201, 296);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(169, 34);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Kilépés";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 296);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(169, 34);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Indítás";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.optionsToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.loadToolStripMenuItem, this.loadFromToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "Fájl";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.saveToolStripMenuItem.Text = "Mentés";
            this.saveToolStripMenuItem.ToolTipText = "Jelenlegi lista mentése.";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Alt + S";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.saveAsToolStripMenuItem.Text = "Mentés másként...";
            this.saveAsToolStripMenuItem.ToolTipText = "Mentés egy kiválasztott helyre...";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.loadToolStripMenuItem.Text = "Betöltés";
            this.loadToolStripMenuItem.ToolTipText = "Előző mentés betöltése.";
            // 
            // loadFromToolStripMenuItem
            // 
            this.loadFromToolStripMenuItem.Name = "loadFromToolStripMenuItem";
            this.loadFromToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Alt + O";
            this.loadFromToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) | System.Windows.Forms.Keys.O)));
            this.loadFromToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.loadFromToolStripMenuItem.Text = "Betöltés fájlból...";
            this.loadFromToolStripMenuItem.ToolTipText = "Betöltés egy kiválaszott fájlból...";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Checked = true;
            this.optionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.askBeforeOverwriteToolStripMenuItem });
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.optionsToolStripMenuItem.Text = "Beállítások";
            // 
            // askBeforeOverwriteToolStripMenuItem
            // 
            this.askBeforeOverwriteToolStripMenuItem.Checked = true;
            this.askBeforeOverwriteToolStripMenuItem.CheckOnClick = true;
            this.askBeforeOverwriteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askBeforeOverwriteToolStripMenuItem.Name = "askBeforeOverwriteToolStripMenuItem";
            this.askBeforeOverwriteToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.askBeforeOverwriteToolStripMenuItem.Text = "Kérdezz, mielőtt felülírnád a próbálkozások listáját";
            // 
            // label_actualMeasurement
            // 
            this.label_actualMeasurement.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_actualMeasurement.Location = new System.Drawing.Point(135, 239);
            this.label_actualMeasurement.Name = "label_actualMeasurement";
            this.label_actualMeasurement.Size = new System.Drawing.Size(46, 23);
            this.label_actualMeasurement.TabIndex = 6;
            this.label_actualMeasurement.Text = "0/12";
            this.label_actualMeasurement.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 344);
            this.Controls.Add(this.label_actualMeasurement);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label_std);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_reactionTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_reaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_randomLetter);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Reaction App®";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem askBeforeOverwriteToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

        private System.Windows.Forms.Label label_actualMeasurement;

        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;

        private System.Windows.Forms.Button btn_Start;

        private System.Windows.Forms.Button btn_Exit;

        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label_std;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ListBox listBox_reactionTimes;

        private System.Windows.Forms.TextBox txtBox_reaction;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label_randomLetter;

        #endregion
    }
}