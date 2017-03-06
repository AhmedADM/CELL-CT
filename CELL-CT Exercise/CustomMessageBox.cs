using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELL_CT_Exercise
{
    class CustomMessageBox : Form
    {
        private Button FirstButton;
        private Button SecondButton;
        private Panel Message;

        private static CustomMessageBox MessageBox;
        private Label MessageContent;
        private static string result = "Cancel";


        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Panel();
            this.MessageContent = new System.Windows.Forms.Label();
            this.Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(137, 92);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(123, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "button1";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(486, 92);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(123, 23);
            this.SecondButton.TabIndex = 1;
            this.SecondButton.Text = "button2";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Message.Controls.Add(this.MessageContent);
            this.Message.Location = new System.Drawing.Point(0, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(746, 74);
            this.Message.TabIndex = 2;
            // 
            // MessageContent
            // 
            this.MessageContent.AutoSize = true;
            this.MessageContent.Location = new System.Drawing.Point(111, 9);
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.Size = new System.Drawing.Size(35, 13);
            this.MessageContent.TabIndex = 0;
            this.MessageContent.Text = "label1";
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(746, 134);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Message.ResumeLayout(false);
            this.Message.PerformLayout();
            this.ResumeLayout(false);

        }


        public static string  Show(String Text, String Caption, String firstButton, String secondButton)
        {
            MessageBox = new CustomMessageBox();

            //Initlaize Message Content
            MessageBox.MessageContent.Text = Text;

            //Initlialize First and Second buttons
            MessageBox.FirstButton.Text = firstButton;
            MessageBox.SecondButton.Text = secondButton;
            result = "Cancel";
            MessageBox.ShowDialog();

            return result;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessageBox.Close();
            var button = ((Button)sender);

            result = button.Name;
        }

     
    }
}
