
namespace ZMK
{
    partial class tpForm
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
            this.lbFormHeader = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_removeTP = new System.Windows.Forms.Button();
            this.btn_addTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFormHeader
            // 
            this.lbFormHeader.AutoSize = true;
            this.lbFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFormHeader.Location = new System.Drawing.Point(13, 13);
            this.lbFormHeader.Name = "lbFormHeader";
            this.lbFormHeader.Size = new System.Drawing.Size(372, 25);
            this.lbFormHeader.TabIndex = 0;
            this.lbFormHeader.Text = "Технологический процесс проекта: ";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(18, 82);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(490, 593);
            this.treeView1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_removeTP
            // 
            this.btn_removeTP.Image = global::ZMK.Properties.Resources.minus_32;
            this.btn_removeTP.Location = new System.Drawing.Point(59, 41);
            this.btn_removeTP.Name = "btn_removeTP";
            this.btn_removeTP.Size = new System.Drawing.Size(35, 35);
            this.btn_removeTP.TabIndex = 5;
            this.btn_removeTP.UseVisualStyleBackColor = true;
            // 
            // btn_addTP
            // 
            this.btn_addTP.Image = global::ZMK.Properties.Resources.plus_24;
            this.btn_addTP.Location = new System.Drawing.Point(18, 41);
            this.btn_addTP.Name = "btn_addTP";
            this.btn_addTP.Size = new System.Drawing.Size(35, 35);
            this.btn_addTP.TabIndex = 4;
            this.btn_addTP.UseVisualStyleBackColor = true;
            // 
            // tpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 700);
            this.Controls.Add(this.btn_removeTP);
            this.Controls.Add(this.btn_addTP);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbFormHeader);
            this.Name = "tpForm";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormHeader;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_removeTP;
        private System.Windows.Forms.Button btn_addTP;
    }
}