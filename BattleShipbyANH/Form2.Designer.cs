namespace BattleShipbyANH
{
    partial class BattleShipbyANH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleShipbyANH));
            this.materialRaisedButton1 = new Material_Design_for_Winform.MaterialRaisedButton();
            this.materialRaisedButton2 = new Material_Design_for_Winform.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton1.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.materialRaisedButton1.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(171, 133);
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Radius = 2;
            this.materialRaisedButton1.ShadowDepth = 6;
            this.materialRaisedButton1.ShadowOpacity = 35;
            this.materialRaisedButton1.Size = new System.Drawing.Size(190, 50);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "PLAY";
            this.materialRaisedButton1.TextAlign = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton2.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.materialRaisedButton2.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton2.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(171, 246);
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Radius = 2;
            this.materialRaisedButton2.ShadowDepth = 6;
            this.materialRaisedButton2.ShadowOpacity = 35;
            this.materialRaisedButton2.Size = new System.Drawing.Size(190, 50);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "HOW TO PLAY";
            this.materialRaisedButton2.TextAlign = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // BattleShipbyANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 452);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleShipbyANH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleShipbyANH";
            this.ResumeLayout(false);

        }

        #endregion

        private Material_Design_for_Winform.MaterialRaisedButton materialRaisedButton1;
        private Material_Design_for_Winform.MaterialRaisedButton materialRaisedButton2;
    }
}