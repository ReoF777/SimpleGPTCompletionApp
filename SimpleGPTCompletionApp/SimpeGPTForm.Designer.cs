namespace SimpleGPTCompletionApp
{
    partial class SimpeGPTForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            GenerateBtn = new Button();
            BaseInput = new TextBox();
            SpeakerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ResultOutput = new TextBox();
            label4 = new Label();
            RestrictInput = new TextBox();
            SuspendLayout();
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(374, 409);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(94, 29);
            GenerateBtn.TabIndex = 0;
            GenerateBtn.Text = "生成";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // BaseInput
            // 
            BaseInput.Location = new Point(187, 28);
            BaseInput.MaximumSize = new Size(569, 190);
            BaseInput.MinimumSize = new Size(569, 190);
            BaseInput.Name = "BaseInput";
            BaseInput.Size = new Size(569, 190);
            BaseInput.TabIndex = 1;
            // 
            // SpeakerName
            // 
            SpeakerName.Location = new Point(187, 270);
            SpeakerName.Name = "SpeakerName";
            SpeakerName.Size = new Size(569, 27);
            SpeakerName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 112);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "事前情報";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 277);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "発話者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 352);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "生成結果";
            // 
            // ResultOutput
            // 
            ResultOutput.Location = new Point(187, 303);
            ResultOutput.MaximumSize = new Size(569, 100);
            ResultOutput.MinimumSize = new Size(569, 100);
            ResultOutput.Name = "ResultOutput";
            ResultOutput.Size = new Size(569, 100);
            ResultOutput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 232);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "生成条件";
            // 
            // RestrictInput
            // 
            RestrictInput.Location = new Point(187, 233);
            RestrictInput.Name = "RestrictInput";
            RestrictInput.Size = new Size(569, 27);
            RestrictInput.TabIndex = 8;
            // 
            // SimpeGPTForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RestrictInput);
            Controls.Add(label4);
            Controls.Add(ResultOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SpeakerName);
            Controls.Add(BaseInput);
            Controls.Add(GenerateBtn);
            Name = "SimpeGPTForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateBtn;
        private TextBox BaseInput;
        private TextBox SpeakerName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ResultOutput;
        private Label label4;
        private TextBox RestrictInput;
    }
}
