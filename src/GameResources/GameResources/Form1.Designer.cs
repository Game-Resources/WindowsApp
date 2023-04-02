namespace GameResources
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.backToolButton = new System.Windows.Forms.Button();
            this.forwardToolButton = new System.Windows.Forms.Button();
            this.settingToolButton = new System.Windows.Forms.Button();
            this.saveToolButton = new System.Windows.Forms.Button();
            this.favoriteToolButton = new System.Windows.Forms.Button();
            this.mainWebBrowser = new System.Windows.Forms.WebBrowser();
            this.pageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gamePageButton = new System.Windows.Forms.Button();
            this.aboutPageButton = new System.Windows.Forms.Button();
            this.newsPageButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.toolTableLayoutPanel.SuspendLayout();
            this.pageTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.toolTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainWebBrowser, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.pageTableLayoutPanel, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // toolTableLayoutPanel
            // 
            this.toolTableLayoutPanel.ColumnCount = 6;
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.toolTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.toolTableLayoutPanel.Controls.Add(this.backToolButton, 0, 0);
            this.toolTableLayoutPanel.Controls.Add(this.forwardToolButton, 1, 0);
            this.toolTableLayoutPanel.Controls.Add(this.settingToolButton, 2, 0);
            this.toolTableLayoutPanel.Controls.Add(this.saveToolButton, 3, 0);
            this.toolTableLayoutPanel.Controls.Add(this.favoriteToolButton, 4, 0);
            this.toolTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTableLayoutPanel.Location = new System.Drawing.Point(3, 4);
            this.toolTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolTableLayoutPanel.Name = "toolTableLayoutPanel";
            this.toolTableLayoutPanel.RowCount = 1;
            this.toolTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolTableLayoutPanel.Size = new System.Drawing.Size(794, 57);
            this.toolTableLayoutPanel.TabIndex = 0;
            // 
            // backToolButton
            // 
            this.backToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backToolButton.Enabled = false;
            this.backToolButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolButton.Image")));
            this.backToolButton.Location = new System.Drawing.Point(3, 4);
            this.backToolButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToolButton.Name = "backToolButton";
            this.backToolButton.Size = new System.Drawing.Size(49, 49);
            this.backToolButton.TabIndex = 0;
            this.backToolButton.UseVisualStyleBackColor = true;
            this.backToolButton.Click += new System.EventHandler(this.backToolButton_Click);
            // 
            // forwardToolButton
            // 
            this.forwardToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forwardToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forwardToolButton.Enabled = false;
            this.forwardToolButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolButton.Image")));
            this.forwardToolButton.Location = new System.Drawing.Point(58, 4);
            this.forwardToolButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forwardToolButton.Name = "forwardToolButton";
            this.forwardToolButton.Size = new System.Drawing.Size(49, 49);
            this.forwardToolButton.TabIndex = 1;
            this.forwardToolButton.UseVisualStyleBackColor = true;
            this.forwardToolButton.Click += new System.EventHandler(this.forwardToolButton_Click);
            // 
            // settingToolButton
            // 
            this.settingToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingToolButton.Image = ((System.Drawing.Image)(resources.GetObject("settingToolButton.Image")));
            this.settingToolButton.Location = new System.Drawing.Point(113, 4);
            this.settingToolButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingToolButton.Name = "settingToolButton";
            this.settingToolButton.Size = new System.Drawing.Size(49, 49);
            this.settingToolButton.TabIndex = 2;
            this.settingToolButton.UseVisualStyleBackColor = true;
            this.settingToolButton.Click += new System.EventHandler(this.settingToolButton_Click);
            // 
            // saveToolButton
            // 
            this.saveToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolButton.Image")));
            this.saveToolButton.Location = new System.Drawing.Point(168, 4);
            this.saveToolButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveToolButton.Name = "saveToolButton";
            this.saveToolButton.Size = new System.Drawing.Size(49, 49);
            this.saveToolButton.TabIndex = 3;
            this.saveToolButton.UseVisualStyleBackColor = true;
            this.saveToolButton.Click += new System.EventHandler(this.saveToolButton_Click);
            // 
            // favoriteToolButton
            // 
            this.favoriteToolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteToolButton.Image = ((System.Drawing.Image)(resources.GetObject("favoriteToolButton.Image")));
            this.favoriteToolButton.Location = new System.Drawing.Point(223, 4);
            this.favoriteToolButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.favoriteToolButton.Name = "favoriteToolButton";
            this.favoriteToolButton.Size = new System.Drawing.Size(49, 49);
            this.favoriteToolButton.TabIndex = 4;
            this.favoriteToolButton.UseVisualStyleBackColor = true;
            this.favoriteToolButton.Click += new System.EventHandler(this.favoriteToolButton_Click);
            // 
            // mainWebBrowser
            // 
            this.mainWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWebBrowser.Location = new System.Drawing.Point(3, 69);
            this.mainWebBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainWebBrowser.MinimumSize = new System.Drawing.Size(22, 23);
            this.mainWebBrowser.Name = "mainWebBrowser";
            this.mainWebBrowser.Size = new System.Drawing.Size(794, 312);
            this.mainWebBrowser.TabIndex = 1;
            this.mainWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainWebBrowser_DocumentCompleted);
            // 
            // pageTableLayoutPanel
            // 
            this.pageTableLayoutPanel.ColumnCount = 4;
            this.pageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pageTableLayoutPanel.Controls.Add(this.gamePageButton, 0, 0);
            this.pageTableLayoutPanel.Controls.Add(this.aboutPageButton, 1, 0);
            this.pageTableLayoutPanel.Controls.Add(this.newsPageButton, 2, 0);
            this.pageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTableLayoutPanel.Location = new System.Drawing.Point(3, 389);
            this.pageTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageTableLayoutPanel.Name = "pageTableLayoutPanel";
            this.pageTableLayoutPanel.RowCount = 1;
            this.pageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pageTableLayoutPanel.Size = new System.Drawing.Size(794, 57);
            this.pageTableLayoutPanel.TabIndex = 2;
            // 
            // gamePageButton
            // 
            this.gamePageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePageButton.Image = ((System.Drawing.Image)(resources.GetObject("gamePageButton.Image")));
            this.gamePageButton.Location = new System.Drawing.Point(3, 4);
            this.gamePageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gamePageButton.Name = "gamePageButton";
            this.gamePageButton.Size = new System.Drawing.Size(49, 49);
            this.gamePageButton.TabIndex = 0;
            this.gamePageButton.UseVisualStyleBackColor = true;
            this.gamePageButton.Click += new System.EventHandler(this.gamePageButton_Click);
            // 
            // aboutPageButton
            // 
            this.aboutPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPageButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutPageButton.Image")));
            this.aboutPageButton.Location = new System.Drawing.Point(58, 3);
            this.aboutPageButton.Name = "aboutPageButton";
            this.aboutPageButton.Size = new System.Drawing.Size(49, 51);
            this.aboutPageButton.TabIndex = 1;
            this.aboutPageButton.UseVisualStyleBackColor = true;
            this.aboutPageButton.Click += new System.EventHandler(this.aboutPageButton_Click);
            // 
            // newsPageButton
            // 
            this.newsPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsPageButton.Image = ((System.Drawing.Image)(resources.GetObject("newsPageButton.Image")));
            this.newsPageButton.Location = new System.Drawing.Point(113, 3);
            this.newsPageButton.Name = "newsPageButton";
            this.newsPageButton.Size = new System.Drawing.Size(49, 51);
            this.newsPageButton.TabIndex = 2;
            this.newsPageButton.UseVisualStyleBackColor = true;
            this.newsPageButton.Click += new System.EventHandler(this.newsPageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ゲームリソース";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.toolTableLayoutPanel.ResumeLayout(false);
            this.pageTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel toolTableLayoutPanel;
        private System.Windows.Forms.Button backToolButton;
        private System.Windows.Forms.Button forwardToolButton;
        private System.Windows.Forms.Button settingToolButton;
        private System.Windows.Forms.Button saveToolButton;
        private System.Windows.Forms.Button favoriteToolButton;
        private System.Windows.Forms.WebBrowser mainWebBrowser;
        private System.Windows.Forms.TableLayoutPanel pageTableLayoutPanel;
        private System.Windows.Forms.Button gamePageButton;
        private System.Windows.Forms.Button aboutPageButton;
        private System.Windows.Forms.Button newsPageButton;
    }
}

