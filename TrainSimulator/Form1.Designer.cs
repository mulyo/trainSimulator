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
            this.avanzarTrenBtn = new System.Windows.Forms.Button();
            this.trainPictureBox = new System.Windows.Forms.PictureBox();
            this.railwayPictureBox = new System.Windows.Forms.PictureBox();
            this.stationsPictureBox = new System.Windows.Forms.PictureBox();
            this.trainTimer = new System.Windows.Forms.Timer(this.components);
            this.operarGenteBtn = new System.Windows.Forms.Button();
            this.fromTrainToStationTimer = new System.Windows.Forms.Timer(this.components);
            this.fromStationToTrainTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEstadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prbEstado = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railwayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // avanzarTrenBtn
            // 
            this.avanzarTrenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avanzarTrenBtn.Location = new System.Drawing.Point(188, 17);
            this.avanzarTrenBtn.Name = "avanzarTrenBtn";
            this.avanzarTrenBtn.Size = new System.Drawing.Size(84, 38);
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
            this.operarGenteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operarGenteBtn.Location = new System.Drawing.Point(81, 17);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarEstadisticasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mostrarEstadisticasToolStripMenuItem
            // 
            this.mostrarEstadisticasToolStripMenuItem.Name = "mostrarEstadisticasToolStripMenuItem";
            this.mostrarEstadisticasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mostrarEstadisticasToolStripMenuItem.Text = "Mostrar Estadisticas";
            this.mostrarEstadisticasToolStripMenuItem.Click += new System.EventHandler(this.mostrarEstadisticasToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prbEstado);
            this.groupBox1.Controls.Add(this.operarGenteBtn);
            this.groupBox1.Controls.Add(this.avanzarTrenBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // prbEstado
            // 
            this.prbEstado.Location = new System.Drawing.Point(507, 20);
            this.prbEstado.Name = "prbEstado";
            this.prbEstado.Size = new System.Drawing.Size(437, 32);
            this.prbEstado.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado de Capacidad ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stationsPictureBox);
            this.Controls.Add(this.railwayPictureBox);
            this.Controls.Add(this.trainPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Simulator - Fernández y Biasoli";
            ((System.ComponentModel.ISupportInitialize)(this.trainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railwayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avanzarTrenBtn;
        private System.Windows.Forms.PictureBox trainPictureBox;
        private System.Windows.Forms.PictureBox railwayPictureBox;
        private System.Windows.Forms.PictureBox stationsPictureBox;
        private System.Windows.Forms.Timer trainTimer;
        private System.Windows.Forms.Button operarGenteBtn;
        private System.Windows.Forms.Timer fromTrainToStationTimer;
        private System.Windows.Forms.Timer fromStationToTrainTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEstadisticasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prbEstado;
        private System.Windows.Forms.Label label1;
    }
}

