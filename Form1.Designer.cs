namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnset = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnset
            // 
            this.btnset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnset.Location = new System.Drawing.Point(504, 208);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(164, 44);
            this.btnset.TabIndex = 7;
            this.btnset.Text = "SET";
            this.btnset.UseVisualStyleBackColor = true;
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnstop.Location = new System.Drawing.Point(326, 208);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(164, 44);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(139, 79);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(529, 101);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00:00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(11, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(388, 50);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "STOPWATCH";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnstart.Location = new System.Drawing.Point(154, 208);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(164, 44);
            this.btnstart.TabIndex = 8;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 262);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnstart;
    }
}

