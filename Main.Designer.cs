namespace _7_Zip
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.l_ExtractArchiveName = new System.Windows.Forms.Label();
            this.l_ExtractDirectory = new System.Windows.Forms.Label();
            this.tb_Messages = new System.Windows.Forms.TextBox();
            this.pb_ExtractProgress = new System.Windows.Forms.ProgressBar();
            this.b_ExtractBrowseArchive = new System.Windows.Forms.Button();
            this.pb_ExtractWork = new System.Windows.Forms.ProgressBar();
            this.b_Extract = new System.Windows.Forms.Button();
            this.tb_ExtractArchive = new System.Windows.Forms.TextBox();
            this.l_ExtractProgress = new System.Windows.Forms.Label();
            this.tb_ExtractDirectory = new System.Windows.Forms.TextBox();
            this.b_ExtractBrowseDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtractDirectory = new System.Windows.Forms.TextBox();
            this.btnExtraction = new System.Windows.Forms.Button();
            this.btnExtractBrowseDirectory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxtractBrowseArchive = new System.Windows.Forms.Button();
            this.txtExtractArchive = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtCompressOutput = new System.Windows.Forms.TextBox();
            this.btnCompression = new System.Windows.Forms.Button();
            this.l_CompressOutput = new System.Windows.Forms.Label();
            this.txtCompressDirectory = new System.Windows.Forms.TextBox();
            this.l_CompressDirectory = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Extraction = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Compression = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Extraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Compression.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "7-Zip files |*.7z";
            // 
            // l_ExtractArchiveName
            // 
            this.l_ExtractArchiveName.AutoSize = true;
            this.l_ExtractArchiveName.Location = new System.Drawing.Point(3, 110);
            this.l_ExtractArchiveName.Name = "l_ExtractArchiveName";
            this.l_ExtractArchiveName.Size = new System.Drawing.Size(88, 13);
            this.l_ExtractArchiveName.TabIndex = 19;
            this.l_ExtractArchiveName.Text = "Archive file name";
            // 
            // l_ExtractDirectory
            // 
            this.l_ExtractDirectory.AutoSize = true;
            this.l_ExtractDirectory.Location = new System.Drawing.Point(3, 62);
            this.l_ExtractDirectory.Name = "l_ExtractDirectory";
            this.l_ExtractDirectory.Size = new System.Drawing.Size(82, 13);
            this.l_ExtractDirectory.TabIndex = 16;
            this.l_ExtractDirectory.Text = "Output directory";
            // 
            // tb_Messages
            // 
            this.tb_Messages.Location = new System.Drawing.Point(6, 152);
            this.tb_Messages.Multiline = true;
            this.tb_Messages.Name = "tb_Messages";
            this.tb_Messages.Size = new System.Drawing.Size(263, 142);
            this.tb_Messages.TabIndex = 21;
            // 
            // pb_ExtractProgress
            // 
            this.pb_ExtractProgress.Location = new System.Drawing.Point(3, 19);
            this.pb_ExtractProgress.Name = "pb_ExtractProgress";
            this.pb_ExtractProgress.Size = new System.Drawing.Size(195, 16);
            this.pb_ExtractProgress.TabIndex = 11;
            // 
            // b_ExtractBrowseArchive
            // 
            this.b_ExtractBrowseArchive.Location = new System.Drawing.Point(204, 126);
            this.b_ExtractBrowseArchive.Name = "b_ExtractBrowseArchive";
            this.b_ExtractBrowseArchive.Size = new System.Drawing.Size(66, 20);
            this.b_ExtractBrowseArchive.TabIndex = 20;
            this.b_ExtractBrowseArchive.Text = "Browse";
            this.b_ExtractBrowseArchive.UseVisualStyleBackColor = true;
            // 
            // pb_ExtractWork
            // 
            this.pb_ExtractWork.Location = new System.Drawing.Point(3, 41);
            this.pb_ExtractWork.MarqueeAnimationSpeed = 25;
            this.pb_ExtractWork.Name = "pb_ExtractWork";
            this.pb_ExtractWork.Size = new System.Drawing.Size(195, 16);
            this.pb_ExtractWork.TabIndex = 12;
            // 
            // b_Extract
            // 
            this.b_Extract.Location = new System.Drawing.Point(204, 19);
            this.b_Extract.Name = "b_Extract";
            this.b_Extract.Size = new System.Drawing.Size(66, 38);
            this.b_Extract.TabIndex = 13;
            this.b_Extract.Text = "Extract";
            this.b_Extract.UseVisualStyleBackColor = true;
            // 
            // tb_ExtractArchive
            // 
            this.tb_ExtractArchive.Location = new System.Drawing.Point(3, 126);
            this.tb_ExtractArchive.Name = "tb_ExtractArchive";
            this.tb_ExtractArchive.Size = new System.Drawing.Size(195, 20);
            this.tb_ExtractArchive.TabIndex = 18;
            // 
            // l_ExtractProgress
            // 
            this.l_ExtractProgress.AutoSize = true;
            this.l_ExtractProgress.Location = new System.Drawing.Point(3, 3);
            this.l_ExtractProgress.Name = "l_ExtractProgress";
            this.l_ExtractProgress.Size = new System.Drawing.Size(48, 13);
            this.l_ExtractProgress.TabIndex = 14;
            this.l_ExtractProgress.Text = "Progress";
            // 
            // tb_ExtractDirectory
            // 
            this.tb_ExtractDirectory.Location = new System.Drawing.Point(3, 78);
            this.tb_ExtractDirectory.Name = "tb_ExtractDirectory";
            this.tb_ExtractDirectory.Size = new System.Drawing.Size(195, 20);
            this.tb_ExtractDirectory.TabIndex = 15;
            // 
            // b_ExtractBrowseDirectory
            // 
            this.b_ExtractBrowseDirectory.Location = new System.Drawing.Point(204, 78);
            this.b_ExtractBrowseDirectory.Name = "b_ExtractBrowseDirectory";
            this.b_ExtractBrowseDirectory.Size = new System.Drawing.Size(66, 20);
            this.b_ExtractBrowseDirectory.TabIndex = 17;
            this.b_ExtractBrowseDirectory.Text = "Browse";
            this.b_ExtractBrowseDirectory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selecionar Diretório:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Procurar Arquivo:";
            // 
            // txtExtractDirectory
            // 
            this.txtExtractDirectory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtExtractDirectory.Location = new System.Drawing.Point(187, 30);
            this.txtExtractDirectory.Name = "txtExtractDirectory";
            this.txtExtractDirectory.Size = new System.Drawing.Size(390, 20);
            this.txtExtractDirectory.TabIndex = 5;
            // 
            // btnExtraction
            // 
            this.btnExtraction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraction.Location = new System.Drawing.Point(644, 22);
            this.btnExtraction.Name = "btnExtraction";
            this.btnExtraction.Size = new System.Drawing.Size(134, 68);
            this.btnExtraction.TabIndex = 4;
            this.btnExtraction.Text = "Extrair";
            this.btnExtraction.UseVisualStyleBackColor = true;
            this.btnExtraction.Click += new System.EventHandler(this.btnExtraction_Click);
            // 
            // btnExtractBrowseDirectory
            // 
            this.btnExtractBrowseDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractBrowseDirectory.Location = new System.Drawing.Point(583, 28);
            this.btnExtractBrowseDirectory.Name = "btnExtractBrowseDirectory";
            this.btnExtractBrowseDirectory.Size = new System.Drawing.Size(44, 26);
            this.btnExtractBrowseDirectory.TabIndex = 3;
            this.btnExtractBrowseDirectory.Text = ". . . ";
            this.btnExtractBrowseDirectory.UseVisualStyleBackColor = true;
            this.btnExtractBrowseDirectory.Click += new System.EventHandler(this.btnExtractBrowseDirectory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxtractBrowseArchive);
            this.groupBox2.Controls.Add(this.txtExtractArchive);
            this.groupBox2.Controls.Add(this.btnExtractBrowseDirectory);
            this.groupBox2.Controls.Add(this.btnExtraction);
            this.groupBox2.Controls.Add(this.txtExtractDirectory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnxtractBrowseArchive
            // 
            this.btnxtractBrowseArchive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxtractBrowseArchive.Location = new System.Drawing.Point(583, 64);
            this.btnxtractBrowseArchive.Name = "btnxtractBrowseArchive";
            this.btnxtractBrowseArchive.Size = new System.Drawing.Size(44, 26);
            this.btnxtractBrowseArchive.TabIndex = 23;
            this.btnxtractBrowseArchive.Text = ". . . ";
            this.btnxtractBrowseArchive.UseVisualStyleBackColor = true;
            this.btnxtractBrowseArchive.Click += new System.EventHandler(this.btnxtractBrowseArchive_Click);
            // 
            // txtExtractArchive
            // 
            this.txtExtractArchive.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtExtractArchive.Location = new System.Drawing.Point(187, 70);
            this.txtExtractArchive.Name = "txtExtractArchive";
            this.txtExtractArchive.Size = new System.Drawing.Size(390, 20);
            this.txtExtractArchive.TabIndex = 22;
            this.txtExtractArchive.TextChanged += new System.EventHandler(this.txtExtractArchive_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "7-Zip files |*.7z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseOut);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtCompressOutput);
            this.groupBox1.Controls.Add(this.btnCompression);
            this.groupBox1.Controls.Add(this.l_CompressOutput);
            this.groupBox1.Controls.Add(this.txtCompressDirectory);
            this.groupBox1.Controls.Add(this.l_CompressDirectory);
            this.groupBox1.Location = new System.Drawing.Point(7, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOut.Location = new System.Drawing.Point(576, 72);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(46, 26);
            this.btnBrowseOut.TabIndex = 13;
            this.btnBrowseOut.Text = ". . .";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(576, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(46, 26);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = ". . .";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtCompressOutput
            // 
            this.txtCompressOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompressOutput.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCompressOutput.Location = new System.Drawing.Point(177, 72);
            this.txtCompressOutput.Name = "txtCompressOutput";
            this.txtCompressOutput.Size = new System.Drawing.Size(393, 25);
            this.txtCompressOutput.TabIndex = 12;
            // 
            // btnCompression
            // 
            this.btnCompression.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompression.Location = new System.Drawing.Point(628, 25);
            this.btnCompression.Name = "btnCompression";
            this.btnCompression.Size = new System.Drawing.Size(137, 61);
            this.btnCompression.TabIndex = 0;
            this.btnCompression.Text = "Comprimir";
            this.btnCompression.UseVisualStyleBackColor = true;
            this.btnCompression.Click += new System.EventHandler(this.btnCompression_Click);
            // 
            // l_CompressOutput
            // 
            this.l_CompressOutput.AutoSize = true;
            this.l_CompressOutput.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_CompressOutput.Location = new System.Drawing.Point(38, 73);
            this.l_CompressOutput.Name = "l_CompressOutput";
            this.l_CompressOutput.Size = new System.Drawing.Size(143, 13);
            this.l_CompressOutput.TabIndex = 11;
            this.l_CompressOutput.Text = "Escolher Arquivo:";
            // 
            // txtCompressDirectory
            // 
            this.txtCompressDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompressDirectory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCompressDirectory.Location = new System.Drawing.Point(177, 27);
            this.txtCompressDirectory.Name = "txtCompressDirectory";
            this.txtCompressDirectory.Size = new System.Drawing.Size(393, 25);
            this.txtCompressDirectory.TabIndex = 1;
            // 
            // l_CompressDirectory
            // 
            this.l_CompressDirectory.AutoSize = true;
            this.l_CompressDirectory.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_CompressDirectory.Location = new System.Drawing.Point(6, 31);
            this.l_CompressDirectory.Name = "l_CompressDirectory";
            this.l_CompressDirectory.Size = new System.Drawing.Size(175, 13);
            this.l_CompressDirectory.TabIndex = 10;
            this.l_CompressDirectory.Text = "Selecionar Diretório:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Extraction);
            this.tabControl1.Controls.Add(this.Compression);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(188, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 323);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 9;
            // 
            // Extraction
            // 
            this.Extraction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Extraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Extraction.Controls.Add(this.pictureBox1);
            this.Extraction.Controls.Add(this.groupBox2);
            this.Extraction.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extraction.Location = new System.Drawing.Point(4, 32);
            this.Extraction.Name = "Extraction";
            this.Extraction.Padding = new System.Windows.Forms.Padding(3);
            this.Extraction.Size = new System.Drawing.Size(811, 287);
            this.Extraction.TabIndex = 1;
            this.Extraction.Text = "Extrair Zip";
            this.Extraction.Click += new System.EventHandler(this.Extraction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Compression
            // 
            this.Compression.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Compression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Compression.Controls.Add(this.pictureBox3);
            this.Compression.Controls.Add(this.groupBox1);
            this.Compression.Location = new System.Drawing.Point(4, 32);
            this.Compression.Name = "Compression";
            this.Compression.Padding = new System.Windows.Forms.Padding(3);
            this.Compression.Size = new System.Drawing.Size(811, 287);
            this.Compression.TabIndex = 0;
            this.Compression.Text = "Compressão";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 287);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sobre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(417, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "facilprogramacao@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(402, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Soluções, relatar erros ou melhorias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(477, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Suporte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(486, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sobre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(402, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Software gratuito, distribuição livre. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(686, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sthefany Soares";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(479, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "livesoft.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(477, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contato";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(86, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(608, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 323);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydro Zip 1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Extraction.ResumeLayout(false);
            this.Extraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Compression.ResumeLayout(false);
            this.Compression.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label l_ExtractArchiveName;
        private System.Windows.Forms.Label l_ExtractDirectory;
        private System.Windows.Forms.TextBox tb_Messages;
        private System.Windows.Forms.ProgressBar pb_ExtractProgress;
        private System.Windows.Forms.Button b_ExtractBrowseArchive;
        private System.Windows.Forms.ProgressBar pb_ExtractWork;
        private System.Windows.Forms.Button b_Extract;
        private System.Windows.Forms.TextBox tb_ExtractArchive;
        private System.Windows.Forms.Label l_ExtractProgress;
        private System.Windows.Forms.TextBox tb_ExtractDirectory;
        private System.Windows.Forms.Button b_ExtractBrowseDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtractDirectory;
        private System.Windows.Forms.Button btnExtraction;
        private System.Windows.Forms.Button btnExtractBrowseDirectory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExtractArchive;
        private System.Windows.Forms.Button btnxtractBrowseArchive;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtCompressOutput;
        private System.Windows.Forms.Button btnCompression;
        private System.Windows.Forms.Label l_CompressOutput;
        private System.Windows.Forms.TextBox txtCompressDirectory;
        private System.Windows.Forms.Label l_CompressDirectory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Extraction;
        private System.Windows.Forms.TabPage Compression;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

