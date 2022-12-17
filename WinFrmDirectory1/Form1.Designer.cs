namespace WinFrmDirectory1
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnGetDirectories = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetFilesInfo = new System.Windows.Forms.Button();
            this.btnGetDirectoriesInfo = new System.Windows.Forms.Button();
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(28, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Directory";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Directory";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(28, 78);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(94, 23);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move Directory";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnGetDirectories
            // 
            this.btnGetDirectories.Location = new System.Drawing.Point(28, 107);
            this.btnGetDirectories.Name = "btnGetDirectories";
            this.btnGetDirectories.Size = new System.Drawing.Size(94, 23);
            this.btnGetDirectories.TabIndex = 0;
            this.btnGetDirectories.Text = "Get Directories";
            this.btnGetDirectories.UseVisualStyleBackColor = true;
            this.btnGetDirectories.Click += new System.EventHandler(this.btnGetDirectories_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(28, 136);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(94, 23);
            this.btnGetFiles.TabIndex = 0;
            this.btnGetFiles.Text = "Get Files";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFrmDirectory1.Properties.Resources.m1;
            this.pictureBox1.Location = new System.Drawing.Point(198, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateInfo
            // 
            this.btnCreateInfo.Location = new System.Drawing.Point(28, 19);
            this.btnCreateInfo.Name = "btnCreateInfo";
            this.btnCreateInfo.Size = new System.Drawing.Size(94, 23);
            this.btnCreateInfo.TabIndex = 0;
            this.btnCreateInfo.Text = "Create && Delete";
            this.btnCreateInfo.UseVisualStyleBackColor = true;
            this.btnCreateInfo.Click += new System.EventHandler(this.btnCreateInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetDirectories);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnGetFiles);
            this.groupBox1.Controls.Add(this.btnMove);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory class";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetFilesInfo);
            this.groupBox2.Controls.Add(this.btnGetDirectoriesInfo);
            this.groupBox2.Controls.Add(this.btnMoveTo);
            this.groupBox2.Controls.Add(this.btnCopyAll);
            this.groupBox2.Controls.Add(this.btnCreateInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DirectoryInfo Class";
            // 
            // btnGetFilesInfo
            // 
            this.btnGetFilesInfo.Location = new System.Drawing.Point(28, 135);
            this.btnGetFilesInfo.Name = "btnGetFilesInfo";
            this.btnGetFilesInfo.Size = new System.Drawing.Size(94, 23);
            this.btnGetFilesInfo.TabIndex = 0;
            this.btnGetFilesInfo.Text = "Get Files";
            this.btnGetFilesInfo.UseVisualStyleBackColor = true;
            this.btnGetFilesInfo.Click += new System.EventHandler(this.btnGetFilesInfo_Click);
            // 
            // btnGetDirectoriesInfo
            // 
            this.btnGetDirectoriesInfo.Location = new System.Drawing.Point(28, 106);
            this.btnGetDirectoriesInfo.Name = "btnGetDirectoriesInfo";
            this.btnGetDirectoriesInfo.Size = new System.Drawing.Size(94, 23);
            this.btnGetDirectoriesInfo.TabIndex = 0;
            this.btnGetDirectoriesInfo.Text = "Get Directories";
            this.btnGetDirectoriesInfo.UseVisualStyleBackColor = true;
            this.btnGetDirectoriesInfo.Click += new System.EventHandler(this.btnGetDirectoriesInfo_Click);
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(28, 77);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(94, 23);
            this.btnMoveTo.TabIndex = 0;
            this.btnMoveTo.Text = "Move To";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Location = new System.Drawing.Point(28, 48);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(94, 23);
            this.btnCopyAll.TabIndex = 0;
            this.btnCopyAll.Text = "Copy All";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnGetDirectories;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.Button btnMoveTo;
        private System.Windows.Forms.Button btnGetDirectoriesInfo;
        private System.Windows.Forms.Button btnGetFilesInfo;
    }
}

