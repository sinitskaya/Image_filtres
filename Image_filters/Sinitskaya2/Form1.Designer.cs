namespace Sinitskaya2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перерносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крест3х3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат3х3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат5х5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крест3х3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат3х3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат5х5ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крест3х3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат3х3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат5х5ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крест3х3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат3х3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат5х5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат3х3ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадрат5х5ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.крест3х3ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.морфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.чернобелоеToolStripMenuItem,
            this.перерносToolStripMenuItem,
            this.стеклоToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // чернобелоеToolStripMenuItem
            // 
            this.чернобелоеToolStripMenuItem.Name = "чернобелоеToolStripMenuItem";
            this.чернобелоеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.чернобелоеToolStripMenuItem.Text = "Черно-белое";
            this.чернобелоеToolStripMenuItem.Click += new System.EventHandler(this.чернобелоеToolStripMenuItem_Click);
            // 
            // перерносToolStripMenuItem
            // 
            this.перерносToolStripMenuItem.Name = "перерносToolStripMenuItem";
            this.перерносToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.перерносToolStripMenuItem.Text = "Перернос";
            this.перерносToolStripMenuItem.Click += new System.EventHandler(this.перерносToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.гаусаToolStripMenuItem,
            this.собеляToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // гаусаToolStripMenuItem
            // 
            this.гаусаToolStripMenuItem.Name = "гаусаToolStripMenuItem";
            this.гаусаToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.гаусаToolStripMenuItem.Text = "Гаусса";
            this.гаусаToolStripMenuItem.Click += new System.EventHandler(this.гаусаToolStripMenuItem_Click);
            // 
            // собеляToolStripMenuItem
            // 
            this.собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            this.собеляToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.собеляToolStripMenuItem.Text = "Собеля";
            this.собеляToolStripMenuItem.Click += new System.EventHandler(this.собеляToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // морфологияToolStripMenuItem
            // 
            this.морфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.gradToolStripMenuItem});
            this.морфологияToolStripMenuItem.Name = "морфологияToolStripMenuItem";
            this.морфологияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.морфологияToolStripMenuItem.Text = "Морфология";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расширениеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.сужениеToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крест3х3ToolStripMenuItem,
            this.квадрат3х3ToolStripMenuItem1,
            this.квадрат5х5ToolStripMenuItem1});
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.расширениеToolStripMenuItem.Text = "Расширение";
            // 
            // крест3х3ToolStripMenuItem
            // 
            this.крест3х3ToolStripMenuItem.Name = "крест3х3ToolStripMenuItem";
            this.крест3х3ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.крест3х3ToolStripMenuItem.Text = "Крест(3х3)";
            this.крест3х3ToolStripMenuItem.Click += new System.EventHandler(this.крест3х3ToolStripMenuItem_Click);
            // 
            // квадрат3х3ToolStripMenuItem1
            // 
            this.квадрат3х3ToolStripMenuItem1.Name = "квадрат3х3ToolStripMenuItem1";
            this.квадрат3х3ToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.квадрат3х3ToolStripMenuItem1.Text = "Квадрат(3х3)";
            this.квадрат3х3ToolStripMenuItem1.Click += new System.EventHandler(this.квадрат3х3ToolStripMenuItem1_Click);
            // 
            // квадрат5х5ToolStripMenuItem1
            // 
            this.квадрат5х5ToolStripMenuItem1.Name = "квадрат5х5ToolStripMenuItem1";
            this.квадрат5х5ToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.квадрат5х5ToolStripMenuItem1.Text = "Квадрат(5х5)";
            this.квадрат5х5ToolStripMenuItem1.Click += new System.EventHandler(this.квадрат5х5ToolStripMenuItem1_Click);
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крест3х3ToolStripMenuItem1,
            this.квадрат3х3ToolStripMenuItem2,
            this.квадрат5х5ToolStripMenuItem2});
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.открытиеToolStripMenuItem.Text = "Открытие";
            // 
            // крест3х3ToolStripMenuItem1
            // 
            this.крест3х3ToolStripMenuItem1.Name = "крест3х3ToolStripMenuItem1";
            this.крест3х3ToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.крест3х3ToolStripMenuItem1.Text = "Крест(3х3)";
            this.крест3х3ToolStripMenuItem1.Click += new System.EventHandler(this.крест3х3ToolStripMenuItem1_Click);
            // 
            // квадрат3х3ToolStripMenuItem2
            // 
            this.квадрат3х3ToolStripMenuItem2.Name = "квадрат3х3ToolStripMenuItem2";
            this.квадрат3х3ToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.квадрат3х3ToolStripMenuItem2.Text = "Квадрат(3х3)";
            this.квадрат3х3ToolStripMenuItem2.Click += new System.EventHandler(this.квадрат3х3ToolStripMenuItem2_Click);
            // 
            // квадрат5х5ToolStripMenuItem2
            // 
            this.квадрат5х5ToolStripMenuItem2.Name = "квадрат5х5ToolStripMenuItem2";
            this.квадрат5х5ToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.квадрат5х5ToolStripMenuItem2.Text = "Квадрат(5х5)";
            this.квадрат5х5ToolStripMenuItem2.Click += new System.EventHandler(this.квадрат5х5ToolStripMenuItem2_Click);
            // 
            // закрытиеToolStripMenuItem
            // 
            this.закрытиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крест3х3ToolStripMenuItem2,
            this.квадрат3х3ToolStripMenuItem3,
            this.квадрат5х5ToolStripMenuItem3});
            this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.закрытиеToolStripMenuItem.Text = "Закрытие";
            // 
            // крест3х3ToolStripMenuItem2
            // 
            this.крест3х3ToolStripMenuItem2.Name = "крест3х3ToolStripMenuItem2";
            this.крест3х3ToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.крест3х3ToolStripMenuItem2.Text = "Крест(3х3)";
            this.крест3х3ToolStripMenuItem2.Click += new System.EventHandler(this.крест3х3ToolStripMenuItem2_Click);
            // 
            // квадрат3х3ToolStripMenuItem3
            // 
            this.квадрат3х3ToolStripMenuItem3.Name = "квадрат3х3ToolStripMenuItem3";
            this.квадрат3х3ToolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.квадрат3х3ToolStripMenuItem3.Text = "Квадрат(3х3)";
            this.квадрат3х3ToolStripMenuItem3.Click += new System.EventHandler(this.квадрат3х3ToolStripMenuItem3_Click);
            // 
            // квадрат5х5ToolStripMenuItem3
            // 
            this.квадрат5х5ToolStripMenuItem3.Name = "квадрат5х5ToolStripMenuItem3";
            this.квадрат5х5ToolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.квадрат5х5ToolStripMenuItem3.Text = "Квадрат(5х5)";
            this.квадрат5х5ToolStripMenuItem3.Click += new System.EventHandler(this.квадрат5х5ToolStripMenuItem3_Click);
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крест3х3ToolStripMenuItem3,
            this.квадрат3х3ToolStripMenuItem,
            this.квадрат5х5ToolStripMenuItem});
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.сужениеToolStripMenuItem.Text = "Сужение";
            // 
            // крест3х3ToolStripMenuItem3
            // 
            this.крест3х3ToolStripMenuItem3.Name = "крест3х3ToolStripMenuItem3";
            this.крест3х3ToolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.крест3х3ToolStripMenuItem3.Text = "Крест(3х3)";
            this.крест3х3ToolStripMenuItem3.Click += new System.EventHandler(this.крест3х3ToolStripMenuItem3_Click);
            // 
            // квадрат3х3ToolStripMenuItem
            // 
            this.квадрат3х3ToolStripMenuItem.Name = "квадрат3х3ToolStripMenuItem";
            this.квадрат3х3ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.квадрат3х3ToolStripMenuItem.Text = "Квадрат(3х3)";
            this.квадрат3х3ToolStripMenuItem.Click += new System.EventHandler(this.квадрат3х3ToolStripMenuItem_Click);
            // 
            // квадрат5х5ToolStripMenuItem
            // 
            this.квадрат5х5ToolStripMenuItem.Name = "квадрат5х5ToolStripMenuItem";
            this.квадрат5х5ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.квадрат5х5ToolStripMenuItem.Text = "Квадрат(5х5)";
            this.квадрат5х5ToolStripMenuItem.Click += new System.EventHandler(this.квадрат5х5ToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадрат3х3ToolStripMenuItem4,
            this.квадрат5х5ToolStripMenuItem4,
            this.крест3х3ToolStripMenuItem4});
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.gradToolStripMenuItem.Text = "Grad";
            // 
            // квадрат3х3ToolStripMenuItem4
            // 
            this.квадрат3х3ToolStripMenuItem4.Name = "квадрат3х3ToolStripMenuItem4";
            this.квадрат3х3ToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.квадрат3х3ToolStripMenuItem4.Text = "Квадрат(3х3)";
            this.квадрат3х3ToolStripMenuItem4.Click += new System.EventHandler(this.квадрат3х3ToolStripMenuItem4_Click);
            // 
            // квадрат5х5ToolStripMenuItem4
            // 
            this.квадрат5х5ToolStripMenuItem4.Name = "квадрат5х5ToolStripMenuItem4";
            this.квадрат5х5ToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.квадрат5х5ToolStripMenuItem4.Text = "Квадрат(5х5)";
            this.квадрат5х5ToolStripMenuItem4.Click += new System.EventHandler(this.квадрат5х5ToolStripMenuItem4_Click);
            // 
            // крест3х3ToolStripMenuItem4
            // 
            this.крест3х3ToolStripMenuItem4.Name = "крест3х3ToolStripMenuItem4";
            this.крест3х3ToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.крест3х3ToolStripMenuItem4.Text = "Крест(3х3)";
            this.крест3х3ToolStripMenuItem4.Click += new System.EventHandler(this.крест3х3ToolStripMenuItem4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 395);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(736, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Омена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перерносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крест3х3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадрат3х3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem квадрат5х5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem крест3х3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem квадрат3х3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem квадрат5х5ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem крест3х3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem квадрат3х3ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem квадрат5х5ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крест3х3ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem квадрат3х3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадрат5х5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадрат3х3ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem квадрат5х5ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem крест3х3ToolStripMenuItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

