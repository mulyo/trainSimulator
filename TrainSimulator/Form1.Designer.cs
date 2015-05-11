namespace TrainSimulator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.avanzarTrenBtn = new System.Windows.Forms.Button();
            this.trainPictureBox = new System.Windows.Forms.PictureBox();
            this.railwayPictureBox = new System.Windows.Forms.PictureBox();
            this.stationsPictureBox = new System.Windows.Forms.PictureBox();
            this.trainTimer = new System.Windows.Forms.Timer(this.components);
            this.operarGenteBtn = new System.Windows.Forms.Button();
            this.fromTrainToStationTimer = new System.Windows.Forms.Timer(this.components);
            this.fromStationToTrainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railwayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comandos:";
            // 
            // avanzarTrenBtn
            // 
            this.avanzarTrenBtn.Location = new System.Drawing.Point(34, 88);
            this.avanzarTrenBtn.Name = "avanzarTrenBtn";
            this.avanzarTrenBtn.Size = new System.Drawing.Size(84, 24);
            this.avanzarTrenBtn.TabIndex = 2;
            this.avanzarTrenBtn.Text = "Avanzar tren";
            this.avanzarTrenBtn.UseVisualStyleBackColor = true;
            this.avanzarTrenBtn.Click += new System.EventHandler(this.avanzarTrenBtn_Click);
            // 
            // trainPictureBox
            // 
            this.trainPictureBox.Location = new System.Drawing.Point(-3, 323);
            this.trainPictureBox.Name = "trainPictureBox";
            this.trainPictureBox.Size = new System.Drawing.Size(947, 198);
            this.trainPictureBox.TabIndex = 5;
            this.trainPictureBox.TabStop = false;
            this.trainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.trainPictureBox_Paint);
            // 
            // railwayPictureBox
            // 
            this.railwayPictureBox.Location = new System.Drawing.Point(0, 517);
            this.railwayPictureBox.Name = "railwayPictureBox";
            this.railwayPictureBox.Size = new System.Drawing.Size(947, 49);
            this.railwayPictureBox.TabIndex = 6;
            this.railwayPictureBox.TabStop = false;
            this.railwayPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.railwayPictureBox_Paint);
            // 
            // stationsPictureBox
            // 
            this.stationsPictureBox.Location = new System.Drawing.Point(0, 131);
            this.stationsPictureBox.Name = "stationsPictureBox";
            this.stationsPictureBox.Size = new System.Drawing.Size(947, 123);
            this.stationsPictureBox.TabIndex = 7;
            this.stationsPictureBox.TabStop = false;
            this.stationsPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.stationsPictureBox_Paint);
            // 
            // trainTimer
            // 
            this.trainTimer.Tick += new System.EventHandler(this.train_Tick);
            // 
            // operarGenteBtn
            // 
            this.operarGenteBtn.Location = new System.Drawing.Point(34, 44);
            this.operarGenteBtn.Name = "operarGenteBtn";
            this.operarGenteBtn.Size = new System.Drawing.Size(84, 38);
            this.operarGenteBtn.TabIndex = 8;
            this.operarGenteBtn.Text = "Bajar/Subir gente";
            this.operarGenteBtn.UseVisualStyleBackColor = true;
            this.operarGenteBtn.Click += new System.EventHandler(this.operarGenteBtn_Click);
            // 
            // fromStationToTrainTimer
            // 
            this.fromStationToTrainTimer.Tick += new System.EventHandler(this.fromStationToTrain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 598);
            this.Controls.Add(this.operarGenteBtn);
            this.Controls.Add(this.stationsPictureBox);
            this.Controls.Add(this.railwayPictureBox);
            this.Controls.Add(this.trainPictureBox);
            this.Controls.Add(this.avanzarTrenBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railwayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button avanzarTrenBtn;
        private System.Windows.Forms.PictureBox trainPictureBox;
        private System.Windows.Forms.PictureBox railwayPictureBox;
        private System.Windows.Forms.PictureBox stationsPictureBox;
        private System.Windows.Forms.Timer trainTimer;
        private System.Windows.Forms.Button operarGenteBtn;
        private System.Windows.Forms.Timer fromTrainToStationTimer;
        private System.Windows.Forms.Timer fromStationToTrainTimer;
    }
}

