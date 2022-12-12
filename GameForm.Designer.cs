namespace Game_of_immigration
{
    partial class GameForm
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
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.hUpDown = new System.Windows.Forms.NumericUpDown();
            this.wUpDown = new System.Windows.Forms.NumericUpDown();
            this.itUpDown = new System.Windows.Forms.NumericUpDown();
            this.pButton = new System.Windows.Forms.Button();
            this.hLabel = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            this.itLabel = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Button();
            this.dUpDown = new System.Windows.Forms.NumericUpDown();
            this.dLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(255, 5);
            this.mapBox.Margin = new System.Windows.Forms.Padding(0);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(500, 500);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            // 
            // hUpDown
            // 
            this.hUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hUpDown.Location = new System.Drawing.Point(105, 5);
            this.hUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hUpDown.Name = "hUpDown";
            this.hUpDown.Size = new System.Drawing.Size(145, 27);
            this.hUpDown.TabIndex = 1;
            this.hUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // wUpDown
            // 
            this.wUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wUpDown.Location = new System.Drawing.Point(105, 37);
            this.wUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wUpDown.Name = "wUpDown";
            this.wUpDown.Size = new System.Drawing.Size(145, 27);
            this.wUpDown.TabIndex = 2;
            this.wUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // itUpDown
            // 
            this.itUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.itUpDown.Location = new System.Drawing.Point(105, 69);
            this.itUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.itUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.itUpDown.Name = "itUpDown";
            this.itUpDown.Size = new System.Drawing.Size(145, 27);
            this.itUpDown.TabIndex = 3;
            this.itUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pButton
            // 
            this.pButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pButton.Location = new System.Drawing.Point(105, 133);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(145, 27);
            this.pButton.TabIndex = 4;
            this.pButton.Text = "Play";
            this.pButton.UseVisualStyleBackColor = false;
            this.pButton.Click += new System.EventHandler(this.pButton_Click);
            // 
            // hLabel
            // 
            this.hLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hLabel.Location = new System.Drawing.Point(5, 5);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(95, 27);
            this.hLabel.TabIndex = 5;
            this.hLabel.Text = "Height";
            this.hLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wLabel
            // 
            this.wLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wLabel.Location = new System.Drawing.Point(5, 37);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(95, 27);
            this.wLabel.TabIndex = 6;
            this.wLabel.Text = "Width";
            this.wLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itLabel
            // 
            this.itLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itLabel.Location = new System.Drawing.Point(5, 69);
            this.itLabel.Name = "itLabel";
            this.itLabel.Size = new System.Drawing.Size(95, 27);
            this.itLabel.TabIndex = 7;
            this.itLabel.Text = "Iterations";
            this.itLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rButton.Location = new System.Drawing.Point(105, 165);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(145, 27);
            this.rButton.TabIndex = 8;
            this.rButton.Text = "Randomize";
            this.rButton.UseVisualStyleBackColor = false;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // dUpDown
            // 
            this.dUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dUpDown.Location = new System.Drawing.Point(105, 101);
            this.dUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dUpDown.Name = "dUpDown";
            this.dUpDown.Size = new System.Drawing.Size(145, 27);
            this.dUpDown.TabIndex = 3;
            this.dUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // dLabel
            // 
            this.dLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dLabel.Location = new System.Drawing.Point(5, 101);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(95, 27);
            this.dLabel.TabIndex = 7;
            this.dLabel.Text = "Density";
            this.dLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.itLabel);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.dUpDown);
            this.Controls.Add(this.itUpDown);
            this.Controls.Add(this.wUpDown);
            this.Controls.Add(this.hUpDown);
            this.Controls.Add(this.mapBox);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Immigration";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox mapBox;
        private NumericUpDown hUpDown;
        private NumericUpDown wUpDown;
        private NumericUpDown itUpDown;
        private Button pButton;
        private Label hLabel;
        private Label wLabel;
        private Label itLabel;
        private Button rButton;
        private NumericUpDown dUpDown;
        private Label dLabel;
    }
}