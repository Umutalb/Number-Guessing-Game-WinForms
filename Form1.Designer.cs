namespace NumberGuessGameWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNumber = new Label();
            txtGuess = new TextBox();
            lblTitle = new Label();
            btnGuess = new Button();
            lblMessage = new Label();
            lblLives = new Label();
            btnReset = new Button();
            lblLast = new Label();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNumber.Location = new Point(52, 162);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(80, 22);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Number:";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGuess.Location = new Point(151, 160);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 29);
            txtGuess.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(52, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(604, 23);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "I picked a number between 1 and 100. Can you guess it?";
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.CornflowerBlue;
            btnGuess.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGuess.ForeColor = Color.Blue;
            btnGuess.Location = new Point(310, 159);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(97, 31);
            btnGuess.TabIndex = 3;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMessage.Location = new Point(52, 229);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(90, 22);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Message:";
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.Font = new Font("Consolas", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblLives.Location = new Point(52, 89);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(60, 22);
            lblLives.TabIndex = 5;
            lblLives.Text = "Lives";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnReset.ForeColor = Color.Silver;
            btnReset.Location = new Point(52, 289);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLast.Location = new Point(453, 162);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(150, 22);
            lblLast.TabIndex = 7;
            lblLast.Text = "Latest number:";
            lblLast.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnGuess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(750, 438);
            Controls.Add(lblLast);
            Controls.Add(btnReset);
            Controls.Add(lblLives);
            Controls.Add(lblMessage);
            Controls.Add(btnGuess);
            Controls.Add(lblTitle);
            Controls.Add(txtGuess);
            Controls.Add(lblNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Number Guessing Game v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label lblTitle;
        private Button btnGuess;
        private Label lblMessage;
        private Label lblLives;
        private Label lblNumber;
        private TextBox txtGuess;
        private Button btnReset;
        private Label lblLast;
    }
}
