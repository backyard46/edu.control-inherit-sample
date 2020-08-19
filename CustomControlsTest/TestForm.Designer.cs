namespace CustomControlsTest
{
    partial class TestForm
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
            this.customButton11 = new CustomControls.CustomButton1();
            this.customButton21 = new CustomControls.CustomButton2();
            this.customTextBox11 = new CustomControls.CustomTextBox1();
            this.customTextBox21 = new CustomControls.CustomTextBox2();
            this.SuspendLayout();
            // 
            // customButton11
            // 
            this.customButton11.Location = new System.Drawing.Point(18, 19);
            this.customButton11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customButton11.Name = "customButton11";
            this.customButton11.Size = new System.Drawing.Size(220, 65);
            this.customButton11.TabIndex = 0;
            this.customButton11.Text = "customButton11";
            this.customButton11.UseVisualStyleBackColor = true;
            // 
            // customButton21
            // 
            this.customButton21.Location = new System.Drawing.Point(18, 94);
            this.customButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customButton21.Name = "customButton21";
            this.customButton21.Size = new System.Drawing.Size(219, 65);
            this.customButton21.TabIndex = 1;
            this.customButton21.Text = "2020年8月19日";
            this.customButton21.UseVisualStyleBackColor = true;
            // 
            // customTextBox11
            // 
            this.customTextBox11.Location = new System.Drawing.Point(18, 169);
            this.customTextBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox11.Name = "customTextBox11";
            this.customTextBox11.Size = new System.Drawing.Size(219, 27);
            this.customTextBox11.TabIndex = 2;
            // 
            // customTextBox21
            // 
            this.customTextBox21.Location = new System.Drawing.Point(18, 208);
            this.customTextBox21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBox21.Name = "customTextBox21";
            this.customTextBox21.Size = new System.Drawing.Size(219, 27);
            this.customTextBox21.TabIndex = 3;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 267);
            this.Controls.Add(this.customTextBox21);
            this.Controls.Add(this.customTextBox11);
            this.Controls.Add(this.customButton21);
            this.Controls.Add(this.customButton11);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton1 customButton11;
        private CustomControls.CustomButton2 customButton21;
        private CustomControls.CustomTextBox1 customTextBox11;
        private CustomControls.CustomTextBox2 customTextBox21;
    }
}

