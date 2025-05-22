namespace DynamicInputs {
    partial class DynamicInputForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BackgroundContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BackgroundContainer.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundContainer
            // 
            this.BackgroundContainer.ColumnCount = 1;
            this.BackgroundContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.Controls.Add(this.DoneButton, 0, 1);
            this.BackgroundContainer.Controls.Add(this.ControlPanel, 0, 0);
            this.BackgroundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundContainer.Location = new System.Drawing.Point(0, 0);
            this.BackgroundContainer.Name = "BackgroundContainer";
            this.BackgroundContainer.RowCount = 2;
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.BackgroundContainer.Size = new System.Drawing.Size(800, 450);
            this.BackgroundContainer.TabIndex = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(10, 418);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.LayoutPanel);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(800, 408);
            this.ControlPanel.TabIndex = 1;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoSize = true;
            this.LayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutPanel.ColumnCount = 2;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Size = new System.Drawing.Size(798, 20);
            this.LayoutPanel.TabIndex = 1;
            // 
            // DynamicInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackgroundContainer);
            this.Name = "DynamicInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dynamic inputs";
            this.BackgroundContainer.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BackgroundContainer;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Panel ControlPanel;
    }
}