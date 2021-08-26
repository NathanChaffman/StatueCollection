
namespace StatueCollection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainAdd = new System.Windows.Forms.Button();
            this.btnMainTotalValue = new System.Windows.Forms.Button();
            this.btnMainPreOrderTotalCost = new System.Windows.Forms.Button();
            this.btnRetailLinks = new System.Windows.Forms.Button();
            this.btnMainView = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Your Collection";
            // 
            // btnMainAdd
            // 
            this.btnMainAdd.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainAdd.Location = new System.Drawing.Point(122, 57);
            this.btnMainAdd.Name = "btnMainAdd";
            this.btnMainAdd.Size = new System.Drawing.Size(160, 54);
            this.btnMainAdd.TabIndex = 1;
            this.btnMainAdd.Text = "Add Statue/Pre-Order";
            this.btnMainAdd.UseVisualStyleBackColor = true;
            this.btnMainAdd.Click += new System.EventHandler(this.btnMainAdd_Click);
            // 
            // btnMainTotalValue
            // 
            this.btnMainTotalValue.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainTotalValue.Location = new System.Drawing.Point(122, 177);
            this.btnMainTotalValue.Name = "btnMainTotalValue";
            this.btnMainTotalValue.Size = new System.Drawing.Size(160, 54);
            this.btnMainTotalValue.TabIndex = 4;
            this.btnMainTotalValue.Text = "Collection Value";
            this.btnMainTotalValue.UseVisualStyleBackColor = true;
            this.btnMainTotalValue.Click += new System.EventHandler(this.btnMainTotalValue_Click);
            // 
            // btnMainPreOrderTotalCost
            // 
            this.btnMainPreOrderTotalCost.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPreOrderTotalCost.Location = new System.Drawing.Point(122, 237);
            this.btnMainPreOrderTotalCost.Name = "btnMainPreOrderTotalCost";
            this.btnMainPreOrderTotalCost.Size = new System.Drawing.Size(160, 54);
            this.btnMainPreOrderTotalCost.TabIndex = 5;
            this.btnMainPreOrderTotalCost.Text = "Cost of Pre-Orders";
            this.btnMainPreOrderTotalCost.UseVisualStyleBackColor = true;
            this.btnMainPreOrderTotalCost.Click += new System.EventHandler(this.btnMainPreOrderTotalCost_Click);
            // 
            // btnRetailLinks
            // 
            this.btnRetailLinks.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetailLinks.Location = new System.Drawing.Point(122, 297);
            this.btnRetailLinks.Name = "btnRetailLinks";
            this.btnRetailLinks.Size = new System.Drawing.Size(160, 54);
            this.btnRetailLinks.TabIndex = 6;
            this.btnRetailLinks.Text = "Retailer Links";
            this.btnRetailLinks.UseVisualStyleBackColor = true;
            this.btnRetailLinks.Click += new System.EventHandler(this.btnRetailLinks_Click);
            // 
            // btnMainView
            // 
            this.btnMainView.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainView.Location = new System.Drawing.Point(122, 117);
            this.btnMainView.Name = "btnMainView";
            this.btnMainView.Size = new System.Drawing.Size(160, 54);
            this.btnMainView.TabIndex = 7;
            this.btnMainView.Text = "View / Update / Delete";
            this.btnMainView.UseVisualStyleBackColor = true;
            this.btnMainView.Click += new System.EventHandler(this.btnMainView_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.btnExitApplication.Location = new System.Drawing.Point(122, 358);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(160, 53);
            this.btnExitApplication.TabIndex = 8;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 423);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnMainView);
            this.Controls.Add(this.btnRetailLinks);
            this.Controls.Add(this.btnMainPreOrderTotalCost);
            this.Controls.Add(this.btnMainTotalValue);
            this.Controls.Add(this.btnMainAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainAdd;
        private System.Windows.Forms.Button btnMainTotalValue;
        private System.Windows.Forms.Button btnMainPreOrderTotalCost;
        private System.Windows.Forms.Button btnRetailLinks;
        private System.Windows.Forms.Button btnMainView;
        private System.Windows.Forms.Button btnExitApplication;
    }
}

