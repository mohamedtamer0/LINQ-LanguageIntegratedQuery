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
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnJoin2 = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAllAlias = new System.Windows.Forms.Button();
            this.btnFromDataSet = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnSelectMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.FormattingEnabled = true;
            this.lbx.ItemHeight = 24;
            this.lbx.Location = new System.Drawing.Point(12, 53);
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
            this.btnAll.Size = new System.Drawing.Size(167, 37);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Data";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.Location = new System.Drawing.Point(460, 66);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(167, 30);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderBy.Location = new System.Drawing.Point(460, 102);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(167, 32);
            this.btnOrderBy.TabIndex = 3;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(460, 140);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(167, 35);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnNestedQ
            // 
            this.btnNestedQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNestedQ.Location = new System.Drawing.Point(460, 181);
            this.btnNestedQ.Name = "btnNestedQ";
            this.btnNestedQ.Size = new System.Drawing.Size(167, 36);
            this.btnNestedQ.TabIndex = 5;
            this.btnNestedQ.Text = "Nested Query";
            this.btnNestedQ.UseVisualStyleBackColor = true;
            this.btnNestedQ.Click += new System.EventHandler(this.btnNestedQ_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(460, 223);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(167, 34);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnJoin2
            // 
            this.btnJoin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin2.Location = new System.Drawing.Point(460, 264);
            this.btnJoin2.Name = "btnJoin2";
            this.btnJoin2.Size = new System.Drawing.Size(167, 35);
            this.btnJoin2.TabIndex = 7;
            this.btnJoin2.Text = "Join2";
            this.btnJoin2.UseVisualStyleBackColor = true;
            this.btnJoin2.Click += new System.EventHandler(this.btnJoin2_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistinct.Location = new System.Drawing.Point(460, 306);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(167, 35);
            this.btnDistinct.TabIndex = 8;
            this.btnDistinct.Text = "distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(633, 23);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(167, 35);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvg.Location = new System.Drawing.Point(633, 64);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(167, 35);
            this.btnAvg.TabIndex = 11;
            this.btnAvg.Text = "Avg";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(633, 105);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(167, 35);
            this.btnMin.TabIndex = 12;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(633, 146);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(167, 35);
            this.btnMax.TabIndex = 13;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAllAlias
            // 
            this.btnAllAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAlias.Location = new System.Drawing.Point(633, 187);
            this.btnAllAlias.Name = "btnAllAlias";
            this.btnAllAlias.Size = new System.Drawing.Size(167, 35);
            this.btnAllAlias.TabIndex = 14;
            this.btnAllAlias.Text = "AllData+Alias";
            this.btnAllAlias.UseVisualStyleBackColor = true;
            this.btnAllAlias.Click += new System.EventHandler(this.btnAllAlias_Click);
            // 
            // btnFromDataSet
            // 
            this.btnFromDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromDataSet.Location = new System.Drawing.Point(633, 228);
            this.btnFromDataSet.Name = "btnFromDataSet";
            this.btnFromDataSet.Size = new System.Drawing.Size(167, 35);
            this.btnFromDataSet.TabIndex = 15;
            this.btnFromDataSet.Text = "From DataSet";
            this.btnFromDataSet.UseVisualStyleBackColor = true;
            this.btnFromDataSet.Click += new System.EventHandler(this.btnFromDataSet_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLambda.Location = new System.Drawing.Point(633, 269);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(167, 35);
            this.btnLambda.TabIndex = 16;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnSelectMany
            // 
            this.btnSelectMany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMany.Location = new System.Drawing.Point(633, 310);
            this.btnSelectMany.Name = "btnSelectMany";
            this.btnSelectMany.Size = new System.Drawing.Size(167, 35);
            this.btnSelectMany.TabIndex = 17;
            this.btnSelectMany.Text = "Select Many";
            this.btnSelectMany.UseVisualStyleBackColor = true;
            this.btnSelectMany.Click += new System.EventHandler(this.btnSelectMany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 455);
            this.Controls.Add(this.btnSelectMany);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnFromDataSet);
            this.Controls.Add(this.btnAllAlias);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnJoin2);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnNestedQ);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnNestedQ;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnJoin2;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAllAlias;
        private System.Windows.Forms.Button btnFromDataSet;
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnSelectMany;
    }
}

