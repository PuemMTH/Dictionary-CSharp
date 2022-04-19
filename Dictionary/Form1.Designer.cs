namespace Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputValue = new System.Windows.Forms.TextBox();
            this.lsDictionary = new System.Windows.Forms.TextBox();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleDictionary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputValue
            // 
            this.inputValue.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.inputValue, "inputValue");
            this.inputValue.Name = "inputValue";
            // 
            // lsDictionary
            // 
            this.lsDictionary.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lsDictionary, "lsDictionary");
            this.lsDictionary.Name = "lsDictionary";
            // 
            // inputKey
            // 
            this.inputKey.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.inputKey, "inputKey");
            this.inputKey.Name = "inputKey";
            this.inputKey.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            resources.ApplyResources(this.btSearch, "btSearch");
            this.btSearch.Name = "btSearch";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btClick_Search);
            // 
            // btRemove
            // 
            resources.ApplyResources(this.btRemove, "btRemove");
            this.btRemove.Name = "btRemove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btClick_Remove);
            // 
            // btShow
            // 
            resources.ApplyResources(this.btShow, "btShow");
            this.btShow.Name = "btShow";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btClick_Show);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // titleDictionary
            // 
            resources.ApplyResources(this.titleDictionary, "titleDictionary");
            this.titleDictionary.Name = "titleDictionary";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleDictionary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputKey);
            this.Controls.Add(this.lsDictionary);
            this.Controls.Add(this.inputValue);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputValue;
        private TextBox lsDictionary;
        private TextBox inputKey;
        private Label label1;
        private Button btAdd;
        private Button btSearch;
        private Button btRemove;
        private Button btShow;
        private Label label2;
        private Label label3;
        private Label titleDictionary;
    }
}