namespace LINQ
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
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnNestedQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.FormattingEnabled = true;
            this.lbx.ItemHeight = 24;
            this.lbx.Location = new System.Drawing.Point(12, 12);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(424, 316);
            this.lbx.TabIndex = 0;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.lbx_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(460, 23);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(167, 52);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Data";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.Location = new System.Drawing.Point(460, 91);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(167, 50);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderBy.Location = new System.Drawing.Point(460, 164);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(167, 45);
            this.btnOrderBy.TabIndex = 3;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(460, 230);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(167, 48);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnNestedQ
            // 
            this.btnNestedQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNestedQ.Location = new System.Drawing.Point(460, 295);
            this.btnNestedQ.Name = "btnNestedQ";
            this.btnNestedQ.Size = new System.Drawing.Size(167, 44);
            this.btnNestedQ.TabIndex = 5;
            this.btnNestedQ.Text = "Nested Query";
            this.btnNestedQ.UseVisualStyleBackColor = true;
            this.btnNestedQ.Click += new System.EventHandler(this.btnNestedQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 455);
            this.Controls.Add(this.btnNestedQ);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnNestedQ;
    }
}

