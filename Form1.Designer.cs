namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            inputData = new TextBox();
            btnDrawgraph = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 22);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 0;
            label1.Text = "ENTER VALUES FOR THE GRAPH";
            // 
            // inputData
            // 
            inputData.Location = new Point(556, 59);
            inputData.Name = "inputData";
            inputData.Size = new Size(210, 27);
            inputData.TabIndex = 1;
            // 
            // btnDrawgraph
            // 
            btnDrawgraph.Location = new Point(581, 110);
            btnDrawgraph.Name = "btnDrawgraph";
            btnDrawgraph.Size = new Size(161, 29);
            btnDrawgraph.TabIndex = 2;
            btnDrawgraph.Text = "DRAW GRAPH";
            btnDrawgraph.UseVisualStyleBackColor = true;
            btnDrawgraph.Click += btnDrawgraph_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(btnDrawgraph);
            Controls.Add(inputData);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputData;
        private Button btnDrawgraph;
    }
}
