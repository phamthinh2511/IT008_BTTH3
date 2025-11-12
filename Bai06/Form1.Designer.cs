using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai06
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
            this.SuspendLayout();

            this.menuStrip1 = new MenuStrip();
            this.editToolStripMenuItem = new ToolStripMenuItem("&Edit");
            this.viewToolStripMenuItem = new ToolStripMenuItem("&View");
            this.helpToolStripMenuItem = new ToolStripMenuItem("&Help");
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.editToolStripMenuItem, this.viewToolStripMenuItem, this.helpToolStripMenuItem
            });
            this.Controls.Add(this.menuStrip1);

            this.txtDisplay = new TextBox();
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Text = "0";
            this.txtDisplay.Font = new Font("Arial", 14F, FontStyle.Bold);
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            this.txtDisplay.Size = new Size(221, 29);
            this.txtDisplay.Location = new Point(12, 35);
            this.Controls.Add(this.txtDisplay);

            this.lblMemoryIndicator = new Label();
            this.lblMemoryIndicator.BorderStyle = BorderStyle.Fixed3D;
            this.lblMemoryIndicator.Size = new Size(30, 30);
            this.lblMemoryIndicator.Location = new Point(12, 75);
            this.lblMemoryIndicator.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMemoryIndicator.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.Controls.Add(this.lblMemoryIndicator);

            this.Text = "Calculator";
            this.ClientSize = new Size(265, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.buttons = new Button[buttonTexts.Length];
            int btnWidth = 35;
            int btnHeight = 30;
            int startX = 50;
            int startY = 75;
            int spacing = 6;

            int currentX = startX;
            int currentY = startY;

            for (int i = 0; i < buttonTexts.Length; i++)
            {
                this.buttons[i] = new Button();
                this.buttons[i].Text = buttonTexts[i];
                this.buttons[i].Name = "btn" + buttonTexts[i];

                if (buttonTexts[i] == "Backspace")
                {

                    this.buttons[i].Size = new Size(60, btnHeight);
                    currentX = 50;
                }
                else if (buttonTexts[i] == "CE")
                {
                    this.buttons[i].Size = new Size(60, btnHeight);
                    currentX = 116;
                }
                else if (buttonTexts[i] == "C")
                {
                    this.buttons[i].Size = new Size(60, btnHeight);
                    currentX = 182;
                }
                else if (buttonTexts[i] == "MC")
                {
                    currentY = 111;
                    currentX = 12;
                    this.buttons[i].Size = new Size(btnWidth, btnHeight);
                }
                else
                {

                    this.buttons[i].Size = new Size(btnWidth, btnHeight);
                }

                this.buttons[i].Location = new Point(currentX, currentY);


                string text = buttonTexts[i];
                if ("0123456789.".Contains(text))
                {
                    this.buttons[i].Click += new EventHandler(this.numberButton_Click);
                }
                else if ("+-*/".Contains(text))
                {
                    this.buttons[i].Click += new EventHandler(this.operatorButton_Click);
                }
                else if ("sqrt,%,1/x,+/-".Contains(text))
                {
                    this.buttons[i].Click += new EventHandler(this.unaryOperator_Click);
                }
                else if (text == "=")
                {
                    this.buttons[i].Click += new EventHandler(this.equalsButton_Click);
                }
                else if (text == "C")
                {
                    this.buttons[i].Click += new EventHandler(this.clearButton_Click);
                }
                else if (text == "CE")
                {
                    this.buttons[i].Click += new EventHandler(this.clearEntryButton_Click);
                }
                else if (text == "Backspace")
                {
                    this.buttons[i].Click += new EventHandler(this.backspaceButton_Click);
                }
                else if ("MC,MR,MS,M+".Contains(text))
                {
                    this.buttons[i].Click += new EventHandler(this.memoryButton_Click);
                }
                if (i > 2)
                {
                    currentX += btnWidth + spacing;
                    if (currentX > 220)
                    {
                        currentX = 12;
                        currentY += btnHeight + spacing;
                    }
                }
                this.Controls.Add(this.buttons[i]);
            }

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox txtDisplay;
        private Label lblMemoryIndicator;
        private Button[] buttons;
        private string[] buttonTexts = new string[] {
                "Backspace", "CE", "C",
                "MC", "7", "8", "9", "/", "sqrt",
                "MR", "4", "5", "6", "*", "%",
                "MS", "1", "2", "3", "-", "1/x",
                "M+", "0", "+/-", ".", "+", "="
            };
    }
}
