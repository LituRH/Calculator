namespace WindowsEightCalculator
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
            this.inputOutputTextBox = new System.Windows.Forms.TextBox();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.memoryDecrementButton = new System.Windows.Forms.Button();
            this.memoryIncrementButton = new System.Windows.Forms.Button();
            this.memorySetButton = new System.Windows.Forms.Button();
            this.memoryReturnButton = new System.Windows.Forms.Button();
            this.clearExpressionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.positiveNegativeButton = new System.Windows.Forms.Button();
            this.squreRootButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.eightNumberButton = new System.Windows.Forms.Button();
            this.nineNumberButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.modulasButton = new System.Windows.Forms.Button();
            this.sevenNumberButton = new System.Windows.Forms.Button();
            this.fiveNumberButton = new System.Windows.Forms.Button();
            this.sixNumberButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.inverseButton = new System.Windows.Forms.Button();
            this.fourNumberButton = new System.Windows.Forms.Button();
            this.twoNumberButton = new System.Windows.Forms.Button();
            this.threeNumberButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.oneNumberButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.zeroNumberButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.memoryLabal = new System.Windows.Forms.Label();
            this.topTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputOutputTextBox
            // 
            this.inputOutputTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.inputOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOutputTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputOutputTextBox.Location = new System.Drawing.Point(1, 38);
            this.inputOutputTextBox.MaxLength = 10;
            this.inputOutputTextBox.Multiline = true;
            this.inputOutputTextBox.Name = "inputOutputTextBox";
            this.inputOutputTextBox.ReadOnly = true;
            this.inputOutputTextBox.Size = new System.Drawing.Size(227, 37);
            this.inputOutputTextBox.TabIndex = 0;
            this.inputOutputTextBox.Text = "0";
            this.inputOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputOutputTextBox.TextChanged += new System.EventHandler(this.inputOutputTextBox_TextChanged);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryClearButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memoryClearButton.Location = new System.Drawing.Point(1, 86);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(42, 25);
            this.memoryClearButton.TabIndex = 1;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.memoryClearButton_Click);
            // 
            // memoryDecrementButton
            // 
            this.memoryDecrementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryDecrementButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memoryDecrementButton.Location = new System.Drawing.Point(193, 86);
            this.memoryDecrementButton.Name = "memoryDecrementButton";
            this.memoryDecrementButton.Size = new System.Drawing.Size(35, 25);
            this.memoryDecrementButton.TabIndex = 2;
            this.memoryDecrementButton.Text = "M-";
            this.memoryDecrementButton.UseVisualStyleBackColor = true;
            this.memoryDecrementButton.Click += new System.EventHandler(this.memoryDecrementButton_Click);
            // 
            // memoryIncrementButton
            // 
            this.memoryIncrementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryIncrementButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memoryIncrementButton.Location = new System.Drawing.Point(145, 86);
            this.memoryIncrementButton.Name = "memoryIncrementButton";
            this.memoryIncrementButton.Size = new System.Drawing.Size(42, 25);
            this.memoryIncrementButton.TabIndex = 3;
            this.memoryIncrementButton.Text = "M+";
            this.memoryIncrementButton.UseVisualStyleBackColor = true;
            this.memoryIncrementButton.Click += new System.EventHandler(this.memoryIncrementButton_Click);
            // 
            // memorySetButton
            // 
            this.memorySetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorySetButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memorySetButton.Location = new System.Drawing.Point(97, 86);
            this.memorySetButton.Name = "memorySetButton";
            this.memorySetButton.Size = new System.Drawing.Size(42, 25);
            this.memorySetButton.TabIndex = 4;
            this.memorySetButton.Text = "MS";
            this.memorySetButton.UseVisualStyleBackColor = true;
            this.memorySetButton.Click += new System.EventHandler(this.memorySetButton_Click);
            // 
            // memoryReturnButton
            // 
            this.memoryReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryReturnButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memoryReturnButton.Location = new System.Drawing.Point(49, 86);
            this.memoryReturnButton.Name = "memoryReturnButton";
            this.memoryReturnButton.Size = new System.Drawing.Size(42, 25);
            this.memoryReturnButton.TabIndex = 5;
            this.memoryReturnButton.Text = "MR";
            this.memoryReturnButton.UseVisualStyleBackColor = true;
            this.memoryReturnButton.Click += new System.EventHandler(this.memoryReturnButton_Click);
            // 
            // clearExpressionButton
            // 
            this.clearExpressionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearExpressionButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearExpressionButton.Location = new System.Drawing.Point(49, 126);
            this.clearExpressionButton.Name = "clearExpressionButton";
            this.clearExpressionButton.Size = new System.Drawing.Size(42, 25);
            this.clearExpressionButton.TabIndex = 10;
            this.clearExpressionButton.Text = "CE";
            this.clearExpressionButton.UseVisualStyleBackColor = true;
            this.clearExpressionButton.Click += new System.EventHandler(this.clearExpressionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearButton.Location = new System.Drawing.Point(97, 126);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(42, 25);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // positiveNegativeButton
            // 
            this.positiveNegativeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveNegativeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.positiveNegativeButton.Location = new System.Drawing.Point(145, 126);
            this.positiveNegativeButton.Name = "positiveNegativeButton";
            this.positiveNegativeButton.Size = new System.Drawing.Size(42, 25);
            this.positiveNegativeButton.TabIndex = 8;
            this.positiveNegativeButton.Tag = "";
            this.positiveNegativeButton.Text = " ±";
            this.positiveNegativeButton.UseVisualStyleBackColor = true;
            this.positiveNegativeButton.Click += new System.EventHandler(this.positiveNegativeButton_Click);
            // 
            // squreRootButton
            // 
            this.squreRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squreRootButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.squreRootButton.Location = new System.Drawing.Point(193, 126);
            this.squreRootButton.Name = "squreRootButton";
            this.squreRootButton.Size = new System.Drawing.Size(35, 25);
            this.squreRootButton.TabIndex = 7;
            this.squreRootButton.Text = " √";
            this.squreRootButton.UseVisualStyleBackColor = true;
            this.squreRootButton.Click += new System.EventHandler(this.squreRootButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.backspaceButton.Location = new System.Drawing.Point(1, 126);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(42, 25);
            this.backspaceButton.TabIndex = 6;
            this.backspaceButton.Text = "←";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // eightNumberButton
            // 
            this.eightNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eightNumberButton.Location = new System.Drawing.Point(46, 169);
            this.eightNumberButton.Name = "eightNumberButton";
            this.eightNumberButton.Size = new System.Drawing.Size(45, 25);
            this.eightNumberButton.TabIndex = 15;
            this.eightNumberButton.Text = "8";
            this.eightNumberButton.UseVisualStyleBackColor = true;
            this.eightNumberButton.Click += new System.EventHandler(this.eightNumberButton_Click);
            // 
            // nineNumberButton
            // 
            this.nineNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nineNumberButton.Location = new System.Drawing.Point(97, 169);
            this.nineNumberButton.Name = "nineNumberButton";
            this.nineNumberButton.Size = new System.Drawing.Size(42, 25);
            this.nineNumberButton.TabIndex = 14;
            this.nineNumberButton.Text = "9";
            this.nineNumberButton.UseVisualStyleBackColor = true;
            this.nineNumberButton.Click += new System.EventHandler(this.nineNumberButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.divButton.Location = new System.Drawing.Point(145, 169);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(42, 25);
            this.divButton.TabIndex = 13;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // modulasButton
            // 
            this.modulasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulasButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modulasButton.Location = new System.Drawing.Point(193, 169);
            this.modulasButton.Name = "modulasButton";
            this.modulasButton.Size = new System.Drawing.Size(35, 25);
            this.modulasButton.TabIndex = 12;
            this.modulasButton.Text = "%";
            this.modulasButton.UseVisualStyleBackColor = true;
            this.modulasButton.Click += new System.EventHandler(this.modulasButton_Click);
            // 
            // sevenNumberButton
            // 
            this.sevenNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sevenNumberButton.Location = new System.Drawing.Point(1, 169);
            this.sevenNumberButton.Name = "sevenNumberButton";
            this.sevenNumberButton.Size = new System.Drawing.Size(42, 25);
            this.sevenNumberButton.TabIndex = 11;
            this.sevenNumberButton.Text = "7";
            this.sevenNumberButton.UseVisualStyleBackColor = true;
            this.sevenNumberButton.Click += new System.EventHandler(this.sevenNumberButton_Click);
            // 
            // fiveNumberButton
            // 
            this.fiveNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fiveNumberButton.Location = new System.Drawing.Point(49, 211);
            this.fiveNumberButton.Name = "fiveNumberButton";
            this.fiveNumberButton.Size = new System.Drawing.Size(42, 25);
            this.fiveNumberButton.TabIndex = 20;
            this.fiveNumberButton.Text = "5";
            this.fiveNumberButton.UseVisualStyleBackColor = true;
            this.fiveNumberButton.Click += new System.EventHandler(this.fiveNumberButton_Click);
            // 
            // sixNumberButton
            // 
            this.sixNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sixNumberButton.Location = new System.Drawing.Point(97, 211);
            this.sixNumberButton.Name = "sixNumberButton";
            this.sixNumberButton.Size = new System.Drawing.Size(42, 25);
            this.sixNumberButton.TabIndex = 19;
            this.sixNumberButton.Text = "6";
            this.sixNumberButton.UseVisualStyleBackColor = true;
            this.sixNumberButton.Click += new System.EventHandler(this.sixNumberButton_Click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.multButton.Location = new System.Drawing.Point(145, 211);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(42, 25);
            this.multButton.TabIndex = 18;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // inverseButton
            // 
            this.inverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inverseButton.Location = new System.Drawing.Point(193, 212);
            this.inverseButton.Name = "inverseButton";
            this.inverseButton.Size = new System.Drawing.Size(35, 25);
            this.inverseButton.TabIndex = 17;
            this.inverseButton.Text = "1/x";
            this.inverseButton.UseVisualStyleBackColor = true;
            this.inverseButton.Click += new System.EventHandler(this.inverseButton_Click);
            // 
            // fourNumberButton
            // 
            this.fourNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fourNumberButton.Location = new System.Drawing.Point(1, 211);
            this.fourNumberButton.Name = "fourNumberButton";
            this.fourNumberButton.Size = new System.Drawing.Size(42, 25);
            this.fourNumberButton.TabIndex = 16;
            this.fourNumberButton.Text = "4";
            this.fourNumberButton.UseVisualStyleBackColor = true;
            this.fourNumberButton.Click += new System.EventHandler(this.fourNumberButton_Click);
            // 
            // twoNumberButton
            // 
            this.twoNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.twoNumberButton.Location = new System.Drawing.Point(49, 252);
            this.twoNumberButton.Name = "twoNumberButton";
            this.twoNumberButton.Size = new System.Drawing.Size(42, 25);
            this.twoNumberButton.TabIndex = 25;
            this.twoNumberButton.Text = "2";
            this.twoNumberButton.UseVisualStyleBackColor = true;
            this.twoNumberButton.Click += new System.EventHandler(this.twoNumberButton_Click);
            // 
            // threeNumberButton
            // 
            this.threeNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.threeNumberButton.Location = new System.Drawing.Point(97, 252);
            this.threeNumberButton.Name = "threeNumberButton";
            this.threeNumberButton.Size = new System.Drawing.Size(42, 25);
            this.threeNumberButton.TabIndex = 24;
            this.threeNumberButton.Text = "3";
            this.threeNumberButton.UseVisualStyleBackColor = true;
            this.threeNumberButton.Click += new System.EventHandler(this.threeNumberButton_Click);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subButton.Location = new System.Drawing.Point(145, 252);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(42, 25);
            this.subButton.TabIndex = 23;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // oneNumberButton
            // 
            this.oneNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.oneNumberButton.Location = new System.Drawing.Point(1, 252);
            this.oneNumberButton.Name = "oneNumberButton";
            this.oneNumberButton.Size = new System.Drawing.Size(42, 25);
            this.oneNumberButton.TabIndex = 21;
            this.oneNumberButton.Text = "1";
            this.oneNumberButton.UseVisualStyleBackColor = true;
            this.oneNumberButton.Click += new System.EventHandler(this.oneNumberButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pointButton.Location = new System.Drawing.Point(97, 294);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(42, 25);
            this.pointButton.TabIndex = 29;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sumButton.Location = new System.Drawing.Point(145, 294);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(42, 25);
            this.sumButton.TabIndex = 28;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.equalButton.Location = new System.Drawing.Point(193, 252);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(35, 67);
            this.equalButton.TabIndex = 27;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // zeroNumberButton
            // 
            this.zeroNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroNumberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.zeroNumberButton.Location = new System.Drawing.Point(1, 294);
            this.zeroNumberButton.Name = "zeroNumberButton";
            this.zeroNumberButton.Size = new System.Drawing.Size(90, 25);
            this.zeroNumberButton.TabIndex = 26;
            this.zeroNumberButton.Text = "0";
            this.zeroNumberButton.UseVisualStyleBackColor = true;
            this.zeroNumberButton.Click += new System.EventHandler(this.zeroNumberButton_Click);
            // 
            // memoryLabal
            // 
            this.memoryLabal.AutoSize = true;
            this.memoryLabal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.memoryLabal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.memoryLabal.Location = new System.Drawing.Point(8, 52);
            this.memoryLabal.Name = "memoryLabal";
            this.memoryLabal.Size = new System.Drawing.Size(0, 13);
            this.memoryLabal.TabIndex = 30;
            this.memoryLabal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topTextBox
            // 
            this.topTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.topTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.topTextBox.Location = new System.Drawing.Point(1, 12);
            this.topTextBox.Multiline = true;
            this.topTextBox.Name = "topTextBox";
            this.topTextBox.ReadOnly = true;
            this.topTextBox.Size = new System.Drawing.Size(227, 27);
            this.topTextBox.TabIndex = 31;
            this.topTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.topTextBox.TextChanged += new System.EventHandler(this.topTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 329);
            this.Controls.Add(this.topTextBox);
            this.Controls.Add(this.memoryLabal);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.zeroNumberButton);
            this.Controls.Add(this.twoNumberButton);
            this.Controls.Add(this.threeNumberButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.oneNumberButton);
            this.Controls.Add(this.fiveNumberButton);
            this.Controls.Add(this.sixNumberButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.inverseButton);
            this.Controls.Add(this.fourNumberButton);
            this.Controls.Add(this.eightNumberButton);
            this.Controls.Add(this.nineNumberButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.modulasButton);
            this.Controls.Add(this.sevenNumberButton);
            this.Controls.Add(this.clearExpressionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.positiveNegativeButton);
            this.Controls.Add(this.squreRootButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.memoryReturnButton);
            this.Controls.Add(this.memorySetButton);
            this.Controls.Add(this.memoryIncrementButton);
            this.Controls.Add(this.memoryDecrementButton);
            this.Controls.Add(this.memoryClearButton);
            this.Controls.Add(this.inputOutputTextBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputOutputTextBox;
        private System.Windows.Forms.Button memoryClearButton;
        private System.Windows.Forms.Button memoryDecrementButton;
        private System.Windows.Forms.Button memoryIncrementButton;
        private System.Windows.Forms.Button memorySetButton;
        private System.Windows.Forms.Button memoryReturnButton;
        private System.Windows.Forms.Button clearExpressionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button positiveNegativeButton;
        private System.Windows.Forms.Button squreRootButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button eightNumberButton;
        private System.Windows.Forms.Button nineNumberButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button modulasButton;
        private System.Windows.Forms.Button sevenNumberButton;
        private System.Windows.Forms.Button fiveNumberButton;
        private System.Windows.Forms.Button sixNumberButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button inverseButton;
        private System.Windows.Forms.Button fourNumberButton;
        private System.Windows.Forms.Button twoNumberButton;
        private System.Windows.Forms.Button threeNumberButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button oneNumberButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button zeroNumberButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label memoryLabal;
        private System.Windows.Forms.TextBox topTextBox;
    }
}

