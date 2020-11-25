namespace LinyxPainter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PaintButtons = new System.Windows.Forms.Panel();
            this.WidthBtn = new System.Windows.Forms.Button();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EraserBtn = new System.Windows.Forms.Button();
            this.RectBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.PencilBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.Painter = new System.Windows.Forms.PictureBox();
            this.PaintButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Painter)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintButtons
            // 
            this.PaintButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintButtons.Controls.Add(this.WidthBtn);
            this.PaintButtons.Controls.Add(this.WidthText);
            this.PaintButtons.Controls.Add(this.ColorBtn);
            this.PaintButtons.Controls.Add(this.EraserBtn);
            this.PaintButtons.Controls.Add(this.RectBtn);
            this.PaintButtons.Controls.Add(this.CircleBtn);
            this.PaintButtons.Controls.Add(this.LineBtn);
            this.PaintButtons.Controls.Add(this.PencilBtn);
            this.PaintButtons.Controls.Add(this.ClearBtn);
            this.PaintButtons.Controls.Add(this.SaveBtn);
            this.PaintButtons.Controls.Add(this.OpenBtn);
            this.PaintButtons.Location = new System.Drawing.Point(13, 13);
            this.PaintButtons.Name = "PaintButtons";
            this.PaintButtons.Size = new System.Drawing.Size(96, 369);
            this.PaintButtons.TabIndex = 1;
            // 
            // WidthBtn
            // 
            this.WidthBtn.Font = new System.Drawing.Font("宋体", 6F);
            this.WidthBtn.Location = new System.Drawing.Point(50, 319);
            this.WidthBtn.Name = "WidthBtn";
            this.WidthBtn.Size = new System.Drawing.Size(40, 40);
            this.WidthBtn.TabIndex = 10;
            this.WidthBtn.TabStop = false;
            this.WidthBtn.Text = "Set Width";
            this.WidthBtn.UseVisualStyleBackColor = true;
            this.WidthBtn.Click += new System.EventHandler(this.WidthBtn_Click);
            // 
            // WidthText
            // 
            this.WidthText.Font = new System.Drawing.Font("Arial Narrow", 17F);
            this.WidthText.Location = new System.Drawing.Point(4, 319);
            this.WidthText.Name = "WidthText";
            this.WidthText.Size = new System.Drawing.Size(40, 40);
            this.WidthText.TabIndex = 9;
            this.WidthText.TabStop = false;
            this.WidthText.Text = "2";
            // 
            // ColorBtn
            // 
            this.ColorBtn.BackColor = System.Drawing.Color.Black;
            this.ColorBtn.Location = new System.Drawing.Point(4, 273);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(40, 40);
            this.ColorBtn.TabIndex = 8;
            this.ColorBtn.TabStop = false;
            this.ColorBtn.UseVisualStyleBackColor = false;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "PNG";
            this.saveFileDialog.Filter = "PNG(*.png)|*.png|JPEG(*.jpg;*.jpeg)|*.jpg";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "PNG";
            this.openFileDialog.Filter = "PNG(*.png)|*.png|JPEG(*.jpg;*.jpeg)|*.jpg";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // EraserBtn
            // 
            this.EraserBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.eraser;
            this.EraserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EraserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserBtn.Location = new System.Drawing.Point(50, 119);
            this.EraserBtn.Name = "EraserBtn";
            this.EraserBtn.Size = new System.Drawing.Size(40, 40);
            this.EraserBtn.TabIndex = 7;
            this.EraserBtn.TabStop = false;
            this.EraserBtn.UseVisualStyleBackColor = true;
            this.EraserBtn.Click += new System.EventHandler(this.EraserBtn_Click);
            // 
            // RectBtn
            // 
            this.RectBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.rectangle;
            this.RectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectBtn.Location = new System.Drawing.Point(4, 211);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(40, 40);
            this.RectBtn.TabIndex = 6;
            this.RectBtn.TabStop = false;
            this.RectBtn.UseVisualStyleBackColor = true;
            this.RectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.circle;
            this.CircleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleBtn.Location = new System.Drawing.Point(50, 165);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(40, 40);
            this.CircleBtn.TabIndex = 5;
            this.CircleBtn.TabStop = false;
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.line;
            this.LineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineBtn.Location = new System.Drawing.Point(4, 165);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(40, 40);
            this.LineBtn.TabIndex = 4;
            this.LineBtn.TabStop = false;
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // PencilBtn
            // 
            this.PencilBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.pencil;
            this.PencilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PencilBtn.Location = new System.Drawing.Point(4, 119);
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(40, 40);
            this.PencilBtn.TabIndex = 3;
            this.PencilBtn.TabStop = false;
            this.PencilBtn.UseVisualStyleBackColor = true;
            this.PencilBtn.Click += new System.EventHandler(this.PencilBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(4, 50);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(40, 40);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.TabStop = false;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.save;
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(50, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.TabStop = false;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackgroundImage = global::LinyxPainter.Properties.Resources.open;
            this.OpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Location = new System.Drawing.Point(4, 4);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(40, 40);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.TabStop = false;
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // Painter
            // 
            this.Painter.Location = new System.Drawing.Point(0, 0);
            this.Painter.Name = "Painter";
            this.Painter.Size = new System.Drawing.Size(1280, 720);
            this.Painter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Painter.TabIndex = 0;
            this.Painter.TabStop = false;
            this.Painter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseDown);
            this.Painter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseMove);
            this.Painter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 527);
            this.Controls.Add(this.PaintButtons);
            this.Controls.Add(this.Painter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "LinyxPainter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PaintButtons.ResumeLayout(false);
            this.PaintButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Painter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Painter;
        private System.Windows.Forms.Panel PaintButtons;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button PencilBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button RectBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button EraserBtn;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.TextBox WidthText;
        private System.Windows.Forms.Button WidthBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

