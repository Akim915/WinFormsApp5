
namespace WinFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCurrentPlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCurrentPlayer = new Label();
            SuspendLayout();
           
            lblCurrentPlayer.AutoSize = true;
            lblCurrentPlayer.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblCurrentPlayer.Location = new Point(350, 150);
            lblCurrentPlayer.Name = "lblCurrentPlayer";
            lblCurrentPlayer.Size = new Size(197, 22);
            lblCurrentPlayer.TabIndex = 0;
            lblCurrentPlayer.Text = "Gracz X rozpoczyna";
            
            ClientSize = new Size(531, 400);
            Controls.Add(lblCurrentPlayer);
            Name = "Form1";
            Text = "Kółko i Krzyżyk";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
