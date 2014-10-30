namespace AVI_HardSUB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BrowseFile = new System.Windows.Forms.Button();
            this.txtAviFile = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lyric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.HardsubBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseFile
            // 
            this.BrowseFile.Location = new System.Drawing.Point(436, 3);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(75, 23);
            this.BrowseFile.TabIndex = 0;
            this.BrowseFile.Text = "Browse";
            this.BrowseFile.UseVisualStyleBackColor = true;
            this.BrowseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAviFile
            // 
            this.txtAviFile.Enabled = false;
            this.txtAviFile.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAviFile.Location = new System.Drawing.Point(15, 6);
            this.txtAviFile.Name = "txtAviFile";
            this.txtAviFile.Size = new System.Drawing.Size(415, 20);
            this.txtAviFile.TabIndex = 1;
            this.txtAviFile.Text = "Browse Your File";
            this.txtAviFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(133, 302);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 4;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // mediaplayer
            // 
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(15, 41);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(496, 313);
            this.mediaplayer.TabIndex = 7;
            this.mediaplayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaplayer_PlayStateChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Lyric});
            this.dataGridView1.Location = new System.Drawing.Point(529, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 313);
            this.dataGridView1.TabIndex = 10;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Lyric
            // 
            this.Lyric.HeaderText = "Lyric";
            this.Lyric.Name = "Lyric";
            this.Lyric.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lyric.Width = 600;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(529, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(529, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Insert at                   Lyric:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(624, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(910, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Just Double Click To edit";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Save Lyric!!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HardsubBtn
            // 
            this.HardsubBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardsubBtn.Location = new System.Drawing.Point(235, 368);
            this.HardsubBtn.Name = "HardsubBtn";
            this.HardsubBtn.Size = new System.Drawing.Size(195, 33);
            this.HardsubBtn.TabIndex = 19;
            this.HardsubBtn.Text = "HardSub Now !!";
            this.HardsubBtn.UseVisualStyleBackColor = true;
            this.HardsubBtn.Click += new System.EventHandler(this.HardsubBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(888, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Who Make This?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(997, 403);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.HardsubBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mediaplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.txtAviFile);
            this.Controls.Add(this.BrowseFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Let\'s Karaoke";
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.TextBox txtAviFile;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lyric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button HardsubBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

