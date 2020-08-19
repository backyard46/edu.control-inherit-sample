namespace ControlInheritResult
{
    partial class SampleForm_Result
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
            this.customTextBox21 = new ControlInheritResult.CustomTextBox2();
            this.customTextBox11 = new ControlInheritResult.CustomTextBox1();
            this.customButton21 = new ControlInheritResult.CustomButton2();
            this.customButton11 = new ControlInheritResult.CustomButton1();
            this.SuspendLayout();
            // 
            // customTextBox21
            // 
            this.customTextBox21.Location = new System.Drawing.Point(13, 151);
            this.customTextBox21.Name = "customTextBox21";
            this.customTextBox21.Size = new System.Drawing.Size(170, 27);
            this.customTextBox21.TabIndex = 3;
            this.customTextBox21.Text = "文字太さ変更";
            // 
            // customTextBox11
            // 
            this.customTextBox11.Location = new System.Drawing.Point(13, 109);
            this.customTextBox11.Name = "customTextBox11";
            this.customTextBox11.Size = new System.Drawing.Size(171, 27);
            this.customTextBox11.TabIndex = 2;
            this.customTextBox11.Text = "色が変わります";
            // 
            // customButton21
            // 
            this.customButton21.Location = new System.Drawing.Point(12, 58);
            this.customButton21.Name = "customButton21";
            this.customButton21.Size = new System.Drawing.Size(171, 35);
            this.customButton21.TabIndex = 1;
            this.customButton21.Text = "2020年8月19日";
            this.customButton21.UseVisualStyleBackColor = true;
            // 
            // customButton11
            // 
            this.customButton11.Location = new System.Drawing.Point(13, 14);
            this.customButton11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customButton11.Name = "customButton11";
            this.customButton11.Size = new System.Drawing.Size(171, 36);
            this.customButton11.TabIndex = 0;
            this.customButton11.Text = "色が変わります";
            this.customButton11.UseVisualStyleBackColor = true;
            // 
            // SampleForm_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 199);
            this.Controls.Add(this.customTextBox21);
            this.Controls.Add(this.customTextBox11);
            this.Controls.Add(this.customButton21);
            this.Controls.Add(this.customButton11);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SampleForm_Result";
            this.Text = "コントロール貼り付けサンプル";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton1 customButton11;
        private CustomButton2 customButton21;
        private CustomTextBox1 customTextBox11;
        private CustomTextBox2 customTextBox21;
    }
}

