namespace ScoreEvaluation
{
    partial class ScoreEvaluation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextScore1 = new System.Windows.Forms.TextBox();
            this.TextScore2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextScore3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextScore4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員1";
            // 
            // TextScore1
            // 
            this.TextScore1.Location = new System.Drawing.Point(72, 12);
            this.TextScore1.Name = "TextScore1";
            this.TextScore1.Size = new System.Drawing.Size(96, 27);
            this.TextScore1.TabIndex = 1;
            this.TextScore1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextScore1_KeyDown);
            this.TextScore1.Leave += new System.EventHandler(this.TextScore1_Leave);
            // 
            // TextScore2
            // 
            this.TextScore2.Location = new System.Drawing.Point(72, 58);
            this.TextScore2.Name = "TextScore2";
            this.TextScore2.Size = new System.Drawing.Size(96, 27);
            this.TextScore2.TabIndex = 3;
            this.TextScore2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextScore2_KeyDown);
            this.TextScore2.Leave += new System.EventHandler(this.TextScore2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "社員2";
            // 
            // TextScore3
            // 
            this.TextScore3.Location = new System.Drawing.Point(72, 104);
            this.TextScore3.Name = "TextScore3";
            this.TextScore3.Size = new System.Drawing.Size(96, 27);
            this.TextScore3.TabIndex = 5;
            this.TextScore3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextScore3_KeyDown);
            this.TextScore3.Leave += new System.EventHandler(this.TextScore3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "社員3";
            // 
            // TextScore4
            // 
            this.TextScore4.Location = new System.Drawing.Point(72, 150);
            this.TextScore4.Name = "TextScore4";
            this.TextScore4.Size = new System.Drawing.Size(96, 27);
            this.TextScore4.TabIndex = 7;
            this.TextScore4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextScore4_KeyDown);
            this.TextScore4.Leave += new System.EventHandler(this.TextScore4_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "社員4";
            // 
            // ScoreEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 198);
            this.Controls.Add(this.TextScore4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextScore3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextScore2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextScore1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "社員スコア判定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextScore1;
        private System.Windows.Forms.TextBox TextScore2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextScore3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextScore4;
        private System.Windows.Forms.Label label4;
    }
}

