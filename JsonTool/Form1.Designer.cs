namespace JsonTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.JapaneseName = new System.Windows.Forms.TextBox();
            this.EnglishName = new System.Windows.Forms.TextBox();
            this.ChineseSimplifiedName = new System.Windows.Forms.TextBox();
            this.ChineseTraditionalName = new System.Windows.Forms.TextBox();
            this.Rarity = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Effect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TreassureProbs0 = new System.Windows.Forms.NumericUpDown();
            this.Stone = new System.Windows.Forms.NumericUpDown();
            this.Tree = new System.Windows.Forms.NumericUpDown();
            this.Random = new System.Windows.Forms.NumericUpDown();
            this.Enemy = new System.Windows.Forms.ComboBox();
            this.EffectValue = new System.Windows.Forms.NumericUpDown();
            this.EnemyProbs = new System.Windows.Forms.NumericUpDown();
            this.EnemyProbsList = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EffectValuesList = new System.Windows.Forms.ListBox();
            this.EnemyAdd = new System.Windows.Forms.Button();
            this.EffectAdd = new System.Windows.Forms.Button();
            this.EnemyRemove = new System.Windows.Forms.Button();
            this.EffectRemove = new System.Windows.Forms.Button();
            this.EnemyClear = new System.Windows.Forms.Button();
            this.EffectClear = new System.Windows.Forms.Button();
            this.TreassureProbs1 = new System.Windows.Forms.NumericUpDown();
            this.TreassureProbs2 = new System.Windows.Forms.NumericUpDown();
            this.TreassureProbs3 = new System.Windows.Forms.NumericUpDown();
            this.TreassureProbs4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ExtraValue = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.EnchantID = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyProbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnchantID)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.saveFileToolStripMenuItem.Text = "SaveFile";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Japanse Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "English Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chinese Simplified Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chinese Traditional Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rarity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(30, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "TreassureProbs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(30, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "StoneProbs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(30, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "TreeProbs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(30, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "UnspecifiedEnemyDropProbs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(30, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "SpecifiedEnemyDropProbs";
            // 
            // JapaneseName
            // 
            this.JapaneseName.Location = new System.Drawing.Point(320, 50);
            this.JapaneseName.Name = "JapaneseName";
            this.JapaneseName.Size = new System.Drawing.Size(250, 19);
            this.JapaneseName.TabIndex = 14;
            // 
            // EnglishName
            // 
            this.EnglishName.Location = new System.Drawing.Point(320, 80);
            this.EnglishName.Name = "EnglishName";
            this.EnglishName.Size = new System.Drawing.Size(250, 19);
            this.EnglishName.TabIndex = 15;
            // 
            // ChineseSimplifiedName
            // 
            this.ChineseSimplifiedName.Location = new System.Drawing.Point(320, 110);
            this.ChineseSimplifiedName.Name = "ChineseSimplifiedName";
            this.ChineseSimplifiedName.Size = new System.Drawing.Size(250, 19);
            this.ChineseSimplifiedName.TabIndex = 16;
            // 
            // ChineseTraditionalName
            // 
            this.ChineseTraditionalName.Location = new System.Drawing.Point(320, 140);
            this.ChineseTraditionalName.Name = "ChineseTraditionalName";
            this.ChineseTraditionalName.Size = new System.Drawing.Size(250, 19);
            this.ChineseTraditionalName.TabIndex = 17;
            // 
            // Rarity
            // 
            this.Rarity.FormattingEnabled = true;
            this.Rarity.Location = new System.Drawing.Point(320, 173);
            this.Rarity.Name = "Rarity";
            this.Rarity.Size = new System.Drawing.Size(121, 20);
            this.Rarity.TabIndex = 18;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(320, 203);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 20);
            this.Category.TabIndex = 19;
            // 
            // Effect
            // 
            this.Effect.FormattingEnabled = true;
            this.Effect.Location = new System.Drawing.Point(320, 380);
            this.Effect.Name = "Effect";
            this.Effect.Size = new System.Drawing.Size(120, 20);
            this.Effect.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(30, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Effect";
            // 
            // TreassureProbs0
            // 
            this.TreassureProbs0.DecimalPlaces = 3;
            this.TreassureProbs0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TreassureProbs0.Location = new System.Drawing.Point(320, 230);
            this.TreassureProbs0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TreassureProbs0.Name = "TreassureProbs0";
            this.TreassureProbs0.Size = new System.Drawing.Size(45, 19);
            this.TreassureProbs0.TabIndex = 22;
            // 
            // Stone
            // 
            this.Stone.DecimalPlaces = 3;
            this.Stone.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Stone.Location = new System.Drawing.Point(320, 260);
            this.Stone.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stone.Name = "Stone";
            this.Stone.Size = new System.Drawing.Size(120, 19);
            this.Stone.TabIndex = 23;
            // 
            // Tree
            // 
            this.Tree.DecimalPlaces = 3;
            this.Tree.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Tree.Location = new System.Drawing.Point(320, 290);
            this.Tree.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(120, 19);
            this.Tree.TabIndex = 24;
            // 
            // Random
            // 
            this.Random.DecimalPlaces = 3;
            this.Random.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Random.Location = new System.Drawing.Point(320, 320);
            this.Random.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(120, 19);
            this.Random.TabIndex = 25;
            // 
            // Enemy
            // 
            this.Enemy.FormattingEnabled = true;
            this.Enemy.Location = new System.Drawing.Point(320, 350);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(120, 20);
            this.Enemy.TabIndex = 26;
            // 
            // EffectValue
            // 
            this.EffectValue.DecimalPlaces = 2;
            this.EffectValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EffectValue.Location = new System.Drawing.Point(450, 380);
            this.EffectValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EffectValue.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.EffectValue.Name = "EffectValue";
            this.EffectValue.Size = new System.Drawing.Size(120, 19);
            this.EffectValue.TabIndex = 28;
            // 
            // EnemyProbs
            // 
            this.EnemyProbs.DecimalPlaces = 3;
            this.EnemyProbs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.EnemyProbs.Location = new System.Drawing.Point(450, 350);
            this.EnemyProbs.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnemyProbs.Name = "EnemyProbs";
            this.EnemyProbs.Size = new System.Drawing.Size(120, 19);
            this.EnemyProbs.TabIndex = 27;
            // 
            // EnemyProbsList
            // 
            this.EnemyProbsList.FormattingEnabled = true;
            this.EnemyProbsList.ItemHeight = 12;
            this.EnemyProbsList.Location = new System.Drawing.Point(580, 77);
            this.EnemyProbsList.Name = "EnemyProbsList";
            this.EnemyProbsList.Size = new System.Drawing.Size(235, 112);
            this.EnemyProbsList.TabIndex = 30;
            this.EnemyProbsList.SelectedIndexChanged += new System.EventHandler(this.EnemyProbsList_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(580, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "SpecifiedEnemyDropProbs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(580, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "EffectValues";
            // 
            // EffectValuesList
            // 
            this.EffectValuesList.FormattingEnabled = true;
            this.EffectValuesList.ItemHeight = 12;
            this.EffectValuesList.Location = new System.Drawing.Point(580, 227);
            this.EffectValuesList.Name = "EffectValuesList";
            this.EffectValuesList.Size = new System.Drawing.Size(235, 112);
            this.EffectValuesList.TabIndex = 33;
            this.EffectValuesList.SelectedIndexChanged += new System.EventHandler(this.EffectValuesList_SelectedIndexChanged);
            // 
            // EnemyAdd
            // 
            this.EnemyAdd.Location = new System.Drawing.Point(580, 350);
            this.EnemyAdd.Name = "EnemyAdd";
            this.EnemyAdd.Size = new System.Drawing.Size(75, 19);
            this.EnemyAdd.TabIndex = 34;
            this.EnemyAdd.Text = "Add";
            this.EnemyAdd.UseVisualStyleBackColor = true;
            this.EnemyAdd.Click += new System.EventHandler(this.EnemyAdd_Click);
            // 
            // EffectAdd
            // 
            this.EffectAdd.Location = new System.Drawing.Point(580, 380);
            this.EffectAdd.Name = "EffectAdd";
            this.EffectAdd.Size = new System.Drawing.Size(75, 19);
            this.EffectAdd.TabIndex = 35;
            this.EffectAdd.Text = "Add";
            this.EffectAdd.UseVisualStyleBackColor = true;
            this.EffectAdd.Click += new System.EventHandler(this.EffectAdd_Click);
            // 
            // EnemyRemove
            // 
            this.EnemyRemove.Location = new System.Drawing.Point(660, 350);
            this.EnemyRemove.Name = "EnemyRemove";
            this.EnemyRemove.Size = new System.Drawing.Size(75, 19);
            this.EnemyRemove.TabIndex = 36;
            this.EnemyRemove.Text = "Remove";
            this.EnemyRemove.UseVisualStyleBackColor = true;
            this.EnemyRemove.Click += new System.EventHandler(this.EnemyRemove_Click);
            // 
            // EffectRemove
            // 
            this.EffectRemove.Location = new System.Drawing.Point(660, 380);
            this.EffectRemove.Name = "EffectRemove";
            this.EffectRemove.Size = new System.Drawing.Size(75, 19);
            this.EffectRemove.TabIndex = 37;
            this.EffectRemove.Text = "Remove";
            this.EffectRemove.UseVisualStyleBackColor = true;
            this.EffectRemove.Click += new System.EventHandler(this.EffectRemove_Click);
            // 
            // EnemyClear
            // 
            this.EnemyClear.Location = new System.Drawing.Point(740, 350);
            this.EnemyClear.Name = "EnemyClear";
            this.EnemyClear.Size = new System.Drawing.Size(75, 19);
            this.EnemyClear.TabIndex = 38;
            this.EnemyClear.Text = "Clear";
            this.EnemyClear.UseVisualStyleBackColor = true;
            this.EnemyClear.Click += new System.EventHandler(this.EnemyClear_Click);
            // 
            // EffectClear
            // 
            this.EffectClear.Location = new System.Drawing.Point(740, 380);
            this.EffectClear.Name = "EffectClear";
            this.EffectClear.Size = new System.Drawing.Size(75, 19);
            this.EffectClear.TabIndex = 39;
            this.EffectClear.Text = "Clear";
            this.EffectClear.UseVisualStyleBackColor = true;
            this.EffectClear.Click += new System.EventHandler(this.EffectClear_Click);
            // 
            // TreassureProbs1
            // 
            this.TreassureProbs1.DecimalPlaces = 3;
            this.TreassureProbs1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TreassureProbs1.Location = new System.Drawing.Point(370, 230);
            this.TreassureProbs1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TreassureProbs1.Name = "TreassureProbs1";
            this.TreassureProbs1.Size = new System.Drawing.Size(45, 19);
            this.TreassureProbs1.TabIndex = 40;
            // 
            // TreassureProbs2
            // 
            this.TreassureProbs2.DecimalPlaces = 3;
            this.TreassureProbs2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TreassureProbs2.Location = new System.Drawing.Point(420, 230);
            this.TreassureProbs2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TreassureProbs2.Name = "TreassureProbs2";
            this.TreassureProbs2.Size = new System.Drawing.Size(45, 19);
            this.TreassureProbs2.TabIndex = 41;
            // 
            // TreassureProbs3
            // 
            this.TreassureProbs3.DecimalPlaces = 3;
            this.TreassureProbs3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TreassureProbs3.Location = new System.Drawing.Point(470, 230);
            this.TreassureProbs3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TreassureProbs3.Name = "TreassureProbs3";
            this.TreassureProbs3.Size = new System.Drawing.Size(45, 19);
            this.TreassureProbs3.TabIndex = 42;
            // 
            // TreassureProbs4
            // 
            this.TreassureProbs4.DecimalPlaces = 3;
            this.TreassureProbs4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TreassureProbs4.Location = new System.Drawing.Point(520, 230);
            this.TreassureProbs4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TreassureProbs4.Name = "TreassureProbs4";
            this.TreassureProbs4.Size = new System.Drawing.Size(45, 19);
            this.TreassureProbs4.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(30, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 19);
            this.label15.TabIndex = 44;
            this.label15.Text = "ExtraValue";
            // 
            // ExtraValue
            // 
            this.ExtraValue.Location = new System.Drawing.Point(320, 410);
            this.ExtraValue.Name = "ExtraValue";
            this.ExtraValue.Size = new System.Drawing.Size(250, 19);
            this.ExtraValue.TabIndex = 45;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Id.Location = new System.Drawing.Point(30, 440);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(26, 19);
            this.Id.TabIndex = 46;
            this.Id.Text = "ID";
            // 
            // EnchantID
            // 
            this.EnchantID.Location = new System.Drawing.Point(320, 440);
            this.EnchantID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EnchantID.Name = "EnchantID";
            this.EnchantID.Size = new System.Drawing.Size(120, 19);
            this.EnchantID.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 487);
            this.Controls.Add(this.EnchantID);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.ExtraValue);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TreassureProbs4);
            this.Controls.Add(this.TreassureProbs3);
            this.Controls.Add(this.TreassureProbs2);
            this.Controls.Add(this.TreassureProbs1);
            this.Controls.Add(this.EffectClear);
            this.Controls.Add(this.EnemyClear);
            this.Controls.Add(this.EffectRemove);
            this.Controls.Add(this.EnemyRemove);
            this.Controls.Add(this.EffectAdd);
            this.Controls.Add(this.EnemyAdd);
            this.Controls.Add(this.EffectValuesList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EnemyProbsList);
            this.Controls.Add(this.EffectValue);
            this.Controls.Add(this.EnemyProbs);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Stone);
            this.Controls.Add(this.TreassureProbs0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Rarity);
            this.Controls.Add(this.ChineseTraditionalName);
            this.Controls.Add(this.ChineseSimplifiedName);
            this.Controls.Add(this.EnglishName);
            this.Controls.Add(this.JapaneseName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyProbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreassureProbs4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnchantID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox JapaneseName;
        private System.Windows.Forms.TextBox EnglishName;
        private System.Windows.Forms.TextBox ChineseSimplifiedName;
        private System.Windows.Forms.TextBox ChineseTraditionalName;
        private System.Windows.Forms.ComboBox Rarity;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.ComboBox Effect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown TreassureProbs0;
        private System.Windows.Forms.NumericUpDown Stone;
        private System.Windows.Forms.NumericUpDown Tree;
        private System.Windows.Forms.NumericUpDown Random;
        private System.Windows.Forms.ComboBox Enemy;
        private System.Windows.Forms.NumericUpDown EffectValue;
        private System.Windows.Forms.NumericUpDown EnemyProbs;
        private System.Windows.Forms.ListBox EnemyProbsList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox EffectValuesList;
        private System.Windows.Forms.Button EnemyAdd;
        private System.Windows.Forms.Button EffectAdd;
        private System.Windows.Forms.Button EnemyRemove;
        private System.Windows.Forms.Button EffectRemove;
        private System.Windows.Forms.Button EnemyClear;
        private System.Windows.Forms.Button EffectClear;
        private System.Windows.Forms.NumericUpDown TreassureProbs1;
        private System.Windows.Forms.NumericUpDown TreassureProbs2;
        private System.Windows.Forms.NumericUpDown TreassureProbs3;
        private System.Windows.Forms.NumericUpDown TreassureProbs4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ExtraValue;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.NumericUpDown EnchantID;
    }
}

