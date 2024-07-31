namespace PaintApplication_Forms
{
    partial class PaintApplication_Form
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
            panel1 = new Panel();
            panel2 = new Panel();
            BtnClear = new Button();
            BtnSave = new Button();
            BtnDrawLine = new Button();
            BtnDrawSquare = new Button();
            BtnDrawEllipse = new Button();
            BtnEraser = new Button();
            BtnPencil = new Button();
            BtnFill = new Button();
            BtnColour = new Button();
            PickColour = new Button();
            panel3 = new Panel();
            PboxPaint = new PictureBox();
            ColorPalette = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PboxPaint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorPalette).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 144);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(BtnClear);
            panel2.Controls.Add(BtnSave);
            panel2.Controls.Add(BtnDrawLine);
            panel2.Controls.Add(BtnDrawSquare);
            panel2.Controls.Add(BtnDrawEllipse);
            panel2.Controls.Add(BtnEraser);
            panel2.Controls.Add(BtnPencil);
            panel2.Controls.Add(BtnFill);
            panel2.Controls.Add(BtnColour);
            panel2.Controls.Add(PickColour);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 141);
            panel2.TabIndex = 1;
            // 
            // BtnClear
            // 
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(668, 102);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnSave
            // 
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(587, 102);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnDrawLine
            // 
            BtnDrawLine.BackColor = Color.FromArgb(64, 64, 64);
            BtnDrawLine.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDrawLine.FlatStyle = FlatStyle.Flat;
            BtnDrawLine.ForeColor = Color.White;
            BtnDrawLine.Image = Properties.Resources.line;
            BtnDrawLine.Location = new Point(803, 19);
            BtnDrawLine.Name = "BtnDrawLine";
            BtnDrawLine.Size = new Size(48, 48);
            BtnDrawLine.TabIndex = 9;
            BtnDrawLine.TextAlign = ContentAlignment.BottomCenter;
            BtnDrawLine.UseVisualStyleBackColor = false;
            BtnDrawLine.Click += BtnDrawLine_Click;
            // 
            // BtnDrawSquare
            // 
            BtnDrawSquare.BackColor = Color.FromArgb(64, 64, 64);
            BtnDrawSquare.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDrawSquare.FlatStyle = FlatStyle.Flat;
            BtnDrawSquare.ForeColor = Color.White;
            BtnDrawSquare.Image = Properties.Resources.rectangle;
            BtnDrawSquare.Location = new Point(749, 19);
            BtnDrawSquare.Name = "BtnDrawSquare";
            BtnDrawSquare.Size = new Size(48, 48);
            BtnDrawSquare.TabIndex = 8;
            BtnDrawSquare.TextAlign = ContentAlignment.BottomCenter;
            BtnDrawSquare.UseVisualStyleBackColor = false;
            BtnDrawSquare.Click += BtnDrawSquare_Click;
            // 
            // BtnDrawEllipse
            // 
            BtnDrawEllipse.BackColor = Color.FromArgb(64, 64, 64);
            BtnDrawEllipse.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDrawEllipse.FlatStyle = FlatStyle.Flat;
            BtnDrawEllipse.ForeColor = Color.White;
            BtnDrawEllipse.Image = Properties.Resources.circle;
            BtnDrawEllipse.Location = new Point(695, 19);
            BtnDrawEllipse.Name = "BtnDrawEllipse";
            BtnDrawEllipse.Size = new Size(48, 48);
            BtnDrawEllipse.TabIndex = 7;
            BtnDrawEllipse.TextAlign = ContentAlignment.BottomCenter;
            BtnDrawEllipse.UseVisualStyleBackColor = false;
            BtnDrawEllipse.Click += BtnDrawEllipse_Click;
            // 
            // BtnEraser
            // 
            BtnEraser.BackColor = Color.FromArgb(64, 64, 64);
            BtnEraser.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEraser.FlatStyle = FlatStyle.Flat;
            BtnEraser.ForeColor = Color.White;
            BtnEraser.Image = Properties.Resources.eraser;
            BtnEraser.Location = new Point(641, 19);
            BtnEraser.Name = "BtnEraser";
            BtnEraser.Size = new Size(48, 48);
            BtnEraser.TabIndex = 6;
            BtnEraser.TextAlign = ContentAlignment.BottomCenter;
            BtnEraser.UseVisualStyleBackColor = false;
            BtnEraser.Click += BtnEraser_Click;
            // 
            // BtnPencil
            // 
            BtnPencil.BackColor = Color.FromArgb(64, 64, 64);
            BtnPencil.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPencil.FlatStyle = FlatStyle.Flat;
            BtnPencil.ForeColor = Color.White;
            BtnPencil.Image = Properties.Resources.pencil;
            BtnPencil.Location = new Point(587, 19);
            BtnPencil.Name = "BtnPencil";
            BtnPencil.Size = new Size(48, 48);
            BtnPencil.TabIndex = 5;
            BtnPencil.TextAlign = ContentAlignment.BottomCenter;
            BtnPencil.UseVisualStyleBackColor = false;
            BtnPencil.Click += BtnPencil_Click;
            // 
            // BtnFill
            // 
            BtnFill.BackColor = Color.FromArgb(64, 64, 64);
            BtnFill.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFill.FlatStyle = FlatStyle.Flat;
            BtnFill.ForeColor = Color.White;
            BtnFill.Image = Properties.Resources.bucket;
            BtnFill.Location = new Point(533, 19);
            BtnFill.Name = "BtnFill";
            BtnFill.Size = new Size(48, 48);
            BtnFill.TabIndex = 4;
            BtnFill.TextAlign = ContentAlignment.BottomCenter;
            BtnFill.UseVisualStyleBackColor = false;
            BtnFill.Click += BtnFill_Click;
            // 
            // BtnColour
            // 
            BtnColour.BackColor = Color.FromArgb(64, 64, 64);
            BtnColour.BackgroundImageLayout = ImageLayout.Stretch;
            BtnColour.FlatStyle = FlatStyle.Flat;
            BtnColour.ForeColor = Color.White;
            BtnColour.Image = Properties.Resources.color;
            BtnColour.Location = new Point(479, 19);
            BtnColour.Name = "BtnColour";
            BtnColour.Size = new Size(48, 48);
            BtnColour.TabIndex = 3;
            BtnColour.UseVisualStyleBackColor = false;
            BtnColour.Click += BtnColour_Click;
            // 
            // PickColour
            // 
            PickColour.BackColor = Color.White;
            PickColour.Location = new Point(428, 53);
            PickColour.Name = "PickColour";
            PickColour.Size = new Size(35, 35);
            PickColour.TabIndex = 3;
            PickColour.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 614);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 26);
            panel3.TabIndex = 1;
            // 
            // PboxPaint
            // 
            PboxPaint.BackColor = Color.White;
            PboxPaint.Dock = DockStyle.Fill;
            PboxPaint.Location = new Point(0, 0);
            PboxPaint.Name = "PboxPaint";
            PboxPaint.Size = new Size(886, 640);
            PboxPaint.TabIndex = 2;
            PboxPaint.TabStop = false;
            PboxPaint.Paint += PboxPaint_Paint;
            PboxPaint.MouseClick += PboxPaint_MouseClick;
            PboxPaint.MouseDown += PboxPaint_MouseDown;
            PboxPaint.MouseMove += PboxPaint_MouseMove;
            PboxPaint.MouseUp += PboxPaint_MouseUp;
            // 
            // ColorPalette
            // 
            ColorPalette.BackColor = Color.FromArgb(64, 64, 64);
            ColorPalette.Image = Properties.Resources.color_palette;
            ColorPalette.Location = new Point(0, 3);
            ColorPalette.Name = "ColorPalette";
            ColorPalette.Size = new Size(412, 135);
            ColorPalette.SizeMode = PictureBoxSizeMode.StretchImage;
            ColorPalette.TabIndex = 3;
            ColorPalette.TabStop = false;
            ColorPalette.MouseClick += ColorPalette_MouseClick;
            // 
            // PaintApplication_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 640);
            Controls.Add(ColorPalette);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(PboxPaint);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PaintApplication_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint Application";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PboxPaint).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorPalette).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox PboxPaint;
        private Button PickColour;
        private Button BtnColour;
        private Button BtnEraser;
        private Button BtnPencil;
        private Button BtnFill;
        private Button BtnDrawLine;
        private Button BtnDrawSquare;
        private Button BtnDrawEllipse;
        private Button BtnClear;
        private Button BtnSave;
        private PictureBox ColorPalette;
    }
}
